//Apache2, 2017, WinterDev
//Apache2, 2009, griffm, FO.NET
namespace Fonet.Fo.Flow
{
    internal class TableHeader : AbstractTableBody
    {
        new internal class Maker : FObj.Maker
        {
            public override FObj Make(FObj parent, PropertyList propertyList)
            {
                return new TableHeader(parent, propertyList);
            }
        }

        new public static FObj.Maker GetMaker()
        {
            return new TableHeader.Maker();
        }

        public TableHeader(FObj parent, PropertyList propertyList)
            : base(parent, propertyList)
        {
            this.name = "fo:table-header";
        }

    }
}