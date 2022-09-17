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
            PrintEmployees(employees);
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

        static void PrintEmployees(List<Employee> employees)
        {
            for (int i = 0; i < employees.Count; i++)
            {
                // We want the first argument(argument { 0}), the id, to be left-aligned and padded to at least 10 characters, so we enter { 0,-10}. 
                // Then we want to print a tab character(\t). 
                // We want the next argument({ 1}), the name, to be left-aligned and padded to 20 characters—hence { 1,-20}.
                // Next, we want to print another tab character(\t).
                // And finally, we want to print the last argument({ 2}), the photo URL, with no formatting: {2}.
                string template = "{0,-10}\t{1,-20}\t{2}";
                Console.WriteLine(String.Format(template, employees[i].GetId(), employees[i].GetFullName(), employees[i].GetPhotoUrl()));
            }
        }

    }

}