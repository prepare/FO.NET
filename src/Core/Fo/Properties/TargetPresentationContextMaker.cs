//Apache2, 2017, WinterDev
//Apache2, 2009, griffm, FO.NET
using Fonet.DataTypes;

namespace Fonet.Fo.Properties
{
    internal class TargetPresentationContextMaker : ToBeImplementedProperty.Maker
    {
        new public static PropertyMaker Maker(string propName)
        {
            return new TargetPresentationContextMaker(propName);
        }

        protected TargetPresentationContextMaker(string name) : base(name) { }

        public override bool IsInherited()
        {
            return false;
        }

        private Property m_defaultProp = null;

        public override Property Make(PropertyList propertyList)
        {
            if (m_defaultProp == null)
            {
                m_defaultProp = Make(propertyList, "use-target-processing-context", propertyList.getParentFObj());
            }
            return m_defaultProp;
        }

    }
}