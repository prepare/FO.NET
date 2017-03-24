//Apache2, 2017, WinterDev
//Apache2, 2009, griffm, FO.NET
namespace Fonet.Pdf.Filter
{
    public class DctFilter : IFilter
    {
        public DctFilter()
        {
        }

        public PdfObject Name
        {
            get
            {
                return PdfName.Names.DCTDecode;
            }
        }

        public PdfObject DecodeParms
        {
            get
            {
                return PdfNull.Null;
            }
        }

        public bool HasDecodeParams
        {
            get
            {
                return false;
            }
        }

        public byte[] Encode(byte[] data)
        {
            return data;
        }
    }
}