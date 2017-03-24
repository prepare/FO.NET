//Apache2, 2017, WinterDev
//Apache2, 2009, griffm, FO.NET
namespace Fonet.Fo.Expr
{
    internal class AbsFunction : FunctionBase
    {
        public override int NumArgs
        {
            get
            {
                return 1;
            }
        }

        public override Property Eval(Property[] args, PropertyInfo propInfo)
        {
            Numeric num = args[0].GetNumeric();
            if (num == null)
            {
                throw new PropertyException("Non numeric operand to abs function");
            }
            return new NumericProperty(num.abs());
        }

    }

}