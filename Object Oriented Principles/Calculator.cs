//2. Method Overloading
//Definition: Method overloading is defining multiple methods with the same name but different parameter lists (different type or number of parameters).

public class Calculator
{
    public int Add(int a, int b) => a + b;
    public double Add(double a, double b) => a + b;
    public int Add(int a, int b, int c) => a + b + c;
}

Calculator calc = new Calculator();
Console.WriteLine(calc.Add(2, 3));       // 5
Console.WriteLine(calc.Add(2.5, 3.5));   // 6
Console.WriteLine(calc.Add(1, 2, 3));    // 6
