//class Demo
//{
//    private int num; // access specifier private means that this variable can only be used within an instance of Demo (data hiding part of Encapsulation)
//    public Demo() // remember that constructor name must be the same as the class name
//    {
//        Console.WriteLine("I am a constructor"); 
//    }
//    public Demo(int x) // remember that constructor name must be the same as the class name
//    {
//        num = x; 
//        Console.WriteLine("I am another constructor");
//    }
//    public void SayHello()
//    {
//        Console.WriteLine($"Welcome to C# and here is a number: {num}");
//    } 
//}

//class Program
//{
//    public static void Main(string[] args)
//    {
//        Demo obj1 = new Demo(); // the brackets are what's calling the default/written constructor 
//        Demo obj2 = new Demo(500);
//        obj1.SayHello();
//        obj2.SayHello();
//    }
//}

//class Demo
//{
//    public static int x;

//    public void Increment()
//    {
//        x++;
//        Console.WriteLine(x);
//    }
//}

//class Program
//{
//    public static void Main(string[] args)
//    {
//        Demo obj1 = new Demo();
//        Demo obj2 = new Demo();
//        Demo obj3 = new Demo();
//        obj1.Increment();
//        obj2.Increment();
//        obj3.Increment();
//    }
//}

//class Demo
//{
//    private int num = 10;
//    public int Id { get; } = 1; // this is an auto-initialiser property introduced in C# 11, does not require any explicit declaration of a private variable - the property automatically generates one
//    public string Name { get; set; } = "Mary";
//    public string Phone { get; set; } = "62807751";
//    public int Age // this is the old school way of writing it 
//    {
//        get
//        {
//            return num;
//        }
//        set
//        {
//            num = value;
//        }
//    }
//}

//class Program
//{
//    public static void Main()
//    {
//        Demo obj = new Demo();
//        obj.Age = 40;

//    }
//}

//class Calculator 
//{
//    public void Sum(int a, int b)
//    {
//        Console.WriteLine(a + b);
//    }

//    public void Subtract(int a, int b)
//    {
//        Console.WriteLine(a - b);
//    }
//}

//class ScientificCalculator: Calculator
//{
//    public void Cube(int a)
//    {
//        Console.WriteLine(a * a * a);
//    }

//    public void Factorial(int a)
//    {
//        int fact = 1;
//        for (int i = 1; i <= a; i++)
//        {
//            fact *= i;
//        };
//        Console.WriteLine(fact);
//    }
//}

//class Program
//{
//    public static void Main(string[] args)
//    {
//        ScientificCalculator scicalc = new ScientificCalculator();
//        scicalc.Sum(5, 10); // you can call this in the instance even though .Sum() is not part of the Scientific Calculator class, because of Inheritance
//    }
//}

abstract class Class1 // use this to define the must-have, essential features of your program
{
    public Class1()
    {
        Console.WriteLine("I am a BaseClass constructor");
    }
    public abstract void Sum(int x, int y);
    public abstract void Multiply(int x, int y);
    public void Subtract(int x, int y)
    {
        Console.WriteLine(x - y);
    }

    int x;
    // in cases of abstract Methods, you MUST put the ; at the end because it cannot have a body, only a head with essential details
    // use abstract Methods when you want to ensure that child classes always contain these Methods

}

class Calculator : Class1 // Calculator MUST include abstract Methods Sum and Multiply from parent class Class1
{
    
    public Calculator()
    {
        Console.WriteLine("I am a Calculator constructor");
    }
    public override void Sum(int x, int y) // override is the process of overwriting the Method of a Base class in the Derived class
    {
        Console.WriteLine(x + y);
    }

    public override void Multiply(int x, int y)
    {
        Console.Write(x * y);
    }
}

class ScientificCalculator : Calculator
{
    public ScientificCalculator()
    {
        Console.WriteLine("I am a ScientificCalculator constructor"); 
    }
}

class Program
{
    public static void Main(string[] arg)
    {
        //Class1 c = new Class1(); // cannot be done because Class1 is an abstract class; it is Inherit-only i.e. you cannot instance Calculator
        //int ans = c.Multiply(2, 4);
        //Console.WriteLine(ans);

        ScientificCalculator calculator = new ScientificCalculator();
    }
}