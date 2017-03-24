//Apache2, 2017, WinterDev
//Apache2, 2009, griffm, FO.NET
namespace Fonet.Pdf
{
    public sealed class PdfNumeric : PdfObject
    {
        private decimal val;

        public PdfNumeric(decimal val)
        {
            this.val = val;
        }

        public PdfNumeric(decimal val, PdfObjectId objectId)
            : base(objectId)
        {
            this.val = val;
        }

        protected internal override void Write(PdfWriter writer)
        {
            writer.Write(val);
        }

    }
}