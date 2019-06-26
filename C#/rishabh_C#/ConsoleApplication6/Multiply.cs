using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication6
{
    class Multiply
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a Number: ");
            string s = Console.ReadLine();
            int n = int.Parse(s);

            for (int i = 1; i <= 10; ++i)
            {
                Console.WriteLine("{0} x {1} = {2}", s, i, n * i);
            }

            Console.ReadKey();
        }

    }
}
