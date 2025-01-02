using ConsoleApp2;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the value for x:");
        double x = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter the value for y:");
        double y = Convert.ToDouble(Console.ReadLine());

        Calculator calculator = new Calculator(x, y);

        Console.WriteLine("Results:");
        Console.WriteLine($"Sum (x + y): {calculator.Add()}");
        Console.WriteLine($"Difference (x - y): {calculator.Subtract()}");
        Console.WriteLine($"Product (x * y): {calculator.Multiply()}");
        Console.WriteLine($"Quotient (x / y): {calculator.Divide()}");
    }
}