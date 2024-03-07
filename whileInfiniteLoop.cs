//Sometime, you don’t know the starting position of loop but want to execute some code in while loop. 
//Or, you might want to run infinite loop that will be terminate with special character. In this situation, you can use while(true) as infinite loop.




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
 
namespace while_true
{
    class Program
    {
        static void Main(string[] args)
        {
            int num, sum = 0, res = 0;
            Console.WriteLine("Enter number to add. Press x for Terminate the program");
            while (true)
            {
                num = Convert.ToInt32(Console.ReadLine());
                if (num == -1)
                {
                    break;
                }
                sum = res;
                res += num;
                Console.WriteLine("\n{0} + {1} = {2}", sum, num, res);
            }
            Console.WriteLine("\n\nAborting... Press Enter.");
            Console.ReadLine();
        }
    }
}
