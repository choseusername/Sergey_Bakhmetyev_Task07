using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
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
            Console.WriteLine("Арифметическая прогрессия start = {0}, step = {1}:", 0.0, 1.0);
            ArithmeticalProgression progression = new ArithmeticalProgression(0.0, 1.0);
            PrintSeries(progression);

            Console.WriteLine();

            Console.WriteLine("Структура \"List\" реализующая интерфейс \"IIndexableSeries\" ");
            List list = new List(new double[] { 1.0, 2.0, 3.0, 4.0 });
            PrintSeries(list);

            Console.ReadKey();
        }
    }
}
