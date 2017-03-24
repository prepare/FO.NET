//Apache2, 2017, WinterDev
//Apache2, 2009, griffm, FO.NET
namespace Fonet.Fo.Properties
{
    internal class SourceDocumentMaker : StringProperty.Maker
    {
        new public static PropertyMaker Maker(string propName)
        {
            return new SourceDocumentMaker(propName);
        }

        protected SourceDocumentMaker(string name) : base(name) { }


        public override bool IsInherited()
        {
            return false;
        }

        private Property m_defaultProp = null;

        public override Property Make(PropertyList propertyList)
        {
            if (m_defaultProp == null)
            {
                m_defaultProp = Make(propertyList, "none", propertyList.getParentFObj());
            }
            return m_defaultProp;

        }

    }
}