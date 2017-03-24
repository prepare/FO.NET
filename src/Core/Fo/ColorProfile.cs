//Apache2, 2017, WinterDev
//Apache2, 2009, griffm, FO.NET
namespace Fonet.Fo
{
    internal class ColorProfile : ToBeImplementedElement
    {
        new internal class Maker : FObj.Maker
        {
            public override FObj Make(FObj parent, PropertyList propertyList)
            {
                return new ColorProfile(parent, propertyList);
            }
        }

        new public static FObj.Maker GetMaker()
        {
            return new ColorProfile.Maker();
        }

        protected ColorProfile(FObj parent, PropertyList propertyList)
            : base(parent, propertyList)
        {
            this.name = "fo:color-profile";
        }

    }
}