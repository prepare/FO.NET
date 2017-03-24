//Apache2, 2017, WinterDev
//Apache2, 2009, griffm, FO.NET
namespace Fonet.Fo
{
    internal interface IShorthandParser
    {
        Property GetValueForProperty(
            string propName, PropertyMaker maker, PropertyList propertyList);
    }
}