//Apache2, 2017, WinterDev
//Apache2, 2009, griffm, FO.NET
using System.Collections;

namespace Fonet.Pdf.Gdi {
    /// <summary>
    /// Summary description for UnicodeRangeComparer.
    /// </summary>
    internal class UnicodeRangeComparer : IComparer {
        public int Compare(object x, object y) {
            UnicodeRange left = (UnicodeRange) x;
            char charToLocate = (char) y;

            // Two unicode ranges will never overlap
            if (left.End < charToLocate) {
                return -1;
            }

            if (left.Start > charToLocate) {
                return 1;
            }

            return 0;
        }
    }
}