using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication6
{
    class MatrixAddition
    {

        static void Main(string[] args)
        {
            int[,] array1 = new int[3, 3];
            int[,] array2 = new int[3, 3];
            int[,] array3 = new int[3, 3];

            Console.WriteLine("Matrices shall have a size of 3 rows and 3 columns \nEnter the value of the first Matrix:\n");

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    array1[i, j] = int.Parse(Console.ReadLine());
                }
            }

            Console.Write("\nEnter the values of the second matrix\n");

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    array2[i, j] = int.Parse(Console.ReadLine());
                }
            }

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    array3[i, j] = array1[i, j] + array2[i, j];
                }
            }

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("");
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(array3[i, j] + "  ");
                }
            }

            Console.ReadKey();
        }
    }
}
