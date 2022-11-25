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
            //Sum and number of even and odd numbers in the range specified by the user. The fourth homework assignment from #SimpleCode.
            int BeginningRange = 0;
            int EndRange = 0;
            int EvennumberСounter = 0;
            int OddnumberCounter = 0;
            int SumEvenNumber = 0;
            int SumOddNumber = 0;

            try
            {
                Console.Write("Write the beginning of the range: ");
                BeginningRange = Convert.ToInt32(Console.ReadLine());
                Console.Write("Write the end of the range: ");
                 EndRange = Convert.ToInt32(Console.ReadLine());

            }
            catch (Exception)
            {

                Console.WriteLine("Is not a number");
                return;
            }

            while (BeginningRange <= EndRange)
            {
                if (BeginningRange % 2 == 0)
                {
                    EvennumberСounter++;
                    SumEvenNumber = SumEvenNumber + BeginningRange;
                }
                else
                {
                    OddnumberCounter++;
                    SumOddNumber = SumOddNumber + BeginningRange;
                }

                BeginningRange++;

            }

            Console.Write("The number of even numbers in this range is: " + EvennumberСounter);
            Console.WriteLine();
            Console.WriteLine("The number of odd numbers in this range is: " + OddnumberCounter);
            Console.WriteLine("Sum of even numbers in this range is: " + SumEvenNumber);
            Console.WriteLine("Sum of odd numbers in this range is: " + SumOddNumber);

        }
    }
}
