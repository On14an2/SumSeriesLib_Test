using System;
using Lib;

namespace Test
{
    internal class Program
    {
        private static SumSeriesLib calcLib = new SumSeriesLib();

        private static void Main(string[] args)
        {
            int x = Convert.ToInt32(Console.ReadLine());
            double eps = Convert.ToDouble(Console.ReadLine());
            calcLib.CalculateSumSeries(x, eps);
        }
    }
}