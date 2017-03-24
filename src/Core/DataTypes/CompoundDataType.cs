//Apache2, 2017, WinterDev
//Apache2, 2009, griffm, FO.NET
namespace Fonet.DataTypes
{
    using Fonet.Fo;

    internal interface ICompoundDatatype
    {
        void SetComponent(string componentName, Property componentValue, bool isDefault);

        Property GetComponent(string componentName);
    }
}