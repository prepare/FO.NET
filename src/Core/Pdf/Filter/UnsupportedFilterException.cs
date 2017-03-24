//Apache2, 2017, WinterDev
//Apache2, 2009, griffm, FO.NET
namespace Fonet.Pdf.Filter
{
    using System;

    public class UnsupportedFilterException : Exception
    {
        public UnsupportedFilterException(string filterName)
            : base(String.Format("The {0} filter is not supported.", filterName))
        {
        }
    }
}