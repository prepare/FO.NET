using System.Collections;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Text;
using Fonet.Pdf.Security;

namespace Fonet.Pdf
{
    public class PdfWriter
    {
        public static readonly byte[] DefaultNewLine = { 0x0d, 0x0a };

        public static readonly byte[] DefaultSpace = { 0x20 };

        public static readonly byte[] DefaultBinaryComment = { 0x25, 0xe2, 0xe3, 0xcf, 0xd3 };

        private Stream stream;

        private long position;

        private SecurityManager securityManager;

        private Stack indirectObjects = new Stack();

        private byte[] newLine = DefaultNewLine;

        private byte[] space = DefaultSpace;

        private byte[] binaryComment = DefaultBinaryComment;

        public PdfWriter(Stream stream)
        {
            Debug.Assert(stream != null);
            Debug.Assert(stream.CanWrite);
            this.stream = stream;
        }

        public SecurityManager SecurityManager
        {
            get { return securityManager; }
            set { securityManager = value; }
        }

        internal PdfObject EnclosingIndirect
        {
            get
            {
                Debug.Assert(indirectObjects.Count > 0);
                return (PdfObject)indirectObjects.Peek();
            }
        }

        public void Close()
        {
            stream.Close();
        }

        public void WriteHeader(PdfVersion version)
        {

            WriteLine(version.Header);
        }

        public void WriteBinaryComment()
        {

            WriteLine(binaryComment);
        }

        public void Write(PdfObject obj)
        {
#if DEBUG
            dbugLineCheck();
#endif
            Debug.Assert(obj != null);
            if (obj.IsIndirect)
            {
                indirectObjects.Push(obj);
                obj.WriteIndirect(this);
                indirectObjects.Pop();
            }
            else
            {
                obj.Write(this);
            }
        }

        public void WriteLine(PdfObject obj)
        {
#if DEBUG
            dbugLineCheck();
#endif
            Debug.Assert(obj != null);
            Write(obj);
            WriteLine();
        }

        public void Write(int val)
        {

            byte[] data = Encoding.ASCII.GetBytes(val.ToString());
            Write(data);
        }

        public void WriteLine(int val)
        {
#if DEBUG
            dbugLineCheck();
#endif
            Write(val);
            WriteLine();
        }

        public void Write(decimal val)
        {

            // TODO: This conversion could produce a number expressed
            // in scientific format which is not supported by PDF.
            Debug.Assert(val.ToString().IndexOfAny(new char[] { 'e', 'E' }) == -1);

            // The invariant culture will ensure a dot ('.') is used as the 
            // decimal point.  The French culture, for example, uses a comma.
            byte[] data = Encoding.ASCII.GetBytes(val.ToString(CultureInfo.InvariantCulture));
            Write(data);
        }

        public void WriteLine(decimal val)
        {
#if DEBUG
            dbugLineCheck();
#endif
            Write(val);
            WriteLine();
        }

        public void WriteSpace()
        {

            stream.Write(space, 0, space.Length);
            position += space.Length;
        }



#if DEBUG
        int dbugWriteLineCount;
        void dbugLineCheck()
        {
            if (dbugWriteLineCount == 4)
            {

            }

        }
#endif
        public void WriteLine()
        {
#if DEBUG

            byte[] dbugWriteLineInfo = System.Text.Encoding.ASCII.GetBytes(
                ("\r\n % dbug_line:" + dbugWriteLineCount + "\r\n").ToCharArray());
            stream.Write(dbugWriteLineInfo, 0, dbugWriteLineInfo.Length);
            position += dbugWriteLineInfo.Length;
            dbugWriteLineCount++;
#endif
            stream.Write(newLine, 0, newLine.Length);
            position += newLine.Length;
        }

        public void WriteByte(byte value)
        {
#if DEBUG
            dbugLineCheck();
#endif
            stream.WriteByte(value);
            position++;
        }

        public void Write(byte[] data)
        {
#if DEBUG
            dbugLineCheck();
#endif
            stream.Write(data, 0, data.Length);
            position += data.Length;
        }

        public void WriteLine(byte[] data)
        {

            Write(data);
            WriteLine();
        }

        public void WriteKeyword(Keyword keyword)
        {

            Write(KeywordEntries.GetKeyword(keyword));
        }

        public void WriteKeywordLine(Keyword keyword)
        {
#if DEBUG
            dbugLineCheck();
#endif
            WriteKeyword(keyword);
            WriteLine();
        }

        public long Position
        {
            get { return position; }
        }

        public byte[] NewLine
        {
            get { return newLine; }
            set { newLine = value; }
        }

        public byte[] BinaryComment
        {
            get { return binaryComment; }
            set { binaryComment = value; }
        }
    }
}