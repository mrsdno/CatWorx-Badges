// importing system Namespace (part of .NET framework)
using System;
using System.Collections.Generic;

// Namespaces are used to organize and provide a level of separation in the code.
namespace CatWorx.BadgeMaker
{
    class Program
    {
        static void Main(string[] args)
        {
            // This is our employee-getting code now 
            List<Employee> employees = GetEmployees();
           Util.PrintEmployees(employees);
            Util.MakeCSV(employees);
        }
        static List<Employee> GetEmployees()
        {
            // I will return a List of strings
            List<Employee> employees = new List<Employee>();

            while (true)
            {
                Console.WriteLine("Please enter a name: (leave empty to exit)");
                string firstName = Console.ReadLine() ?? "";
                if (firstName == "")
                {
                    break;
                }

                Console.WriteLine("Enter last name: ");
                string lastName = Console.ReadLine() ?? "";

                Console.WriteLine("Enter ID: ");
                int id = Int32.Parse(Console.ReadLine() ?? "");

                Console.WriteLine("Enter Photo URL: ");
                string photoUrl = Console.ReadLine() ?? "";

                Employee currentEmployee = new Employee(firstName, lastName, id, photoUrl);
                employees.Add(currentEmployee);

            }
            return employees;
        }



    }

}