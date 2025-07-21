// See https://aka.ms/new-console-template for more information
public class Program
{
    public static void Main(string[] args)
    {
        var calculator = new Calculator();
        Console.WriteLine($"Sum of 2 and 3 is {calculator.Add(2, 3)}");
        Console.ReadLine();
    }
}

public class Calculator
{
    public int Add(int a, int b) => a + b;
}
