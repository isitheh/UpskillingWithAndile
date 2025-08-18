//8. Composition
//Definition:Composition is a design principle where a class is built using objects of other classes (a “has-a” relationship)

public class Engine
{
    public void Start() => Console.WriteLine("Engine starting...");
}

public class CarWithEngine
{
    private Engine engine = new Engine(); // Composition

    public void StartCar()
    {
        engine.Start();
        Console.WriteLine("Car is running");
    }
}

CarWithEngine car = new CarWithEngine();
car.StartCar();

//9. Difference: Composition vs Inheritance
//Definition:

//Inheritance: Defines an “is-a” relationship (Dog is an Animal).
//Composition: Defines a “has-a” relationship (Car has an Engine).