// import directives (below are implicitly imported, though)
using System;
using System.Collections.Generic;

// namespace data container (contains members), similar to modules in node
namespace CatWorx.BadgeMaker
{
    class Program
    {
        // Main() entry point function, initialized with or without parameters
        // static - scope is class level, not object level (can be invoked without creating a new class instance first)
        // void - return type of this executable method (nothing is returned)
        static void Main(string[] args)
        {
            // intialize a list of string values called employees that already contains two strings
            List<string> employees = new List<string>();
            // collect user values until the value is an empty string
            while (true)
            {
                Console.WriteLine("Please enter a name :");
                // get a name from the console and assign it to a variable
                string input = Console.ReadLine() ?? ""; // .NET runtime halts here and waits for input before it continues executing on the next line
                // the null coalescing operator ?? is similar to ternary
                // ?? checks whether the value from the command line is null (because input can only be of type string) and replaces it with the value after the operator (here it's an empty string)
                if (input == "")
                {
                    // break the while loop if the user hits enter without typing a name
                    break;
                }
                employees.Add(input);
            }
            for (int i = 0; i < employees.Count; i++)
            {
                Console.WriteLine(employees[i]);
            }
        }
    }
}
