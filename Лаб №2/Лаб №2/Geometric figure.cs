using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Лаб__2
{
    abstract class Geometric_figure: print
    {
        public string type;
        public abstract double FindSquare();
        public override string ToString()
        {
            return ("Это -  " + this.type + " площадью " + this.FindSquare()+" ");
        }
        public void Print()
        {
            Console.WriteLine(this.ToString());
        }
    }

    class Rectangle : Geometric_figure
    {
        public double width;
        public double height;
        public Rectangle(double w, double h)
        {
            this.height = h;
            this.width = w;
            this.type = "прямоугольник";
        }
        public override double FindSquare()
        {
            return (height * width);
        }
        public override string ToString()
        {
            return base.ToString() + String.Format("высотой {0} шириной {1}\n", height, width);
        }
    }

    class Square : Rectangle
    {
        public Square(double side) : base(side, side)
        {
            this.type = "квадрат";
        }
        public override string ToString()
        {
            return String.Format("Это - {0} площадью {1} со стороной {2} \n",type, FindSquare(),width);
        }
    }

    class Circle:Geometric_figure
    {
        double radius;
        public Circle(double r)
        {
            this.radius = r;
            this.type = "круг";
        }
        public override double FindSquare()
        {
            return (Math.PI * radius * radius);
        }
        public override string ToString()
        {
            return base.ToString() + String.Format("радиусом {0}\n", radius);
        }
    }


}
