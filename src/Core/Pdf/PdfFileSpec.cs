//Apache2, 2017, WinterDev
//Apache2, 2009, griffm, FO.NET
namespace Fonet.Pdf
{
    public sealed class PdfFileSpec : PdfDictionary
    {
        public PdfFileSpec(PdfObjectId objectId, string filename)
            : base(objectId)
        {
            this[PdfName.Names.Type] = PdfName.Names.FileSpec;
            this[PdfName.Names.F] = new PdfString(filename);
        }

    }
}