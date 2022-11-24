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
            //A simple calculator for two number. The third homework assignment from #SimpleCode.

            while (true)
            {
                double FirstNumber = 0;
                double SecondNumber = 0;

                try
                {
                    Console.Write("Write first number: ");
                     FirstNumber = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Write second number: ");
                    SecondNumber = Convert.ToDouble(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("Is not a number");
                    continue;
                }

                Console.Write("Select action: '+' '-' '*' '/': ");
                string action = Console.ReadLine();

                switch (action)
                {
                    case "+":
                        Console.WriteLine("The sum of the number " + FirstNumber + " and " + SecondNumber + " is " + (FirstNumber + SecondNumber));
                        break;
                    case "-":
                        Console.WriteLine("The difference of the number " + FirstNumber + " and " + SecondNumber + " is " + (FirstNumber - SecondNumber));
                        break;
                    case "/":
                        if (SecondNumber == 0)
                        {
                            Console.WriteLine("You can't divide by zero.");
                            Console.ReadKey();
                            Console.Clear();
                            continue;
                        }
                      Console.WriteLine("The divide of the number " + FirstNumber + " by " + SecondNumber + " is " + (FirstNumber / SecondNumber));
                        break;

                    case "*":
                     Console.WriteLine("The multiply of the number " + FirstNumber + " by " + SecondNumber + " is " + (FirstNumber * SecondNumber));
                        break;
                    default:
                        Console.WriteLine("It is not an arithmetic action");
                        break;

                }

                Console.ReadKey();
                Console.Clear();



            }
            



        }
    }
}
