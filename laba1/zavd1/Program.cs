using System;
using System.Collections.Generic;
using System.Linq;
namespace zavd1
{
    class Program
    {
        static void Main(string[] args)
        {
            //У списку всі елементи різні. Поміняйте місцями мінімальний і максимальний елемент цього списку.
            List<Double> I = new List<double>
            {
                2,
                3,
                45.8,
                34,
                222,
                0.343
            };
            for (int i = 0; i < I.Count; i++)
                Console.WriteLine(I[i]);
            Console.WriteLine();
            var max =  I.Max();
            var min = I.Min();
            var max_ind = I.IndexOf(max);
            var min_ind = I.IndexOf(min);
            I[max_ind] = min;
            I[min_ind] = max;
            for(int i=0;i<I.Count; i++)
                Console.WriteLine(I[i]);
           
        }
    }
}
