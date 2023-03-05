﻿// C# uses top-level statements as entry points to an application (replaces Main() function)
// Console.WriteLine("Hello, World!");

// below is the expanded version of the above top-level statement
// the using directive imports a common namepsace called System (similar to require/import) which is part of the .NET framework (similar to node)
using System;
// .NET 6.0 has a default setting called "implicit usings" that automatically imports System and other directives
// (this project will still import implicit usings, though)

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

            // STRINGS
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
            
        }
    }
}
