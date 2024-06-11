using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace First_c_sharp_code
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, result;
            Console.WriteLine("Enter 2 numbers");
            num1 = Convert.ToInt32(Console.ReadLine());
            num2 = Convert.ToInt32(Console.ReadLine());
            result = num1 + num2;
            Console.WriteLine("Add of {0} and {1} is", num1, num2, result);
            Console.ReadLine();
        }
    }
}
