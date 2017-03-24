//Apache2, 2017, WinterDev
//Apache2, 2009, griffm, FO.NET
using Fonet.DataTypes;

namespace Fonet.Fo.Expr
{
    internal interface IFunction
    {
        int NumArgs
        {
            get;
        }

        IPercentBase GetPercentBase();

        Property Eval(Property[] args, PropertyInfo propInfo);
    }

}