// 3. Method Overriding
//Definition:Method overriding is when a subclass provides its own implementation of a method that is already defined in its parent class.

public class Animal
{
    public virtual void Speak() => Console.WriteLine("Animal makes a sound");
}

public class Dog : Animal
{
    public override void Speak() => Console.WriteLine("Dog barks");
}

Animal a = new Dog();
a.Speak();  // Dog barks

//4. Difference: Overloading vs Overriding
//Definition:

//Overloading: Same method name, different parameter lists, decided at compile time.

//Overriding: Subclass changes parent method’s behavior, decided at runtime.


