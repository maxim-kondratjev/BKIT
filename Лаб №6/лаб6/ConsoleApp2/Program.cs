using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Worker
    {
        [Attr("Имя")]
        private int age { get; set; }
        public string name { get; set; }
        [Attr("Времяпровождение")]
        public string timespending { get;  set; }
        public Worker(string name, int age)
        {
            this.age = age;
            this.name = name;
        }
        public Worker(string name)
        {
            this.age = 30;
            this.name = name;
        }
        public Worker(int age)
        {
            this.name = "Вася";
            this.age = age;
        }
        public void Work(int type)
        {
            switch (type)
            {
                case 1:
                    Console.WriteLine("Сижу в офисе");
                    break;
                case 2:
                    Console.WriteLine("Иду в бар");
                    break;
                case 3:
                    Console.WriteLine("Получаю зарплату");
                    break;
                default:
                    Console.WriteLine("Лечу на гаваи");
                    break;
            }
        }
    }
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = false, Inherited = false)]
    class Attr : Attribute{
        public string description { get; set; }
        public Attr(string str_description)
        {
            description = str_description;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Type t = typeof(Worker);
            Console.WriteLine("Конструкторы:");
            foreach(var x in t.GetConstructors())
            {
                Console.WriteLine(x);
            }
            Console.WriteLine("\nСвойства:");
            foreach (var x in t.GetProperties())
            {
                Console.WriteLine(x);
            }
            Console.WriteLine("\nМетоды:");
            foreach (var x in t.GetMethods())
            {
                Console.WriteLine(x);
            }

            Console.WriteLine("\nАтрибуты свойств:");
            foreach (var x in t.GetProperties())
            {
                var isAttr = x.GetCustomAttributes(typeof(Attr), false);
                if (isAttr.Length > 0)
                {
                    Console.WriteLine(isAttr[0]);
                }
            }
            Worker Worker1 = new Worker(18);
            object[] param = new object[] { 3 };
            Console.WriteLine();
            t.InvokeMember("Work", System.Reflection.BindingFlags.InvokeMethod, null, Worker1, param);
            Console.ReadKey();
        }
    }
}
