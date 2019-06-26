using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication6
{
    class C
    {
        public virtual void Test()
        {
            Console.WriteLine("C:Test()");
        }
    }

    class D : C
    {
        public override void Test()
        {
            Console.WriteLine("D:Test()");
        }
    }

    class E : D
    {
        public override void Test()
        {
            Console.WriteLine("E:Test()");
        }
    }

    class F : E
    {
        public override void Test()
        {
            Console.WriteLine("F:Test()");
        }
    }

    class OROL : C
    {
        static void Main(string[] s)
        {
            C c = new F();
            c.Test();
            Console.ReadKey();
        }
    }
}
