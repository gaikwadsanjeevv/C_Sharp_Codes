//i-- decrements only integer value.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
 
namespace Decrement_Operator
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 5; // Initialization
            Console.WriteLine("The Value of i is {0}", i);
 
            i--; // i decremented by one. It is post-decrement
 
            Console.WriteLine("\nNow the value of i is {0}", i);
 
            Console.ReadLine();
        }
    }
}
