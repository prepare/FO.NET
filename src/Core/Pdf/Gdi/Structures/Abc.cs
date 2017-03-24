//Apache2, 2017, WinterDev
//Apache2, 2009, griffm, FO.NET
using System.Runtime.InteropServices;

namespace Fonet.Pdf.Gdi {
    /// <summary>
    ///     The ABC structure contains the width of a character in a TrueType font. 
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    internal struct Abc {
        public int abcA;
        public uint abcB;
        public int abcC;
    }
}