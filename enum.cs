using System;
using System.Collections.Generic;
namespace EnumsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create a collection to store list of employees
            List<Employee> empList = new List<Employee>
            {
                new Employee() { Name = "Anil", Gender = 0 },
                new Employee() { Name = "Pranaya", Gender = 1 },
                new Employee() { Name = "Priyanka", Gender = 2 },
                new Employee() { Name = "Sanju", Gender = 3 }
            };

            //Loop through Each Employees and Print the Name and Gender
            foreach (var emp in empList)
            {
                //To Print the Actual Gender of the Employee, 
                //we need to call the GetGender Method by passing the Integer Gender Value
                Console.WriteLine($"Name = {emp.Name} && Gender = {GetGender(emp.Gender)}");
            }

            Console.ReadLine();
        }

        //This Method is used to return the Actual Gender Based on the Integer Gender Value
        public static string GetGender(int gender)
        {
            // The switch case here is less readable because of these integral numbers
            switch (gender)
            {
                case 0:
                    return "Unknown";
                case 1:
                    return "Male";
                case 2:
                    return "Female";
                default:
                    return "Invalid Data for Gender";
            }
        }
    }
    
    public class Employee
    {
        public string Name { get; set; }

        // 0 - Unknown
        // 1 - Male
        // 2 - Female
        public int Gender { get; set; }
    }
}
