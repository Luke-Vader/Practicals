using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication6
{
    class Add_janak
    {
        static void Main(string[] args)
        {
            int i, j, n = 3;
            int m = 3, p = 3, q = 3;
            int[,] arr1 = new int[3, 3];
            int[,] arr2 = new int[3, 3];
            int[,] arr3 = new int[3, 3];

            Console.Write("Enter elements in the 1st matrix");

            for (i = 0; i < m; i++)
            {
                for (j = 0; j < n; j++)
                {
                    Console.Write("\n element - [{0},{1}]", i, j);
                    arr1[i, j] = int.Parse(Console.ReadLine());
                }
            }
            Console.Write("Enter elements in the second matrix");

            for (i = 0; i < p; i++)
            {
                for (j = 0; j < q; j++)
                {
                    Console.Write("\n element - [{0},{1}]", i, j);
                    arr2[i, j] = int.Parse(Console.ReadLine());
                }
            }



            if (n != p)
            {
                Console.WriteLine("Matrix multiplication not possible");
            }
            else
            {
                arr3 = new int[m, q];
                for (i = 0; i < m; i++)
                {
                    for (j = 0; j < q; j++)
                    {
                        arr3[i, j] = 0;
                        for (int k = 0; k < n; k++)
                        {
                            arr3[i, j] += arr1[i, k] * arr2[k, j];
                        }
                    }
                }
                Console.Write("Multiplication  of two");
                for (i = 0; i < n; i++)
                {
                    Console.Write("\n");
                    for (j = 0; j < n; j++)
                    {
                        Console.Write("{0}\t", arr3[i, j]);
                    }
                    Console.Write("\n");
                }

                Console.ReadKey();
            }

        }
    }
}
