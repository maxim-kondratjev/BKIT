using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Лаб__2
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle c = new Rectangle(3, 4);
            Square a = new Square(3);
            Circle b = new Circle(1);
            a.Print();
            b.Print();
            c.Print();
             System.Console.Read();
        }
        
    }
}
