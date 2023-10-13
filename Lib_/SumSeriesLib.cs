using System;

namespace Lib
{
    public class SumSeriesLib
    {
        public void CalculateSumSeries(int x,double eps)
        {
            int devider = 1;
            double res;
            double sum = 0;
            int count = 2;
            sum = devider + x;//1 + x
            Console.WriteLine(sum);
            Console.WriteLine("---------------------");
            res = x * x / (devider * count);//x^2/2!
            Console.WriteLine(res);
            sum += res; //1+x + x^2/2
            Console.WriteLine(sum);
            count++;
            Console.WriteLine("---------------------");
            while (eps <= res)
            {
                res = res * x / count;
                count++;
                sum += res;
                Console.WriteLine(res);
                Console.WriteLine(sum);
                Console.WriteLine("---------------------");
            }
        }
    }
}