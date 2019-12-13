using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication6
{
    class LambdaReverse
    {
        static void Main(string[] args)
        {
            IList<int> numbers = new List<int>() { 1, 2, 3, 4, 5 };
            var reverse = numbers.Reverse().ToList();
            reverse.ForEach(x => Console.Write("{0}\t", x));
            Console.ReadKey();
        } 
    }
}
