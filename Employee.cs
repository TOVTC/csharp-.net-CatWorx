// to store first name, last name, id number, and photo, we need to accommodate for the different data types of each property
// dictionaries can only hold one data type, and we could theoretically transform all our values to strings for storage using "casting"
// but it's difficult to anticipate all the cases for dealing with these properties, so we choose to create a class
// C# permits defining multiple classes in the same file, but we modularize our code to keep it organized

// wrapping our class in the namespace scope declaration allows us to access it directly from any class that uses CatWorx.BadgeMaker
namespace CatWorx.BadgeMaker
{
    // PROTECTION LEVELS + ACCESS MODIFIERS
    // properties can be accessed using dot notation, given the correct protection level
    // by default, the protection level of properties and methods in a class is private, so they can only be accessed within the class itself
    // there are many different access modifiers, but this app will use public and private
    // in JS, there are no access modifiers, but the convention of underscore declarations such as "__sum", "__currentIndex()" simulates private variables
    // the underscores signal to other developers not to reference the variable anywhere else
    // in C#, access levels are a first-class language feature, and property access is part of the "encapsulation" principle of OOP software design
    class Employee{
        // accessModifier dataType propertyName
        public string FirstName;
        public string LastName;
        public int Id;
        public string PhotoUrl;
        // in C#, a class's constructor method has the same name as its class and has a few specificities:
        // properties must be declared in the class before they are used in the constructor
        // the constructor method must be made public
        // to distinguish between public and private variables, use PascalCase for public and camelCase for private
        public Employee(string firstName, string lastName) {
            FirstName = firstName;
            LastName = lastName;
        }

        // a getter to concatenate first and last name in proper formatting
        // accessModifier dataType methodName
        public string GetFullName() {
            return FirstName + " " + LastName;
        }
    }
}