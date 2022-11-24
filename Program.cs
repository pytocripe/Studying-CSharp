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
            // The arithmetic mean of two numbers. The first homework assignment from #SimpleCode


            Console.WriteLine("Write the first number: ");
            int FirstNumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Write the second number: ");
            int SecondNumber = Convert.ToInt32(Console.ReadLine());

            int ArithmeticMean = (FirstNumber + SecondNumber) / 2;

            Console.WriteLine("The arithmetic mean of two numbers " + FirstNumber + " and " + SecondNumber + " equals " + ArithmeticMean);
        }
    }
}
