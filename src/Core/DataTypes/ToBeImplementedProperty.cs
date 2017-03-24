//Apache2, 2017, WinterDev
//Apache2, 2009, griffm, FO.NET
namespace Fonet.DataTypes
{
    using Fonet.Fo;

    internal class ToBeImplementedProperty : Property
    {
        internal class Maker : PropertyMaker
        {
            public Maker(string propName) : base(propName)
            {
            }

            public override Property ConvertProperty(
                Property p, PropertyList propertyList, FObj fo)
            {
                if (p is ToBeImplementedProperty)
                {
                    return p;
                }
                ToBeImplementedProperty val = new ToBeImplementedProperty(PropName);
                return val;
            }
        }

        public ToBeImplementedProperty(string propName)
        {
            FonetDriver.ActiveDriver.FireFonetWarning(
                "property - \"" + propName + "\" is not implemented yet.");
        }

    }
}