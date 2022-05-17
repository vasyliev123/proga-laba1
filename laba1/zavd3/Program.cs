using System;
using System.Collections.Generic;
using System.Linq;
namespace zavd3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Дана послідовність цілих чисел. Знайти кількість її додатніх двозначних елементів,
            //а також їх середнє арифметичне (як дійсне число). Якщо необхідні елементи відсутні,
            //то двічі вивести 0 (перший раз як ціле, другий - як дійсне).
            List<int> list = new List<int>
            {
                
                1,92,-3,-42,5,6,7,58,34,56,12,333,57,-34,11,324,-7777,243,54,-1,1
            };
            int a = 0;
            float b = 0f;
            int v = list.Count(a => a > 9 && a < 100);
           
            if (v == 0)
                Console.WriteLine($"{a}{b}");
            else
            {
                Console.WriteLine($"number of positive two-digit elements: {v}");
                double y = list.Where(a => a > 9 && a < 100).Average();
                Console.WriteLine($"avarge: {y}");
            }
        }
    }
}
