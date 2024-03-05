using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
 
namespace Or_operator
{
    class Program
    {
        static void Main(string[] args)
        {
            string username, userpassword;
 
        label: //Creating label
 
            Console.Write("\n\nEnter your login name:\t");
            username = Console.ReadLine();
 
            Console.Write("Enter your password:\t");
            userpassword = Console.ReadLine();
 
            try
            {
                if ((username == "Sanjeev" || username == "Reetika") && (userpassword == "123enter"))
                {
                    Console.WriteLine("\nLogin Successful.");
                }
                else
                {
                    Console.WriteLine("\nUnauthorised Access. Aborting...");
                }
 
                Console.Write("\n\nPress Y or y for continue. Press N or n for Exit:\t");
                char ans = Convert.ToChar(Console.ReadLine());
                if (ans == 'Y' || ans == 'y')
                {
                    goto label; //goto label
 
                }
                else
                {
                    Console.WriteLine("Press  Enter for Aborting...");
                    Console.ReadLine();
                    return;
                }
            }
            catch { }
            
        }
    }
}
