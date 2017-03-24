//Apache2, 2017, WinterDev
//Apache2, 2009, griffm, FO.NET
namespace Fonet.Fo.Expr
{
    internal class FonetPropValFunction : FunctionBase
    {
        public override int NumArgs
        {
            get
            {
                return 1;
            }
        }

        public override Property Eval(Property[] args, PropertyInfo pInfo)
        {
            string propName = args[0].GetString();
            if (propName == null)
            {
                throw new PropertyException("Missing property name.");
            }
            return pInfo.getPropertyList().GetProperty(propName);
        }

    }
}