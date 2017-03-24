//Apache2, 2017, WinterDev
//Apache2, 2009, griffm, FO.NET
using System.Runtime.InteropServices;

namespace Fonet.Pdf.Gdi {
    [StructLayout(LayoutKind.Sequential, CharSet=CharSet.Auto)]
    internal struct KerningPair {
        public ushort wFirst;
        public ushort wSecond;
        public int iKernAmount;
    }
}