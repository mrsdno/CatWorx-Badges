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
            List<string> employees = GetEmployees();
            PrintEmployees(employees);
        }
        static List<string> GetEmployees()
        {
            // I will return a List of strings
            List<string> employees = new List<string>();
            bool more = true;
            while (more)
            {
                Console.WriteLine("Please enter a name: (leave empty to exit)");
                string input = Console.ReadLine() ?? "";
                if (input == "")
                {
                    more = false;
                }
                employees.Add(input);
            }
            return employees;
        }

        static void PrintEmployees(List<string> employees)
        {
            for (int i = 0; i < employees.Count; i++)
            {
                Console.WriteLine(employees[i]);
            }
        }

    }

}