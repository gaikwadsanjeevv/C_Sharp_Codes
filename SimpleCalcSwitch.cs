using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace switch_case
{
    class Program
    {
        static void Main(string[] args)
        {
            
            double num1, num2, result;
            int opt;

        label:

            Console.WriteLine("\n\tMenu");
            Console.WriteLine("\nPress 1 for add");
            Console.WriteLine("Press 2 for subtraction");
            Console.WriteLine("Press 3 for multiplication");
            Console.WriteLine("Press 4 for Division");

            Console.Write("\nEnter your option:\t");
            opt = Convert.ToInt32(Console.ReadLine());

            Console.Write("\n\nEnter first number:\t");
            num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter second number:\t");
            num2 = Convert.ToDouble(Console.ReadLine());

          
            switch (opt)
            {
                case 1:
                    result = num1 + num2;
                    Console.WriteLine("\n{0} + {1} = {2}", num1, num2, result);
                    break;

                case 2:
                    result = num1 - num2;
                    Console.WriteLine("\n{0} - {1} = {2}", num1, num2, result);
                    break;
                case 3:
                    result = num1 * num2;
                    Console.WriteLine("\n{0} * {1} = {2}", num1, num2, result);
                    break;
                case 4:
                    result = (float)num1 / num2;
                    Console.WriteLine("\n{0} / {1} = {2}", num1, num2, result);
                    break;
                default:
                    Console.WriteLine("\nInvalid option. Please try again.");
                    goto label;
            }
            Console.ReadLine();
        }
    }
}
