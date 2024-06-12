using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace even_number
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            Console.Write("Enter your number:\t");
            num = Convert.ToInt32(Console.ReadLine());

            if (num % 2 == 0)
            {
                Console.WriteLine("{0} is Even Number", num);
            }
            else
            {
                Console.WriteLine("{0} is Odd number", num);
            }
            Console.ReadLine();
        }
    }
}
