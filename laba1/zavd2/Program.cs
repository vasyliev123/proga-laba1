using System;
using System.Collections.Generic;
using Newtonsoft.Json;
 

namespace zavd2
{
    class Program
    {

        static void Main(string[] args)
        {
            //Дано два списки з однаковою кількістю елементів. Створити новий словник.
            //Перетворити перший список у набір ключів словника, а другий список додати до кожного ключа цього словника у вигляді списку
            List<String> a = new List<String>
            {
                "fish",
                "animal",
                "car"
            };
            List<String> b = new List<String>
            {
                "salmon",
                "deer",
                "Ford"
            };
            Dictionary<String, List<String>> d = new Dictionary<String, List<String>>();
            for (int i = 0; i < a.Count; i++)
            {
                d.Add(a[i], b);
            }
            /* 
            Dictionary<String, String> d = new Dictionary<String, String>();
            for (int i = 0; i < a.Count; i++)
            {
                d.Add(a[i], b[i]);
            }
            */
            string json = JsonConvert.SerializeObject(d);
            //Console.WriteLine(json);
            System.IO.File.WriteAllText(@"D:\ProgaLabi\laba1\zavd2\TextFile1.json", json);
        }
    }
}
