using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication6
{
    public class Product
    {
        public int pid { get; set; }
        public string name { get; set; }
        public int price { get; set; }

    }
    class LinqObject
    {
        static void Main(string[ ] args)
        {
            List<Product> products = Populate();
            var q = from x in products orderby x.name select x;
            foreach(var a in q)
            {
                Console.WriteLine(a.name + " " + a.price);
            }
            Console.ReadKey();
        }

        static List<Product> Populate()
        {
            List<Product> products = new List<Product>();
            products.Add(new Product { pid = 1, name = "A", price = 100 });
            products.Add(new Product { pid = 2, name = "B", price = 200 });
            products.Add(new Product { pid = 3, name = "C", price = 300 });
            return products;
        }
    }
}
