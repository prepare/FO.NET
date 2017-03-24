//Apache2, 2017, WinterDev
//Apache2, 2009, griffm, FO.NET
using System.Runtime.InteropServices;

namespace Fonet.Pdf.Gdi {
    [StructLayout(LayoutKind.Sequential, CharSet=CharSet.Auto)]
    internal struct EnumLogFont {
        public LogFont elfLogFont;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst=32)] public char[] elfFullName;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst=64)] public char[] elfStyle;
    } ;
}