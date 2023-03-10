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
    // users of a class shouldn't have to know how it operates or stores values, only the inputs and outputs, and using getters and setters on a class instance is standard practice
    class Employee{
        // PROPERTIES ----------------------------------------
        // accessModifier dataType propertyName
        private string FirstName;
        private string LastName;
        private int Id;
        private string PhotoUrl;

        // CONSTRUCTOR ----------------------------------------
        // in C#, a class's constructor method has the same name as its class and has a few specificities:
        // properties must be declared in the class before they are used in the constructor
        // the constructor method must be made public
        // to distinguish between public and private variables, use PascalCase for public and camelCase for private
        public Employee(string firstName, string lastName, int id, string photoUrl) {
            FirstName = firstName;
            LastName = lastName;
            Id = id;
            PhotoUrl = photoUrl;
        }

        // METHODS ----------------------------------------
        // accessing properties indirectly through methods allows you to:
        // process the property (e.g. validating, formatting) before returning
        // change the type of the value before returning
        // provide a stable interface to the property even if it changes internally (e.g. GetID() returns int ID, but if "the class [queries] a database to find the id based on the employee's name, which would be a string and would therefore require type conversion.")
        // return different values based on the time of day (e.g. getGreeting() returns "Good Morning" or "Good Afternoon")

        // to enhance encapsulation, instead of declaring properties as public, we create getters and setters to retrieve and update them
        
        // a method to concatenate first and last name in proper formatting
        // accessModifier dataType methodName
        public string GetFullName() {
            return FirstName + " " + LastName;
        }
        public int GetId() {
            return Id;
        }
        public string GetPhotoUrl() {
            return PhotoUrl;
        }
    }
}