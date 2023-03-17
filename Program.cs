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
        /*    class Example
            {
              // Example.StaticMethod();
              public static void StaticMethod()
              {
                Console.WriteLine("Bananas");
              }
            
              // Example thing = new Example();
              // thing.InstanceMethod();
              public void InstanceMethod()
              {
                Console.WriteLine("Oranges");
              }
            }
        */
        // MAIN METHOD ----------------------------------------
        // Main() entry point function, initialized with or without parameters
        // static - scope is class level, not object level (can be invoked without creating a new class instance first)
        // void - return type of this executable method (nothing is returned)
        // basic formatting of Main(): static void Main(string[] args)
        // Main() method was updated to include async and Task to allow for asynchronous method in GetBadges() in Util
        // the return type for an async method with no return value is Task as opposed to void
        async static Task Main(string[] args)
        {
            // we call our GetEmployees method and then call our PrintEmployees method, passing in the returned employee list
            // List<Employee> employees = PeopleFetcher.GetEmployees();
            List<Employee> employees = await PeopleFetcher.GetFromApi();
            // call the public static methods available in Util.cs
            Util.PrintEmployees(employees);
            Util.MakeCSV(employees);
            await Util.MakeBadges(employees);
        }
    }
}
