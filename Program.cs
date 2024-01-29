using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThucHanh3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Bai tap hien thi cac loai hinh
            int a = -1;
            while (a != 0)
            {
                Console.WriteLine("Menu");
                Console.WriteLine("1. Draw the rectangle");
                Console.WriteLine("2. Draw the square triangle");
                Console.WriteLine("3. Draw the isosceles triangle");
                Console.WriteLine("0. Exit");

                
                Console.WriteLine("Enter your choice: ");
                a = int.Parse(Console.ReadLine());
                switch (a)
                {
                    case 0:
                        Console.WriteLine("Exit the app...");
                        Console.WriteLine("");
                        break;
                    case 1:
                        Console.Write("Input length: ");
                        int length = int.Parse(Console.ReadLine());
                        Console.Write("Input width: ");
                        int width = int.Parse(Console.ReadLine());
                        int i;

                        for(int row = 0; row < width; row++)
                        {
                            for(i = 0; i < length; i++)
                            {
                                Console.Write("*");
                            }
                            Console.WriteLine();
                        }
                        Console.WriteLine();
                        break;
                    case 2:
                        Console.Write("Input vertical side: ");
                        int ver = int.Parse(Console.ReadLine());

                        int verlen = 1;
                        for (int o = 0; o < ver; o++)
                            {
                                for(int j = 0; j < verlen; j++)
                                {
                                    Console.Write("*");
                                }

                                verlen = verlen + 1;
                                Console.WriteLine();
                            }
                        break;
                    case 3:
                        Console.Write("Input line: ");
                        int n = int.Parse(Console.ReadLine());

                        for (int p = 0; p < n; p++)
                        {
                            for (int u =1; u <= n - p; u++)
                            {
                                Console.Write(' ');
                            }
                            for(int u = 0; u < 2 * p - 1; ++u)
                            {
                                Console.Write("*");
                            }

                            Console.WriteLine();
                        }
                        break;
                    default: 
                        Console.WriteLine("Please enter again!");
                        Console.WriteLine();
                        break;
                }
            }
            #endregion
        }
    }
}
