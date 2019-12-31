using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication6
{
    class A 
    {
        public A() : this("welcome")
        {
            Console.WriteLine("in A()");
        }

        public A(string s)
        {
            Console.WriteLine("in A(string)");
        }
    }

    class B : A
    {
        public B()
        {
            Console.WriteLine("in B()");
        }

        public B(string s)
        {
            Console.WriteLine("in B(string)");
        }
    }

    class Program_rishabh : B
    {
        Program_rishabh(string s)
        {
            Console.WriteLine("inside Program(string)");
        }

        Program_rishabh()
        {
            Console.WriteLine("inside Program()");        
        }

        static void Main(string[] args)
        {
            Program_rishabh program = new Program_rishabh();
            Console.ReadKey();
        }
    }
}
