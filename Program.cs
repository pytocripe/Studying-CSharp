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
            //Array output in reverse order. The seventh homework assignment from #SimpleCode.

            Console.Write("Enter the number of array elements: ");
            int elements = Convert.ToInt32(Console.ReadLine());

            int[] array = new int[elements];

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("Give value " + (i + 1) + " to the element of the array: ");
                array[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.Write("The output of this array in reverse order: ");
            Console.WriteLine();

            for (int i = array.Length - 1; i >= 0; i--)
            {
                Console.WriteLine("The value for index " + (i + 1) + " is " + array[i]);
            }


        }
    }
}
