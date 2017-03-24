//Apache2, 2017, WinterDev
//Apache2, 2009, griffm, FO.NET
using System.Diagnostics;

namespace Fonet.Pdf
{
    public abstract class PdfObject
    {

#if DEBUG
        static int dbugTotal;
        public readonly int dbugId = dbugTotal++;
#endif
        private PdfObjectId objectId;

        public PdfObject()
        {
#if DEBUG
            //if (dbugId == 142 || dbugId == 153)
            //{

            //}
#endif
        }

        public PdfObject(PdfObjectId objectId)
        {
#if DEBUG
            //if (dbugId == 142 || dbugId == 153)
            //{ 
            //}
#endif
            this.objectId = objectId;
        }

        protected internal abstract void Write(PdfWriter writer);

        protected internal void WriteIndirect(PdfWriter writer)
        {
            Debug.Assert(writer != null);
            Debug.Assert(IsIndirect);

            // Write the object number and generation number 
            // followed by the keyword 'obj' and finally a newline.
            writer.Write(objectId.ObjectNumber);
            writer.WriteSpace();
            writer.Write(objectId.GenerationNumber);
            writer.WriteSpace();
            writer.WriteKeywordLine(Keyword.Obj);

            // Write the objects value, subclasses will override this.
            Write(writer);

            // Follow the objects value with a newline and then the keyword 'endobj'.
            writer.WriteLine();
            writer.WriteKeyword(Keyword.EndObj);
        }

        public PdfObjectReference GetReference()
        {
            Debug.Assert(IsIndirect, "Cannot get a reference to a direct object.");
            return new PdfObjectReference(this);
        }

        public bool IsIndirect
        {
            get { return objectId.ObjectNumber != 0; }
        }

        public PdfObjectId ObjectId
        {
            get { return objectId; }
        }

    }
}