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
            List<string> employees = new List<string>();
            // collect user values until the value is an empty string
            while (true)
            {
                Console.WriteLine("Please enter a name: (leave empty to exit)");
                //get name from the console and assign to a variable
                string input = Console.ReadLine() ?? "";
                if (input == "") {
                    break;
                }
                employees.Add(input);
                for (int i = 0; i < employees.Count; i++)
                {
                    Console.WriteLine(employees[i]);
                }
            }
        }
    }
}