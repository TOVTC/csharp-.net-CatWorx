// this file will write employee data to a .CSV file, thus the program will never instantiate a new instance of this class
// import directives (below are implicitly/automatically imported, though)
using System;
using System.IO; // import the System.IO namespace for the Directory and StreamWriter classes
using System.Collections.Generic;

// declared in the same namespace as the rest of the program, so it is accessible
namespace CatWorx.BadgeMaker
{
    // this class will be a collection of general methods that can be used repeatedly
    class Util
    {
        // public - access modifier indicates this method is available across the application
        // static - the method belongs to the class itself, not the individual instances or objects (don't need to create a new Util object to use it)
        // can access this method using Util.PrintEmployees();
        
        // PRINT EMPLOYEES METHOD ----------------------------------------
        // the employees argument of type List is passed in when the method is called
        public static void PrintEmployees(List<Employee> employees)
        {
            for (int i = 0; i < employees.Count; i++)
            {
                // {0,-10} - we want the first argument {0} to be the id, left-aligned and padded to at least 10 characters {-10}
                // {\t} - print a tab character
                // {1,-20} - the next argument {1} is the name, left aligned and padded to 20 characters {-20}
                // {\t} - print another tab
                // {2} - print the last argument with no formatting
                string template = "{0,-10}\t{1,-20}\t{2}";
                // String.Format() takes a string to use as a template and operates like a template literal to fill in values
                // in C#, each placeholder can define how its value is formatted and the values that follow the template in the list of arguments
                Console.WriteLine(String.Format(template, employees[i].GetId(), employees[i].GetFullName(), employees[i].GetPhotoUrl()));
            }
        }

        // MAKE CSV METHOD ----------------------------------------
        // outputs the employee list to a new .CSV file in a directory called "data"
        // the Directory and StreamWriter classes fall under the System.IO namespace (implicitly/automatically imported above)
        public static void MakeCSV(List<Employee> employees)
        {
            // check if "data" directory exists
            if(!Directory.Exists("data"))
            {
                // if the directory does not exist, create a new directory
                Directory.CreateDirectory("data");
            }
            // create a new csv file using the StreamWriter class
            // using - keyword disposes of the StreamWriter object once the file is written (instead of taking up storage in memory after it's instantiated)
            // using is the keyword both to import namespaces (above) and to temporarily use a resource (here)
            // when using a resource temporarily, whatever is defined in the parentheses is only available within the subsequent set of curly braces
            // once that block of code is run, the resource is removed (here, StreamWriter)
            using (StreamWriter file = new StreamWriter("data/employees.csv"))
            {
                file.WriteLine("ID,Name,PhotoUrl");
            }
        }
        // loop over given employees
        // write each employee's info as a comma-separated string to the CSV file
    }
}