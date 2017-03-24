//Apache2, 2017, WinterDev
//Apache2, 2009, griffm, FO.NET
namespace Fonet.Fo.Properties
{
    internal class MarginBottomMaker : LengthProperty.Maker
    {
        new public static PropertyMaker Maker(string propName)
        {
            return new MarginBottomMaker(propName);
        }

        protected MarginBottomMaker(string name) : base(name) { }


        public override bool IsInherited()
        {
            return false;
        }

        private Property m_defaultProp = null;

        public override Property Make(PropertyList propertyList)
        {
            if (m_defaultProp == null)
            {
                m_defaultProp = Make(propertyList, "0pt", propertyList.getParentFObj());
            }
            return m_defaultProp;

        }

    }
}