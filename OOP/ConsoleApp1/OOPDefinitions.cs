namespace OOP
{
    internal class OOPDefinitions
    {
        /*
         * Demonstrating Classes and Objects in C#
         * 
         * What is a Class?
         * A class is a blueprint or template for creating objects. It defines the structure and behavior
         * that the objects created from it will have. In C#, a class can contain properties (data) and methods (functions).
         *
         * What is an Object?
         * An object is an instance of a class. It represents a specific entity with actual values assigned
         * to the properties defined in the class. Objects can call methods defined in their class to perform actions.
         * 
         * This example defines a class named `Person` with properties:
         * - Name
         * - Surname
         * - Age
         *
         * The class also includes a method `Introduce()` to demonstrate encapsulation—behavior that belongs to the object.
         *
         * Below, we create an instance of the `Person` class (an object named `person`)
         * and call its `Introduce()` method to display the person's details.
         */
        public void DemonstrateClassAndObject()
        {
            Person person = new Person
            {
                Name = "John",
                Surname = "Doe",
                Age = 30
            };

            person.Introduce(); // Outputs: Hello, my name is John Doe and I am 30 years old.
        }

        /*
         * Demonstrating Inheritance in C#
         * 
         * What is Inheritance?
         * Inheritance is an object-oriented programming principle that allows one class (called a child or derived class) 
         * to inherit properties and behaviors (methods) from another class (called a parent or base class).
         * This promotes code reuse, extensibility, and logical hierarchy in your application design.
         * 
         * Benefits of Inheritance
         * - Code Reusability: Common functionality can be written once in a base class and reused by derived classes.
         * - Extensibility: You can extend base classes with additional features in derived classes.
         * - Maintainability: Changes to shared behavior only need to be made in one place.
         * - Polymorphism: Derived classes can override base class methods to provide specialized behavior.
         * 
         */
        public void DemonstrateInheritance()
        {
            // Create an instance of a general Animal
            Animal animal = new Animal
            {
                Name = "Generic Animal",
                Age = 3
            };
            animal.Intro(); // Outputs: I am Generic Animal and 3 years old
            animal.Speak(); // Outputs: Generic Animal makes a sound.

            // Create an instance of Dog, which inherits from Animal
            Dog dog = new Dog
            {
                Name = "Snoop",
                Age = 5
            };

            dog.Intro();    // Outputs: I am Generic Animal and 3 years old
            dog.Speak();    // Outputs: Snoop says: Woof!
        }

        /*
         * Demonstrating Encapsulation in C#
         * 
         * What is Encapsulation?
         * Encapsulation is the object-oriented programming principle of bundling data (fields/properties)
         * and the methods that operate on that data into a single unit (a class), while restricting direct access
         * to some of the object's internal components.
         * 
         * This helps protect the internal state of an object and ensures that it can only be modified
         * through controlled and predictable interfaces (e.g., public methods).
         * 
         * Benefits of Encapsulation:
         * - Protects internal state from unintended changes
         * - Promotes maintainability and flexibility
         * - Enables validation and logic during data access
         * 
         * This Example:
         * - Defines a class `BankAccount` with a private field `balance`
         * - Provides public methods `Deposit()` and `GetBalance()` to interact with the balance safely
         * - Demonstrates how encapsulation prevents direct access to sensitive data
         */
        public void DemonstrateEncapsulation()
        {
            BankAccount account = new BankAccount();

            account.Deposit(100); // Valid deposit
            account.Deposit(-50); // Invalid deposit, ignored

            Console.WriteLine($"Current balance: {account.GetBalance()}"); // Outputs: Current balance: 100
        }
    }
}
