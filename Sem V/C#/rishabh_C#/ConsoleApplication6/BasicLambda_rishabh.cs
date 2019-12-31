using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication6
{
    class BasicLambda_rishabh
    {
        static void Main(string[] args)
        {
            int[] num = { 2, 5, 4, 1, 9, 7, 60, 21, 34, 54, 61, 22 };
            int max = num.Max();
            int min = num.Min();
            double avg = num.Average();
            int cnt = num.Count();
            int maxeven = num.Where(x => x % 2 == 0).Max();
            int maxodd = num.Where(x => x % 2 == 1).Max();
            int cnteven = num.Where(x => x % 2 == 0).Count();
            int cntodd = num.Where(x => x % 2 == 1).Count();
            int sumeven = num.Where(x => x % 2 == 0).Sum();
            int sumodd = num.Where(x => x % 2 == 1).Sum();

            Console.WriteLine("Max is: " + max);
            Console.WriteLine("Min is: " + min);
            Console.WriteLine("Average is: " + avg);
            Console.WriteLine("Total is: " + cnt);
            Console.WriteLine("Max of even is: " + maxeven);
            Console.WriteLine("Max of odd is: " + maxodd);
            Console.WriteLine("Sum of even is: " + cnteven);
            Console.WriteLine("Sum of odd is: " + cntodd);
            Console.ReadKey();
        }

    }
}
