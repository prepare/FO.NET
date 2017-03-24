//Apache2, 2017, WinterDev
//Apache2, 2009, griffm, FO.NET
using Fonet.DataTypes;

namespace Fonet.Fo
{
    internal class LengthPairProperty : Property
    {
        internal class Maker : LengthProperty.Maker
        {
            protected Maker(string name) : base(name) { }

        }

        private LengthPair lengthPair;

        public LengthPairProperty(LengthPair lengthPair)
        {
            this.lengthPair = lengthPair;
        }

        public override LengthPair GetLengthPair()
        {
            return this.lengthPair;
        }

        public override object GetObject()
        {
            return this.lengthPair;
        }

    }
}