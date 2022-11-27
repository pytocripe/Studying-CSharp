using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Draw four different triangles in the console using nested loops. The fifth homework assignment from #SimpleCode.


            Console.Write("Enter the height of the triangle: ");
            int height = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Normal triangle: ");

            for (int i = 0; i <= height; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write("#");
                }
                Console.WriteLine("");
            }

            Console.WriteLine();
            Console.WriteLine("Triangle in reverse: ");

            for (int i = 0; i <= height; i++)
            {
                for (int j = height; j >= i; j--)
                {
                    Console.Write("#");
                }
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine("I don't know what to call this triangle: ");

            for (int i = 0; i <= height; i++)
            {
                for (int g = height; g > i; g--)
                {
                    Console.Write(" ");
                }

                for (int j = 0; j <= i; j++)
                {
                    Console.Write("#");
                }
                Console.WriteLine("");
            }

            Console.WriteLine();
            Console.WriteLine("'I don't know what to call this triangle' in reverse order: ");

            for (int i = 0; i <= height; i++)
            {
                for (int g = 0; g < i; g++)
                {
                    Console.Write(" ");
                }

                for (int j = height; j >= i; j--)
                {
                    Console.Write("#");
                }
                Console.WriteLine();
            }


        }
    }
}
