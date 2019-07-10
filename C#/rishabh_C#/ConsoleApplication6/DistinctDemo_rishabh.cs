using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication6
{
    class DistinctDemo_rishabh
    {
        IList<int> numbers = new List<int>() {
            1,1,1,2,2,2,3,3,3
        };

        var distinctNumbers = numbers.Distinct().ToList();
        distinctNumbers.ForEach(x => Console.WriteLine(x));
        Console.ReadKey();

    }
}
