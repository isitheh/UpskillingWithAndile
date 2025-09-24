// See https://aka.ms/new-console-template for more information

/// <summary>
/// Represents a person with basic identity properties and an introduction method.
/// </summary>
public class Person
{
    public string Name { get; set; }
    public string Surname { get; set; }
    public int Age { get; set; }

    public void Introduce()
    {
        Console.WriteLine($"Hello, my name is {Name} {Surname} and I am {Age} years old.");
    }
}
