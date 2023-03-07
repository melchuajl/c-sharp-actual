class Calculator
{
    public void Sum(int num1, int num2)
    {
        Console.WriteLine(num1 + num2);
    }
    public static void Subtract(int num1, int num2)
    {
        Console.WriteLine(num1 - num2);
    }
}
class Program
{
    public static void Main()
    {
        Calculator.Subtract(2, 4); // this works because Subtract is static

        Calculator calc = new Calculator();
        calc.Sum(10, 11); // this requires an instance because Sum is not static
    } 
}

