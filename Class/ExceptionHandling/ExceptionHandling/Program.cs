namespace ExceptionHandling;
class Program
{
    public static void Main(string[] args)
    {
        int x, y, z;
        try
        {
            Console.WriteLine("Enter first number");
            x = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Enter first number"); 
            y = Convert.ToInt16(Console.ReadLine());
            if (x > y)
            {
                throw new ExceptionDemo("Second number cannot be smaller than first number"); // this is a custom Exception
            }; 
            z = x / y;
            Console.WriteLine($"The result is {z}");
        }
        catch (FormatException)
        {
            Console.WriteLine("Please enter a valid number");
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("Cannot divide by zero");
        }
        catch (ExceptionDemo ex) // jump to here from exception thrown above
        {
            Console.WriteLine(ex.Message); // Message property has been pre-defined in the base class Exception, so derived class ExceptionDemo can get and set and access this Property 
        }
        catch (Exception ex) // you must always declare a param in the catch statement. if you're unsure which to use, start with the base class Exception. Use specific Exceptions when possible.
        {
            Console.WriteLine($"Error occured: {ex}"); // this is the error statement you want to print
        }
        finally // this is the wrap up code and is optional, will always execute regardless of whether an exception occurs
        {
            Console.WriteLine("End of program");
        }
    }
}