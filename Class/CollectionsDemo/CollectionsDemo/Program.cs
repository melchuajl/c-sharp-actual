using System.Collections; 

public class Program
{
    public static void Main(string[] args)
    {
        ArrayList list = new ArrayList();
        list.Add(10); 
        list.Add(20);
        list.Add(30);
        list.Add("One");
        list.Add("House");

        Console.WriteLine(list.IndexOf(30)); // this will only print the data type (i.e. System.Collections.ArrayList)

        foreach (var item in list)
        {
            Console.WriteLine(item);
        }

        list.Remove(30); // you need to specify the value of the index you want to remove. anything after that will be moved "up" the index. if there are multiple cells with the same value, only the first occurance will be removed.

        Console.WriteLine($"Index 2 becomes {list[2]}");

        Stack stack = new Stack(); // Stack follows LIFO (last in, first out)
        stack.Push(10);
        stack.Push(20);
        stack.Push(30);
        stack.Push(40);

        Console.Write(stack.Pop()); // removes and returns the last value 
        Console.WriteLine(stack.Peek()); // returns the last value, but won't remove it

        //Stack<int> stack2 = new Stack<int>();
        //stack.Push(1);
        //stack.Push(2);
        //stack.Push(3);
        //stack.Push(4);

        //int top = stack2.ElementAt(0); // Returns 4
        //int next = stack2.ElementAt(1); // Returns 3

        Queue q = new Queue(); // Queue follows FIFO (first in, first out)

        q.Enqueue(10);
        q.Enqueue(20);
        q.Enqueue(30);
        q.Enqueue(40);

        Console.WriteLine(q.Dequeue()); // removes and returns the first value

        SortedList sort = new SortedList(); // sores data in key-value pairs instead of a numbered index, auto sorted based on keys
        
        sort.Add("one", "Cherry"); // (key, value)
        sort.Add("two", "Orange");
        sort.Add("four", "Apple");
        sort.Add("three", "Pear");

        foreach (var item in sort.Keys) // you can use (var items in sort.Values) if you want to return the values instead
        {
            Console.WriteLine($"{item} - {sort[item]}");
        }

        Console.WriteLine(sort["three"]); // returns the value of key = "four"
        Console.WriteLine(sort.GetByIndex(0)); // only the value in the key-value pair will be returned
    }
}