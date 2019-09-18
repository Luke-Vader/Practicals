using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication6
{
    class Employee
    {
        public int number { get; set; }
        public string name { get; set; }
        public string designation { get; set; }
        public string department { get; set; }
        public int age { get; set; }
        public int salary { get; set; }

        public Employee(int number, string name, string designation, string department, int age, int salary)
        {
            this.number = number;
            this.name = name;
            this.designation = designation;
            this.department = department;
            this.age = age;
            this.salary = salary;
        }
    }
    class RealDeal
    {
        static void Main(string[] args)
        {
            IList<Employee> employees = new List<Employee>();
            for (int i = 0; i < 7; ++i)
            {
                Console.WriteLine("Enter the Records for Employee {0}\n", i + 1);
                Console.Write("\nEmployee Number:");
                int number = int.Parse(Console.ReadLine());
                Console.Write("\nEmployee Name:");
                string name = Console.ReadLine();
                Console.Write("\nEmployee Designation:");
                string designation = Console.ReadLine();
                Console.Write("\nEmployee Department:");
                string department = Console.ReadLine();
                Console.Write("\nEmployee Age:");
                int age = int.Parse(Console.ReadLine());
                Console.Write("\nEmployee Salary:");
                int salary = int.Parse(Console.ReadLine());
                Employee employee = new Employee(number, name, designation, department, age, salary);
                employees.Add(employee);

            }

        }

    }
}
