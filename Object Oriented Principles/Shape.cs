//10. Abstraction
//Definition:Abstraction is hiding implementation details and exposing only the essential features, often achieved using abstract classes or interfaces.
public abstract class Shape
{
    public abstract double GetArea();  // abstract method
}

public class Circle : Shape
{
    public double Radius { get; set; }
    public Circle(double r) => Radius = r;

    public override double GetArea() => Math.PI * Radius * Radius;
}

Shape s = new Circle(5);
Console.WriteLine(s.GetArea());  // 78.54
