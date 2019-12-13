using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication6
{
    class Country_rishabh
    {
        static void Main(string[] args)
        {
            string[] country = { "USA", "UK", "Russia", "India" };
            int max = country.Max(x => x.Length);
            //string maxCountry = (country.Where(x => x.Length == max)).ToList();
            //Console.WriteLine("Max Country: " + maxCountry);
            Console.ReadKey();

        }
    }
}
