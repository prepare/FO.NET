//Apache2, 2017, WinterDev
//Apache2, 2009, griffm, FO.NET
namespace Fonet.Pdf.Filter
{
    public interface IFilter
    {
        PdfObject Name
        {
            get;
        }

        PdfObject DecodeParms
        {
            get;
        }

        bool HasDecodeParams
        {
            get;
        }

        byte[] Encode(byte[] data);

    }
}