//Apache2, 2017, WinterDev
//Apache2, 2009, griffm, FO.NET
using Fonet.DataTypes;

namespace Fonet.Fo
{
    internal class KeepProperty : Property
    {
        internal class Maker : PropertyMaker
        {
            protected Maker(string name) : base(name) { }

        }

        private Keep keep;

        public KeepProperty(Keep keep)
        {
            this.keep = keep;
        }

        public override Keep GetKeep()
        {
            return this.keep;
        }

        public override object GetObject()
        {
            return this.keep;
        }

    }
}