using System;
using System.Collections.Generic;
using System.Linq;

namespace Laba7
{
    class Program
    {
        class Worker
        {
            public int id;
            public string last_name;
            public int id_department;
            public Worker(int i, string l, int d)
            {
                id = i;
                last_name = l;
                id_department = d;
            }
            public override string ToString()
            {
                return id + " Фамилия: " + last_name + "\n    ID отдела: " + id_department;
            }
        }
        class Department
        {
            public int id;
            public string name;
            public Department(int i, string n)
            {
                id = i;
                name = n;
            }
            public override string ToString()
            {
                return id + " " + name;
            }
        }

        class Departament_workers
        {
            public int worker_id;
            public int dep_id;
            public Departament_workers(int i, int j)
            {
                worker_id = i;
                dep_id = j;
            }
        }

        static void Main(string[] args)
        {
            List<Worker> workers = new List<Worker>()
            {
                new Worker(1, "Кондратьев", 1),
                new Worker(2, "Реутов", 1),
                new Worker(3, "Чеснавкий", 1),
                new Worker(4, "Андреев", 2),
                new Worker(5, "Юсипов", 2),
                new Worker(6, "Кириллов", 3),
                new Worker(7, "Лаптев", 3)
            };

            List<Department> departments = new List<Department>()
            {
                new Department(1, "Отдел доставки"),
                new Department(2, "Отдел клининга"),
                new Department(3, "Отдел слесарей")
            };

            List<Departament_workers> dep_workers = new List<Departament_workers>()
            {
                new Departament_workers(1, 1),
                new Departament_workers(1, 2),
                new Departament_workers(2, 1),
                new Departament_workers(3, 2),
                new Departament_workers(4, 2),
                new Departament_workers(4, 3),
                new Departament_workers(5, 3),
                new Departament_workers(6, 2),
                new Departament_workers(7, 3)
            };

            Console.WriteLine("Список всех сотрудников: ");
            var q1 = from x in departments
                     join y in workers on x.id equals y.id_department into t
                     select new { dep = x, dep_workers = t };
            foreach(var x in q1)
            {
                Console.WriteLine(x.dep);
                foreach(var y in x.dep_workers)
                {
                    Console.WriteLine("  " + y);
                }
                Console.WriteLine();
            }

            Console.WriteLine("Сотрудники с фамилией, начинающейся на А");
            var q2 = from x in workers
                     where x.last_name[0] == 'А'
                     select x;
            foreach(var x in q2)
            {
                Console.WriteLine(x);
            }

            Console.WriteLine("\n" + "Отделы и количество сотрудников");
            var q3 = from x in departments select x;
            foreach(var x in q3)
            {
                Console.WriteLine(x);
                var q4 = from y in workers
                         where y.id_department == x.id
                         select y;
                Console.WriteLine("Количество сотрудников: " + q4.Count());
            }

            Console.WriteLine("\nОтделы, в которых у всех сотрудников фамилия начинается с буквы А");
            var q5 = from x in workers
                     group x by x.id_department into g
                     where g.All(x => x.last_name[0] == 'А')
                     select g.Key;

            foreach (var x in q5)
            {
                var q6 = from y in departments
                         where y.id == x
                         select y;
                Console.WriteLine(q6.ElementAt(0));
            }

            Console.WriteLine("\nОтделы, в которых хотя бы у одного сотрудника фамилия на А");
            var q7 = from x in workers
                     group x by x.id_department into g
                     where g.Any(x => x.last_name[0] == 'А')
                     select g.Key;

            foreach (var x in q7)
            {
                var q8 = from y in departments
                         where y.id == x
                         select y;
                Console.WriteLine(q8.ElementAt(0));
            }

            Console.WriteLine("\nМногие-ко-многим");

            var q9 = from dep in departments
                     join l in dep_workers on dep.id equals l.dep_id into temp
                     from t in temp
                     group t by t.dep_id into gr
                     select new { dep = gr.Key, work = gr};
                     

            foreach(var x in q9)
            {
                Console.WriteLine(x.dep + " отдел");
                foreach(var y in x.work)
                {
                    Console.WriteLine("    " + y.worker_id + " сотрудник");
                }
            }

            Console.WriteLine("\nКоличество сотрудников");
            foreach (var x in q9)
            {
                Console.WriteLine(x.dep + " отдел, количество сотрудников - " + x.work.Count());
            }

            Console.ReadKey();
        }
    }
}
