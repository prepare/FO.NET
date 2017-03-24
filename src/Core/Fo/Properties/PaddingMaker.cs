//Apache2, 2017, WinterDev
//Apache2, 2009, griffm, FO.NET
namespace Fonet.Fo.Properties
{
    internal class PaddingMaker : ListProperty.Maker
    {
        new public static PropertyMaker Maker(string propName)
        {
            return new PaddingMaker(propName);
        }

        protected PaddingMaker(string name) : base(name) { }


        public override bool IsInherited()
        {
            return false;
        }

    }
}