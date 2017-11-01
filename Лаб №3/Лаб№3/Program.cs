using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Лаб3
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rect = new Rectangle(10, 20);
            Square sqr = new Square(12);
            Circle circle = new Circle(4);
            //------------------------------------------------------------
            ArrayList list = new ArrayList();
            list.Add(rect); list.Add(sqr); list.Add(circle);
            list.Sort();
            foreach (Figure obj in list)
            {
                System.Console.WriteLine(obj.GetType().Name);
                obj.Print();
            }
            Console.WriteLine("-------------------------------------------");
            List<Figure> list2 = new List<Figure>();
            list2.Add(rect); list2.Add(sqr); list2.Add(circle);
            list2.Sort();
            foreach (Figure obj in list2)
            {
                System.Console.WriteLine(obj.GetType().Name);
                obj.Print();
            }
            Console.WriteLine("-------------------------------------------");
            SparseMatrix.Matrix<Figure> drop = new SparseMatrix.Matrix<Figure>(2, 2, 1, new Circle(0));
            drop[0, 0, 0] = new Circle(1);
            drop[1, 0, 0] = new Square(2);
            drop[1, 1, 0] = new Rectangle(1, 2);
            System.Console.WriteLine(drop.ToString());
            Console.WriteLine("-------------------------------------------");
            SimpleStack<Figure> primer = new SimpleStack<Figure>();
            primer.Add(circle); primer.Add(rect); primer.Add(sqr);
            primer.Sort();

            for (int i = primer.Count; i > 0; i--)
            {
                System.Console.WriteLine(primer.Pop());
            }
            System.Console.ReadLine();
        }
    }
}