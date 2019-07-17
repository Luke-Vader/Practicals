using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication6
{
    class Emp {

        public string name{get; set;}
        public int sal{get; set;}
        public string desig{get; set;}
        public string dept{get; set;}

        public Emp(string name, int sal, string desig, string dept) {

            this.name = name;
            this.sal =  sal;
            this.desig = desig;
            this.dept = dept;

        }

    }


    class Lambda{

        static void Main(stirng[] args) {

            Emp e1 = new Emp("John", 40000, "CEO", "IT");
            Emp e2 = new Emp("Sam", 30000, "GM", "IT");
            Emp e3 = new Emp("Rajesh", 50000, "CGM", "Marketing");
            Emp e4 = new Emp("Laxman", 70000, "CEO", "IT");            

            List<Emp> list = new List<>();

            list.add(e1);
            list.add(e2);
            list.add(e3);
            list.add(e4);

            var m1 = list.Max(x => x.sal);

            Console.WriteLine("Max Salary: " + m1.ToString());

            List<Emp> yy = list.Where(x => x.sal == m1).ToList();

            Console.WriteLine(yy.First().name);

        }

    }
}
