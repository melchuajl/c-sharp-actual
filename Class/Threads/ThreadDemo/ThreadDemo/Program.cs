//namespace ThreadDemo
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            CancellationTokenSource source = new CancellationTokenSource();
//            CancellationToken token = source.Token;
//            //taking a token to be used inside the process
//            int i = 1;
//            Task.Factory.StartNew(new Action(() =>
//            //writing the Start() method within, to create an instance of Task and start the task.
//            {
//                while (!token.IsCancellationRequested)
//                //it should keep on going unless the cancellation is requested and the value becomes true.
//                {
//                    Task.Delay(1000).Wait();
//                    Console.WriteLine(i);
//                    i++;
//                }
//            }));
//            Console.ReadKey();
//            //to read the input key from the user; basically to ask the console to wait for user input.
//            source.Cancel();
//            //
//        }
//    }
//}

//namespace DelegateDemo
//{
//    public class Demo
//    {
//        public int Sum(int x, int y)
//        {
//            return x + y;
//        }
//        public int Subtract(int x, int y)
//        {
//            return x - y;
//        }
//    }
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            Demo d = new Demo();
//            Func<int, int, int> f = d.Subtract;
//            int result = f(100, 50);
//            Console.WriteLine(result);
//        }
//    }
//}

//namespace ThreadsDemo
//{
//    class Demo
//    {
//        public void Show()
//        {
//            for (int i = 1; i <= 10; i++)
//            {
//                Console.WriteLine($"{Thread.CurrentThread.Name} is printing {i}");
//                Thread.Sleep(1000);
//            }
//        }
//        public void Display()
//        {
//            for (int i = 10; i >= 1; i--)
//            {
//                Console.WriteLine($"{Thread.CurrentThread.Name} is printing {i}");
//                Thread.Sleep(1000);
//            }
//        }
//    }
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            Demo d = new Demo();
//            Task t = new Task(new Action(d.Show));
//            t.Start();
//            t.Wait();
//        }
//    }
//}

using System.Xml.Serialization;

namespace FeaturesDemo
{
    public class Demo
    {
        public void Sum (int x, int y, out int z)
        {
            z = x + y;
        }
    }

    internal class Program
    {
    static void Main(string[] args)
        {
            Demo d = new Demo();
            int result;
            d.Sum(10, 20, out result); 
            Console.WriteLine(result); // tbh this is not usually preferred to using a Tuple or a return Method
        }
    }
}