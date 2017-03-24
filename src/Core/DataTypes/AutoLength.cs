//Apache2, 2017, WinterDev
//Apache2, 2009, griffm, FO.NET
namespace Fonet.DataTypes
{
    internal class AutoLength : Length
    {
        public override bool IsAuto()
        {
            return true;
        }

        public override string ToString()
        {
            return "auto";
        }
    }
}