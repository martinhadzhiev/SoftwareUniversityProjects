namespace DrawingTool
{
    using System;

    public abstract class Figure
    {
        protected int firstSide;
        protected int secondSide;

        public Figure(int firstSide)
        {
            this.firstSide = firstSide;
            this.secondSide = firstSide;
        }

        public void Draw()
        {
            string firstLastRow = $"|{new string('-', this.firstSide)}|";

            Console.WriteLine(firstLastRow);
            for (int i = 0; i < this.secondSide - 2; i++)
            {
                Console.WriteLine($"|{new string(' ',this.firstSide)}|");
            }
            Console.WriteLine(firstLastRow);
        }
    }
}
