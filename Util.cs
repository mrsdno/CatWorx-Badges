using System;
using System.Collections.Generic;

namespace CatWorx.BadgeMaker
{
    class Util
    {
        // We defined the preceding PrintEmployees() method as static, meaning that it belongs to the class itself instead of individual instances or objects. 
        //In other words, we don’t have to create a new Util object to use it. 
        // We can access this method directly from the class name, as follows: Util.PrintEmployees();
        public static void PrintEmployees(List<Employee> employees)
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
