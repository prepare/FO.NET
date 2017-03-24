//Apache2, 2017, WinterDev
//Apache2, 2009, griffm, FO.NET
using Fonet.Layout;

namespace Fonet.Fo
{
    internal class ToBeImplementedElement : FObj
    {
        protected ToBeImplementedElement(FObj parent, PropertyList propertyList)
            : base(parent, propertyList) { }

        public override Status Layout(Area area)
        {
            return new Status(Status.OK);
        }
    }
}