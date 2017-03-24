//Apache2, 2017, WinterDev
//Apache2, 2009, griffm, FO.NET
using System;

namespace Fonet.Fo.Expr
{
    internal class PropertyException : Exception
    {
        public PropertyException(string detail) : base(detail)
        {
        }
    }
}