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
            //Program for manually filling an array. The sixth homework assignment from #SimpleCode.

            Console.Write("Enter the number of array elements: ");
            int elements = Convert.ToInt32(Console.ReadLine());

            int[] array = new int[elements];

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("Give value " + (i + 1) + " to the element of the array: ");
                array[i] = Convert.ToInt32(Console.ReadLine());
            }

        }
    }
}
