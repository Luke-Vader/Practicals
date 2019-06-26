using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication6
{
    class A
    {
        public virtual void Test()
        {
            Console.WriteLine("A:Test()");
        }
    }

    class B : A
    {
        public override void Test()
        {
            Console.WriteLine("B:Test()");
        }
    }

    class C : B
    {
        public override void Test()
        {
            Console.WriteLine("C:Test()");
        }
    }

    class OROL : C
    {
        static void Main(string[] s)
        {

            Console.ReadKey();
        }
    }
}
