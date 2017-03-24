//Apache2, 2017, WinterDev
//Apache2, 2009, griffm, FO.NET
namespace Fonet.Apps
{
    internal class PageSequenceResults
    {
        private string id;
        private int pageCount;

        internal PageSequenceResults(string id, int pageCount)
        {
            this.id = id;
            this.pageCount = pageCount;
        }

        internal string GetID()
        {
            return this.id;
        }

        internal int GetPageCount()
        {
            return this.pageCount;
        }
    }
}