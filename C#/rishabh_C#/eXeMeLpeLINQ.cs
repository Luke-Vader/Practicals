using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("I\'m gonna do shit now");
            XDocument booksCatalog = XDocument.Load("C:/Users/windows/Documents/Visual Studio 2008/Projects/ConsoleApplication3/ConsoleApplication3/books.xml");
            IEnumerable<string> newBooks = from x in booksCatalog.Element("catalog").Elements("book")
                     where DateTime.ParseExact((string)x.Element("publish_date"), "yyyy-mm-dd", null) >
                     DateTime.ParseExact("2001-01-01", "yyyy-mm-dd", null)
                     let nm = (string)x.Element("title")
                     select nm;
            Console.WriteLine("Books published After 2001-01-01");
            foreach(string m in newBooks)
            {
                Console.WriteLine(m);
            }

            IEnumerable<string> oldBooks = from x in booksCatalog.Element("catalog").Elements("book")
                                           where DateTime.ParseExact((string)x.Element("publish_date"), "yyyy-mm-dd", null) <
                                           DateTime.ParseExact("2001-01-01", "yyyy-mm-dd", null)
                                           let nm = (string)x.Element("title")
                                           select nm;
            Console.WriteLine("Books published Before 2001-01-01");
            foreach (string m in oldBooks)
            {
                Console.WriteLine(m);
            }

            Console.ReadKey();

        }
    }
}
