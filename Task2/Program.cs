using System;

namespace Task2
{
    class Program
    {
        static void PrintSeries(ISeries series)
        {
            series.Reset();

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(series.GetCurrent());
                series.MoveNext();
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Геометрическая прогрессия b = {0}, q = {1}", 1.0, 2.0);
            GeometricProgression progression = new GeometricProgression(1.0, 2.0);
            PrintSeries(progression);
            Console.ReadKey();
        }
    }
}
