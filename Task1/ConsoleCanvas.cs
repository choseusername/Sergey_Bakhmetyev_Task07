using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShapesLibrary;

namespace Task1
{
    class ConsoleCanvas : ICanvas
    {
        public void DrawCircle(Point position, double radius)
        {
            Console.WriteLine("Окружность в точке {0} с радиусом {1}.", position, radius);
        }

        public void DrawLine(Point from, Point to)
        {
            Console.WriteLine("Линия из точки {0} в точку {1}.", from, to);
        }

        public void DrawRect(Point p1, Point p2)
        {
            Console.WriteLine("Прямоугольник {0} {1} состоящий из линий.", p1, p2);
            DrawLine(new Point(p1.X, p1.Y), new Point(p1.X, p2.Y));
            DrawLine(new Point(p1.X, p2.Y), new Point(p2.X, p2.Y));
            DrawLine(new Point(p2.X, p2.Y), new Point(p2.X, p1.Y));
            DrawLine(new Point(p2.X, p1.Y), new Point(p1.X, p1.Y));
        }
    }
}
