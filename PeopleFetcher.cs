// this file will retrieve data from an api, thus the program will never instantiate a new instance of this class
// import directives (below are implicitly/automatically imported, though)
using System;
using System.Collections.Generic;

// one way to include employee data without manually typing it is to import a CSV, which would use the StreamReader class
// this app will retrieve employee data from the Random User Generator API from the (https://randomuser.me/api/?results=10&nat=us&inc=name,id,picture) endpoint instead

// declared in the same namespace as the rest of the program, so it is accessible
namespace CatWorx.BadgeMaker{
    class PeopleFetcher
    {
        // GET EMPLOYEES METHOD ----------------------------------------
        // the GetEmployees() method will return a list of employees, no parameters required
        // Employee is a custom data type - defining a class in C# registers that class name as a custom type
        public static List<Employee> GetEmployees()
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

        // create the PeopleFetcher class containing the GetEmployees() method from Program.cs
        // create a new method called GetFromApi() in PeopleFetcher
        // make an HTTP request to the API endpoint
        // Convert JSON to C# data types
        // create a new employee for each person that we fetched from the API
    }
}