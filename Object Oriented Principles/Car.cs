//Class and Object
//Definition:
//A class is a blueprint for creating objects; it defines properties and behaviors.
//An object is an instance of a class, holding actual data. 

public class Car   // Class (blueprint)
{
    public string Brand { get; set; }
    public int Year { get; set; }

    public void Drive()
    {
        Console.WriteLine($"{Brand} is driving...");
    }
}

Car car1 = new Car { Brand = "Toyota", Year = 2020 };  // Object (instance)
Car car2 = new Car { Brand = "BMW", Year = 2022 };

car1.Drive();  // Toyota is driving...
car2.Drive();  // BMW is driving...
