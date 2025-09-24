using OOP;

// Entry point for the application
Console.WriteLine("Welcome to the C# OOP Demonstration Console App!");

OOPDefinitions definitions = new OOPDefinitions();

Console.WriteLine("\n==============================");
Console.WriteLine(" Demonstrating Classes and Objects");
Console.WriteLine("==============================");
definitions.DemonstrateClassAndObject();

Console.WriteLine("\n==============================");
Console.WriteLine(" Demonstrating Inheritance");
Console.WriteLine("==============================");
definitions.DemonstrateInheritance();

Console.WriteLine("\n==============================");
Console.WriteLine(" Demonstrating Encapsulation");
Console.WriteLine("==============================");
definitions.DemonstrateEncapsulation();

Console.WriteLine("\n==============================");
Console.WriteLine(" Demonstrating Overloading");
Console.WriteLine("==============================");
// definitions.DemonstrateOverloading(); // Uncomment when implemented

Console.WriteLine("\n==============================");
Console.WriteLine(" Demonstrating Overriding");
Console.WriteLine("==============================");
// definitions.DemonstrateOverriding(); // Uncomment when implemented

Console.WriteLine("\n==============================");
Console.WriteLine(" Demonstrating Static Class");
Console.WriteLine("==============================");
// definitions.DemonstrateStaticClass(); // Uncomment when implemented

Console.WriteLine("\n==============================");
Console.WriteLine(" Demonstrating Polymorphism");
Console.WriteLine("==============================");
// definitions.DemonstratePolymorphism(); // Uncomment when implemented

Console.WriteLine("\n End of OOP Demonstration");
