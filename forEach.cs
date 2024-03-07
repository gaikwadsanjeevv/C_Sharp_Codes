//for each : It uses collection to take value one by one and then processes them.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
 
namespace foreach_loop
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr = new string[5]; // declaring array
 
            //Storing value in array element
            arr[0] = "Sanjeev";
            arr[1] = "Gaikwad";
            arr[2] = "Raju";
            arr[3] = "Parker";
            arr[4] = "Sarah";
 
            //retrieving value using foreach loop
            foreach (string name in arr)
            {
                Console.WriteLine("Hello " + name);
            }
            Console.ReadLine();
        }
    }
}
