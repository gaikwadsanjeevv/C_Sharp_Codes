//Multiplication table for 15
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
 
namespace do_while
{
    class Program
    {
        static void Main(string[] args)
        {
            int table, i, res;
            table = 12;
            i = 1;
            do
            {
                res = table * i;
                Console.WriteLine("{0} x {1} = {2}", table, i, res);
                i++;
            }
            // must put semi-colon(;) at the end of while condition in do...while loop.
            while (i <= 10);
 
            Console.ReadLine();
        }
    }
}
