using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;


namespace HelloWorld
{
    class Breakfast
    {
        static void Main(string[] args)
        {
            XDocument menu = XDocument.Load("C:/Users/rishabh/Documents/GitHub/Practicals/C#/rishabh_C#/ConsoleApplication6/menu.xml");
            IEnumerable<string> names = from item in menu.
                                       Element("breakfast").
                                           Elements("food")
                                        where (int)item.Element("calories") > 800
                                        select item.Element("name").Value;
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }
            Console.ReadKey();
        }

    }
}