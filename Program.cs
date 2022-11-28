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
            //Find the sum of even numbers in the array. The eighth homework assignment from #SimpleCode.


            int sumArray = 0;
            Console.Write("Enter the number of array elements: ");
            int elements = Convert.ToInt32(Console.ReadLine());

            int[] array = new int[elements];

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("Give value " + (i + 1) + " to the element of the array: ");
                array[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 0)
                {
                    sumArray = sumArray + array[i];
                }
            }

            Console.WriteLine("The sum of even numbers in the array is: " + sumArray);
        }
    }
}
