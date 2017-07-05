namespace DrawingTool
{
    using System;

    public class CorDraw
    {
        public void ReadFigureAndDraw()
        {
            var figureType = Console.ReadLine();

            Figure figure = default(Figure);
            int firstSide = int.Parse(Console.ReadLine());

            if (figureType.Equals("Square"))
            {
                figure = new Square(firstSide);
            }
            else
            {
                int secondSide = int.Parse(Console.ReadLine());
                figure = new Rectangle(firstSide,secondSide);
            }

            figure.Draw();

        }
    }
}
