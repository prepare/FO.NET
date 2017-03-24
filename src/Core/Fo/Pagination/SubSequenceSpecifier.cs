//Apache2, 2017, WinterDev
//Apache2, 2009, griffm, FO.NET
namespace Fonet.Fo.Pagination
{
    internal interface SubSequenceSpecifier
    {
        string GetNextPageMaster(int currentPageNumber, bool thisIsFirstPage, bool isEmptyPage);

        void Reset();
    }
}