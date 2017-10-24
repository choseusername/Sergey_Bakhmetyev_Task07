using System;
using ShapesLibrary;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            ICanvas canvas = new ConsoleCanvas();

            IFigure[] fig = new IFigure[10];
            Random rand = new Random();

            for (int i = 0; i < fig.Length; i++)
            {
                Point randomPosition = new Point(rand.NextDouble() * 100.0, rand.NextDouble() * 100.0);
                switch (rand.Next(4))
                {
                    case 0:
                        fig[i] = new Rectangle(randomPosition, 5.0, 5.0);
                        break;
                    case 1:
                        fig[i] = new Round(randomPosition, rand.NextDouble() * 100.0);
                        break;
                    case 2:
                        fig[i] = new Ring(randomPosition, 20.0, 10.0);
                        break;
                    case 3:
                        fig[i] = new Line(randomPosition, randomPosition);
                        break;
                    default:
                        break;
                }
            }

            foreach(IFigure figure in fig)
            {
                figure.Draw(canvas);
            }
            Console.ReadKey();
        }
    }
}
