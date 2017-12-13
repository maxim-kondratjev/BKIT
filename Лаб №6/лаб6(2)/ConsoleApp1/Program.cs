using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        public delegate int d1(int x1, string x2);

        public static List<int> SumArrays(List<int> x, List<string> str, d1 func)
        {
            if (x.Count != str.Count)
            {
                List<int> t = new List<int>(-1);
                return t;
            }
            else
            {
                List<int> t = new List<int>();
                for (int i = 0; i < x.Count; i++)
                {
                    t.Add(func(x[i], str[i]));
                }
                return t;
            }
        }

        public static List<int> SumArraysFunc(List<int> x, List<string> str, Func<int, string, int> func)
        {
            if (x.Count != str.Count)
            {
                List<int> t = new List<int>(-1);
                return t;
            }
            else
            {
                List<int> t = new List<int>();
                for (int i = 0; i < x.Count; i++)
                {
                    t.Add(func(x[i], str[i]));
                }
                return t;
            }
        }

        public static int Sum(int x, string str)
        {
            int result = Int32.Parse(str);
            return x + result;
        }


        static void Main(string[] args)
        {
            List<int> x = new List<int>();
            x.Add(1);
            x.Add(2);
            x.Add(3);
            List<string> str = new List<string>();
            str.Add("2");
            str.Add("3");
            str.Add("4");
            d1 sum = Sum;
            

            List<int> l1 = SumArrays(x, str, sum);
            foreach(var i in l1)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();
            List<int> l2 = SumArrays(x, str,
                (x_1, str_1) => x_1 * Int32.Parse(str_1));
            foreach (var i in l2)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();
            Func<int, string, int> sum1 = Sum;
            List<int> l3 = SumArraysFunc(x, str, sum1);
            foreach (var i in l3)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();
            Console.ReadKey();
        }

    }
}
