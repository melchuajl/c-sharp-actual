class Program
{
    public static void Main()
    {
        ScoreCard sc = new ScoreCard();
        sc.Accept();
        sc.Display();
    }
}

class ScoreCard {

    int[] scores = new int[5];

    public void Accept()
    {
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine("Enter score");
            scores[i] = Convert.ToInt16(Console.ReadLine());
        }; 
    }

    public void Display()
    {
        int total = 0; 
        for (int i = 0; i < scores.Length; i++)
        {
            total += scores[i];
        };
        int average = total / 5;
        Console.WriteLine($"Total: {total}");
        Console.WriteLine($"Average: {average}");
    }

}
