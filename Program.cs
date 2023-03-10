// import directives (below are implicitly/automatically imported, though)
using System;
using System.Collections.Generic;

// namespace data container (contains members), similar to modules in node
namespace CatWorx.BadgeMaker
{
    class Program
    {
        // in C#, a method declaration or signature looks like this (the []'d' sections are optional):
        // [access_modifier] ["static"] return_type name([parameters])

        // STATIC METHODS ----------------------------------------
        // if a static method wants to call another method inside the same class directly, that method must also be static
        // because Main() is static, any other method it needs to call within the program must also be static
        // static methods belong to the class itself, instead of individual instances or objects of that class
        // therefore, the object does not need to be instantiated before it can be used (as opposed to instance methods)
        // it is possible for apps to have both static methods and instance methods
            //class Example
            // {
            //   // Example.StaticMethod();
            //   public static void StaticMethod()
            //   {
            //     Console.WriteLine("Bananas");
            //   }
            
            //   // Example thing = new Example();
            //   // thing.InstanceMethod();
            //   public void InstanceMethod()
            //   {
            //     Console.WriteLine("Oranges");
            //   }
            // }

        // GET EMPLOYEES METHOD ----------------------------------------
        // the GetEmployees() method will return a list of employees, no parameters required
        // Employee is a custom data type - defining a class in C# registers that class name as a custom type
        static List<Employee> GetEmployees()
        {
            // intialize a list of Employee class instances called employees
            // we do not need to import Employee because of the namespace scope declaration
            List<Employee> employees = new List<Employee>();

            // collect user values until the value is an empty string
            while (true)
            {
                Console.WriteLine("Enter first name : (leave empty to exit)");
                // get a name from the console and assign it to a variable
                string firstName = Console.ReadLine() ?? ""; // .NET runtime halts here and waits for input before it continues executing on the next line
                // the null coalescing operator ?? is similar to ternary
                // ?? checks whether the value from the command line is null (because input can only be of type string) and replaces it with the value after the operator (here it's an empty string)
                if (firstName == "")
                {
                    // break the while loop if the user hits enter without typing a name
                    break;
                }
                
                // if first name is blank, the remaining Console.WriteLine code will not execute
                Console.Write("Enter last name: ");
                string lastName = Console.ReadLine() ?? "";
                Console.Write("Enter ID: ");
                // Console.ReadLine() only returns string values, so we cast it to an integer before storing
                int id = Int32.Parse(Console.ReadLine() ?? "");
                Console.Write("Enter Photo URL: ");
                string photoUrl = Console.ReadLine() ?? "";

                // Create a new Employee instance
                Employee currentEmployee = new Employee(firstName, lastName, id, photoUrl);
                employees.Add(currentEmployee);
            }
            // don't forget to return the generated list
            return employees;
        }

        // MAIN METHOD ----------------------------------------
        // Main() entry point function, initialized with or without parameters
        // static - scope is class level, not object level (can be invoked without creating a new class instance first)
        // void - return type of this executable method (nothing is returned)
        static void Main(string[] args)
        {
            // we call our GetEmployees method and then call our PrintEmployees method, passing in the returned employee list
            List<Employee> employees = GetEmployees();
            // call the public static methods available in Util.cs
            Util.PrintEmployees(employees);
            Util.MakeCSV(employees);
        }
    }
}
