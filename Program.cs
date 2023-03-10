// import directives (below are implicitly imported, though)
using System;
using System.Collections.Generic;

// namespace data container (contains members), similar to modules in node
namespace CatWorx.BadgeMaker
{
    class Program
    {
        // in C#, a method declaration or signature looks like this (the []'d' sections are optional):
        // [access_modifier] ["static"] return_type name([parameters])
        // if a static method wants to call another method inside the same class directly, that method mst also be static
        // because Main() is static, any other method it needs to call within the program must also be static

        // the GetEmployees() method will return a list of employees, no parameters required
        static List<string> GetEmployees()
        {
            // intialize a list of string values called employees that already contains two strings
            List<string> employees = new List<string>();
            // collect user values until the value is an empty string
            while (true)
            {
                Console.WriteLine("Please enter a name : (leave empty to exit)");
                // get a name from the console and assign it to a variable
                string input = Console.ReadLine() ?? ""; // .NET runtime halts here and waits for input before it continues executing on the next line
                // the null coalescing operator ?? is similar to ternary
                // ?? checks whether the value from the command line is null (because input can only be of type string) and replaces it with the value after the operator (here it's an empty string)
                if (input == "")
                {
                    // break the while loop if the user hits enter without typing a name
                    break;
                }
                // Create a new Employee instance - we don't need to import the Employee class because of the namespace scope
                // defining a class in C# registers that class name as a custom type
                // dataType variableName = value;
                Employee currentEmployee = new Employee();
                employees.Add(input);
            }
            // don't forget to return the generated list
            return employees;
        }

        // the employees argument of type List is passed in when the method is called
        static void PrintEmployees(List<string> employees)
        {
            for (int i = 0; i < employees.Count; i++)
            {
                Console.WriteLine(employees[i]);
            }
        }

        // Main() entry point function, initialized with or without parameters
        // static - scope is class level, not object level (can be invoked without creating a new class instance first)
        // void - return type of this executable method (nothing is returned)
        static void Main(string[] args)
        {
            // we call our GetEmployees method and then call our PrintEmployees method, passing in the returned employee list
            List<string> employees = GetEmployees();
            PrintEmployees(employees);
        }
    }
}
