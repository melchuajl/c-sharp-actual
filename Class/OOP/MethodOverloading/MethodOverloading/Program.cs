//class Demo
//{
//    public void Add(int x, int y)
//    {
//        Console.WriteLine(x + y);
//    }
//    public void Add(int x, int y, int z) // number of params is different
//    {
//        Console.Write(x + y + z);
//    }
//    public void Add(string x, string y) // datatypes of params are different
//    {
//        Console.WriteLine(x + y);
//    }
//    public void Add(int x, float y)
//    {
//        Console.WriteLine(x + y); 
//    }
//    public void Add(float x, int y) // order/sequence of datatypes of params are different
//    {
//        Console.WriteLine(x + y);
//    }
//}

//class Program
//{
//    public static void Main(string[] args)
//    {
//        Demo obj = new Demo();
//        obj.Add("Hello ", "World");
//        obj.Add(10, 2.5f); // f at the end of the number lets the program know that it's a float 
//    }
//}

//class Demo
//{
//    public virtual void Calculator(int x, int y) // lets the Children override this Method
//    {
//        Console.WriteLine(x + y);
//    }
//}

//class Sample : Demo
//{
//    public new void Calculator(int x, int y)
//    {
//        Console.WriteLine(x * y); 
//    }
//}

//class Program
//{
//    public static void Main(string[] args)
//    {
//        Demo d = new Sample(); // this can be seen in Interfaces
//        d.Calculator(10, 20);

//        Sample s = (Sample) new Demo(); // need to use explicit type-casting to convert to the Child datatype (parent can hold child, child cannot hold parent)
//        s.Calculator(10, 20);
//    }
//}

//interface IMyInterface
//{
//    void Sum(int x, int y); 
//    void Cube(int x);
//}

//interface Interface2 : IMyInterface // interfaces can be inherited from other interfaces
//{
//    void Square(int x);
//}

//class Calculator : Interface2 // this LOOKS like inheritance but the technical name is implementation, this is a way to 'inherit' multiple classes which is not allowed in C#
//{
//    public void Sum(int x, int y)
//    {
//        Console.WriteLine(x + y); 
//    }
//    public void Cube(int x)
//    {
//        Console.WriteLine(x * x * x); 
//    }
//    public void Square (int x)
//    {
//        Console.WriteLine(x * x); 
//    }

//}


class Program
{
    enum MusicPlayer // enums must be a collection of integers
    {
        Play = 45, 
        Pause, // 46
        Record = 100, 
        Stop // 101
    }
    public static void Main(string[] args)
    {
        Console.WriteLine((int)MusicPlayer.Pause); 
    }
}