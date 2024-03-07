/*printing output as follow:
1

12

123

1234

12345
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
 
namespace nested_loop
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j;
            for (i = 1; i <= 5; i++)
            {
                for (j = 1; j <= i; j++) //Nested for loop
                {
                    Console.Write(j);
                }
                Console.Write("\n");
            }
            Console.ReadLine();
        }
    }
}
