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
            //Find the smallest element of an array. The ninth homework assignment from #SimpleCode.

            Console.Write("Enter the number of array elements: ");
            int elements = Convert.ToInt32(Console.ReadLine());

            int[] array = new int[elements];

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("Give value " + (i + 1) + " to the element of the array: ");
                array[i] = Convert.ToInt32(Console.ReadLine());
            }

            int smallestElement = array[0];
            int smallestValue = array[0];

            for (int i = 0; i < array.Length; i++)
            {
                if (smallestValue >= array[i])
                {
                    smallestElement = (i + 1);
                    smallestValue = array[i];
                }
               
            }

            Console.WriteLine("The smallest element of this array is: " + smallestElement + " with the value: " + smallestValue);
          
        }
    }
}
