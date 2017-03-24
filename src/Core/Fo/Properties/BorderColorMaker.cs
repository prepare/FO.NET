//Apache2, 2017, WinterDev
//Apache2, 2009, griffm, FO.NET
namespace Fonet.Fo.Properties
{
    internal class BorderColorMaker : ListProperty.Maker
    {
        new public static PropertyMaker Maker(string propName)
        {
            return new BorderColorMaker(propName);
        }

        protected BorderColorMaker(string name) : base(name) { }


        public override bool IsInherited()
        {
            return false;
        }

    }
}