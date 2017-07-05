namespace DrawingTool
{
    using System;

    class Startup
    {
        static void Main()
        {
            CorDraw corDraw = new CorDraw();

            corDraw.ReadFigureAndDraw();
        }
    }
}
