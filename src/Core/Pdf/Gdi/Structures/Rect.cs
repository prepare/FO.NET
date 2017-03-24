//Apache2, 2017, WinterDev
//Apache2, 2009, griffm, FO.NET
using System.Runtime.InteropServices;

namespace Fonet.Pdf.Gdi
{
    /// <summary>
    ///     The Rect structure defines the coordinates of the upper-left 
    ///     and lower-right corners of a rectangle
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    internal struct Rect
    {
        public int left;
        public int top;
        public int right;
        public int bottom;
    };
}