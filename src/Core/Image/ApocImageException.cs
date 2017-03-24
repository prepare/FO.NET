//Apache2, 2017, WinterDev
//Apache2, 2009, griffm, FO.NET
namespace Fonet.Image
{
    using System;

    internal class FonetImageException : Exception
    {
        public FonetImageException()
        {
        }

        public FonetImageException(string message) : base(message)
        {
        }
    }
}