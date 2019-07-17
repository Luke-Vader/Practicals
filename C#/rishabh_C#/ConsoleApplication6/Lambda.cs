using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication6
{

    class Lambda
    {

        static void Main(string[] args) {

            Emp e1 = new Emp("John", 40000, "CEO", "IT");
            Emp e2 = new Emp("Sam", 30000, "GM", "IT");
            Emp e3 = new Emp("Rajesh", 50000, "CGM", "Marketing");
            Emp e4 = new Emp("Laxman", 70000, "CEO", "IT");            

            List<Emp> list = new List<Emp>();

            list.add(e1);
            list.add(e2);
            list.add(e3);
            list.add(e4);

            var m1 = list.Max(x => x.sal);

            Console.WriteLine("Max Salary: " + m1.ToString());

            List<Emp> yy = list.Where(x => x.sal == m1).ToList();

            Console.WriteLine(yy.First().name);

            var nameCollection = list.Select( y => y.name);
            var salarycollection = list.Select(x => x.sal>40000);
            var salnewcoll = list.Select(x => new{name = x.name, first = x.name});
            var max = list.Max(x => x.sal);
            Console.WriteLine("Max is {0}", max);
            List<Emp> hsal = list.Where(x => x.sal > 40000).ToList();
            var msal = hsal.Select(z => new {name = z.name, sal = z.sal});
            foreach (var m in msal)
            {
                Console.WriteLine(" " + m);
            }

            Console.ReadKey();
            
        }

    }

    class Emp
    {

        public string name { get; set; }
        public int sal { get; set; }
        public string desig { get; set; }
        public string dept { get; set; }

        public Emp(string name, int sal, string desig, string dept)
        {

            this.name = name;
            this.sal = sal;
            this.desig = desig;
            this.dept = dept;

        }

    }

}

/*
Find the most gareeb employee
Find the name of employees working for IT department.
Find the name of CEO.
Find the sum of all the salaries of employee working for sales department.
Find the average salary of employees working in IT department.
 */
