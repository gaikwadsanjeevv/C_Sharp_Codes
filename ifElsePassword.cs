using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
 
namespace and_operator
{
    class Program
    {
        static void Main(string[] args)
        {
            string name, password;
 
            name = "sanjeev";
            password = "gaikwad";

            if (name == "sanjeev" && password == "gaikwad")
            {
                Console.WriteLine("Login Successful");
            }
            else
            {
                Console.WriteLine("Unauthorised access");
            }
            Console.ReadLine();
        }
    }
}
