//Apache2, 2017, WinterDev
//Apache2, 2009, griffm, FO.NET
using System;

namespace Fonet.Pdf
{
    /// <summary>
    ///     Thrown during creation of PDF font object if the font's license
    ///     is violated, e.g. attempting to subset a font that does not permit 
    ///     subsetting.
    /// </summary>
    public class FontLicenseException : Exception
    {
        public FontLicenseException(string message)
            : base(message)
        {
        }
    }
}