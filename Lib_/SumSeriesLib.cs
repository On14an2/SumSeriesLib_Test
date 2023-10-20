using System;
using System.Collections.Generic;
using System.Security.Policy;

namespace Lib
{
    public class SumSeriesLib
    {
        public List<double> CalculateSumSeries(int x, double eps)
        {
            int devider = 1;
            double res;
            double sum = 0;
            int count = 2;
            sum = devider + x;//1 + x
            List<double> results = new List<double> { sum };
            res = x * x / (devider * count);//x^2/2!
            results.Add(res);
            sum += res; //1+x + x^2/2
            results.Add(sum);
            count++;
            while (eps <= res)
            {
                res = res * x / count;
                count++;
                sum += res;
                results.Add(res);
                results.Add(sum); 
            }
            return results;
        }
    }
}