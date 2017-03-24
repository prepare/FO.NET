//Apache2, 2017, WinterDev
//Apache2, 2009, griffm, FO.NET
using System.Runtime.InteropServices;

namespace Fonet.Pdf.Gdi {
    [StructLayout(LayoutKind.Sequential)]
    internal class GlyphSet {
        public uint cbThis = 0;
        public uint flAccel = 0;
        public uint cGlyphsSupported = 0;
        public uint cRanges = 0;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst=20000)] public byte[] ranges = null;
    }
}