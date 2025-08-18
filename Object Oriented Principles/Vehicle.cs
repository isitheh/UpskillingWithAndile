//6. Inheritance
//Definition:Inheritance is when one class (child) acquires the properties and methods of another class (parent).
public class Vehicle
{
    public void Move() => Console.WriteLine("Vehicle is moving...");
}

public class Bike : Vehicle
{
    public void RingBell() => Console.WriteLine("Bike bell rings!");
}

Bike b = new Bike();
b.Move();      // from Vehicle
b.RingBell();  // from Bike
