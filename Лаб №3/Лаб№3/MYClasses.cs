using System;

abstract class Figure : IPrint, IComparable
{
    abstract public double find_square();

    public void Print()
    {
        System.Console.WriteLine(this.ToString());
    }

    public int CompareTo(Object rhs)
    {
        Figure obj = rhs as Figure;
        if (this.find_square() - obj.find_square() > 0.0001)
        {
            if (this.find_square() < obj.find_square())
            {
                return -1;
            }
            else
            {
                return 1;
            }
        }
        else
        {
            return 0;
        }

    }
}

class Rectangle : Figure, IPrint
{
    public double width { get; set; }
    public double heigth { get; set; }


    public Rectangle(double width1, double heigth1)
    {
        heigth = heigth1; width = width1;
    }

    public override double find_square()
    {
        return heigth * width;
    }

    public override string ToString() => "Прямоугольник "+width.ToString() + " на " + heigth.ToString();
    
}

class Square : Rectangle, IPrint
{
    public Square(double heigth1) : base(heigth1, heigth1)
    { }

    public override string ToString() => "Квадрат стороной " + heigth.ToString();
}

class Circle : Figure, IPrint
{
    public double radius { get; set; }

    public Circle(double radius1)
    {
        radius = radius1;
    }

    public override double find_square()
    {
        return (Math.PI * Math.Pow(radius, 2));
    }

    public override string ToString() => "Круг радиусом " + radius.ToString();
}

interface IPrint
{
    void Print();
}

class SimpleStack<T> : SimpleList.SimpleList<T> where T : IComparable
{


    public void Push(T element)
    {
        Add(element);
    }

    public T Pop()
    {

        SimpleList.SimpleListItem<T> itemPopped = last;
        Count = Count - 1;
        if (Count == 0)
        {
            last = null;
            first = null;
        }
        else
        {
            SimpleList.SimpleListItem<T> newLastItem = this.GetItem(Count - 1);
            newLastItem.next = null;
            last = newLastItem;
        }
        return itemPopped.data;

    }
}


