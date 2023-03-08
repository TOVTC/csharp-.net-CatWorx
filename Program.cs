// .NET is a set of libraries and tools simialr to node.js and includes the .NET CLI, .NET runtime and libraries, and the dotnet driver
// dotnet is a C# tool that allows you to install assemblies (similar to packages) and run c# apps from the command line

// C# uses top-level statements as entry points to an application (replaces Main() function)
// Console.WriteLine("Hello, World!");

// below is the expanded version of the above top-level statement
// the using directive imports a common namepsace called System (similar to require/import) which is part of the .NET framework (similar to node)
using System;
// .NET 6.0 has a default setting called "implicit usings" that automatically imports System and other directives
// (this project will still import implicit usings, though)


// dictionaries are similar to object literals and need to be imported to be used
// C# lists (not C# arrays) are more similar to JS arrays and are also imported
using System.Collections.Generic;

// namespaces are used to organize and provide levels of separation in code (similar to modules in Node.js)
// namepsaces are like containers that have members - members can be another namespace, a method, or class
namespace CatWorx.BadgeMaker
// everything below can be interpreted as members of this namespace
{
    class Program
    {
        // Main() is the entry point to an application (similar to index.html) and can be initialized with or without parameters
        // static - scope is class level, not object level (can be invoked without creating a new class instance first)
        // void - return of this executable method is of type void (nothing is returned)
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!"); // because we imported System above, we don't need to type System.Console

            // -----DATA TYPES--------------------------------------------------------------
            // STRINGS
            Console.WriteLine("\nSTRINGS");
            // C# is a statically typed language, variables are declared using a data-type keyword (as opposed to a var/let/const)
            string greeting = "Hello"; // double quotes must be used for strings in C#
            greeting = greeting + " " + "World";
            Console.WriteLine("greeting:" + " " + greeting);

            // String interpolation
            string hello = "NEW";
            Console.WriteLine($"greeting: {greeting}"); // (similar to a template literal)
            Console.WriteLine("greeting: {0}", greeting); // interpolates the variable by associating the zero index with the second argument of the function call
            Console.WriteLine("greeting: {1}", greeting, hello);

            // NUMBERS
            Console.WriteLine("\nNUMBERS");
            // float side = 3.14; - will generate an error because when we write a decimal with no suffix, its default type is "double"
            float side = 3.14F;
            float area = side * side;
            Console.WriteLine("area: {0}", area);
            Console.WriteLine("area is a {0}", area.GetType()); // the GetType() method retrieves the data type of a variable
            // this prints "System.Single" - a Single is 32-bit float and a Double is a 64-bit float

            Console.WriteLine(2 * 3);
            Console.WriteLine(10 % 3);
            Console.WriteLine(1 + 2 * 3);     // C# executes order of operations
            Console.WriteLine(10 / 3.0);      // will include decimal digits in quotient
            Console.WriteLine(10 / 3);        // will round quotient
            Console.WriteLine("12" + "3");

            int num = 10;
            num += 100;
            Console.WriteLine(num);
            num ++;
            Console.WriteLine(num);

            // BOOLEANS
            Console.WriteLine("\nBOOLEANS");
            bool isCold = true;
            Console.WriteLine(isCold ? "drink" : "add ice");
            Console.WriteLine(!isCold ? "drink" : "add ice");

            bool cold = false;
            Console.WriteLine(cold ? "drink" : "add ice");
            Console.WriteLine(!cold ? "drink" : "add ice");

            // -----DATA TYPE CONVERSIONS--------------------------------------------------------------
            // DATA TYPE CONVERSIONS
            Console.WriteLine("\nDATA TYPE CONVERSIONS");
            string stringNum = "2";
            int intNum = Convert.ToInt32(stringNum);
            Console.WriteLine(intNum);
            Console.WriteLine(intNum.GetType()); // returns "System.Int32
            // Int32 designates the storage available for the variable (32 bits or 2^32), Int16 and Int64 are other examples

            // -----DATA STRUCTURES--------------------------------------------------------------
            // DICTIONARIES
            Console.WriteLine("\nDICTIONARIES");
            // dictionaries use key-value pairs but the data types of the stored data must be explicitly stated when the dictionary is declared
            // data types for a dictionary's key value pairs are declared with angled brackets e.g. <string, double> or <int, string>
            Dictionary<string, int> myScoreBoard = new Dictionary<string, int>();
            
            // use the add() method to populate a dictionary
            myScoreBoard.Add("firstInning", 10);
            myScoreBoard.Add("secondInning", 20);
            myScoreBoard.Add("thirdInning", 30);
            myScoreBoard.Add("fourthInning", 40);
            myScoreBoard.Add("fifthInning", 50);
            
            // you can also initialize a dictionary by listing the key-value pairs in a function call
            Dictionary<string, int> mySecondScoreBoard = new Dictionary<string, int>(){
                { "firstInning", 10 },
                { "secondInning", 20},
                { "thirdInning", 30},
                { "fourthInning", 40},
                { "fifthInning", 50}
            };

            Console.WriteLine("----------------");
            Console.WriteLine("  Scoreboard");
            Console.WriteLine("----------------");
            Console.WriteLine("Inning |  Score");
            Console.WriteLine("   1   |    {0}", myScoreBoard["firstInning"]);
            Console.WriteLine("   2   |    {0}", myScoreBoard["secondInning"]);
            Console.WriteLine("   3   |    {0}", myScoreBoard["thirdInning"]);
            Console.WriteLine("   4   |    {0}", myScoreBoard["fourthInning"]);
            Console.WriteLine("   5   |    {0}", myScoreBoard["fifthInning"]);
            // the string value interpolates the value of the first value of the arguments passed into the WriteLine function, which matches the key in the dictionary
        
            // ARRAYS
            Console.WriteLine("\nARRAYS");
            // the data type of the array's elements must be declared - thus only a single data type can be contained in an array
            // the length of an array must also be declared - no elements can be added to or subtracted from an array
            string[] favFoods = new string[3]{"pizza", "doughnuts", "icecream"};
            string firstFood = favFoods[0];
            string secondFood = favFoods[1];
            string thirdFood = favFoods[2];
            Console.WriteLine("I like {0}, {1}, and {2}", firstFood, secondFood, thirdFood); // don't forget string interpolation

            // LISTS
            Console.WriteLine("\nLISTS");
            // lists are more similar to JS arrays because their lengths are not static
            
        }
    }
}
