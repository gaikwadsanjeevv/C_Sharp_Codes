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
            string name;

          
            Console.WriteLine("Please Enter Your Good Name");

          
            name = Console.ReadLine();

          
            Console.WriteLine("Welcome {0} in your first csharp program", name);

            Console.ReadLine();
        }
    }
}
