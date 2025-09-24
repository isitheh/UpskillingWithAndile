// See https://aka.ms/new-console-template for more information

/// <summary>
/// Base class representing a generic animal.
/// </summary>
class Animal
{
    public string Name { get; set; }
    public int Age { get; set; }

    public virtual void Speak()
    {
        Console.WriteLine($"{Name} makes a sound.");
    }

    public virtual void Intro()
    {
        Console.WriteLine($"I am {Name} and {Age} years old");
    }
}

/// <summary>
/// Derived class representing a specific type of animal: Dog.
/// </summary>
class Dog : Animal
{
    public override void Speak()
    {
        Console.WriteLine($"{Name} says: Woof!");
    }
}

