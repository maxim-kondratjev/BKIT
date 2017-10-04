using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Лаб__1__кв_ур_
{
    class Program
    {
        static void Main(string[] args)
        { 
            if (Solution(out double x1, out double x2))
            { System.Console.WriteLine("x1 = " + x1 + " x2 = " + x2); }
            else { System.Console.WriteLine("Действительных корней нет"); }

            System.Console.Read();
        }
        static int ReadABC(string coeff)
        {
            string input;
            bool flag = true;
            int a = 1;
            do
            {
                if (!flag) { System.Console.WriteLine("Некорректный ввод. Повторите операцию "); }
                System.Console.WriteLine("Введите коэффицент " + coeff + ":");
                input = System.Console.ReadLine();
                if ((input == "0") && (coeff == "A")) input = "err";
            } while (!(flag = Int32.TryParse(input, out a)));
            flag = true;
            return a;
        }
        static bool Solution (out double x1, out double x2)
        {
            int A = ReadABC("A");
            int B = ReadABC("B");
            int C = ReadABC("C");

            double D = B * B - 4 * A * C;
            if (D >= 0)
            {
                x1 = (-1 * B + Math.Sqrt(D)) / (2 * A);
                x2 = (-1 * B - Math.Sqrt(D)) / (2 * A);
                return true;
            }
            else
            {
                x1 = 0;
                x2 = 0;
                return false;
            }
        }
    }
}