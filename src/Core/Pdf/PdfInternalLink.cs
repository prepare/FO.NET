//Apache2, 2017, WinterDev
//Apache2, 2009, griffm, FO.NET
namespace Fonet.Pdf
{
    public class PdfInternalLink : IPdfAction
    {
        private PdfObjectReference goToReference;

        public PdfInternalLink(PdfObjectReference goToReference)
        {
            this.goToReference = goToReference;
        }

        public PdfObject GetAction()
        {
            return goToReference;
        }

    }
}