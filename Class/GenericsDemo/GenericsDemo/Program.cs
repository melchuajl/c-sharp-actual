public class Demo1
{
    private int num; // variable

    public int Age { get; set; } // Property

    public int Show() // Method
    {
        return num;
    }
}

public class Demo<T> // it's possible to have Demo<T, U> and call new Demo<float, bool> or new Demo<int, string> 
{
    T num; 
    public void SetValue(T x) // instead of int x, using T tells the program that the type is currently unknown
    {
        this.num = x;
    }
    public T GetValue()
    {
        return this.num;
    }

}

public class Program
{
    public static void Main(string[] args)
    {
        Demo<int> demo = new Demo<int>(); // this replaces all T in Demo class with int
        Demo<string> demo2 = new Demo<string>(); // this replaces all T in Demo class with string

        demo.SetValue(10);
        demo2.SetValue("Hello");

    }
}
