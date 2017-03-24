//Apache2, 2017, WinterDev
//Apache2, 2009, griffm, FO.NET
using Fonet.Render.Pdf;

namespace Fonet.Layout
{
    internal class DisplaySpace : Space
    {
        private int size;

        public DisplaySpace(int size)
        {
            this.size = size;
        }

        public int getSize()
        {
            return size;
        }

        public override void render(PdfRenderer renderer)
        {
            renderer.RenderDisplaySpace(this);
        }

    }
}