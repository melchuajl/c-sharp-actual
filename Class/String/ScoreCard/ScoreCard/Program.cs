void ScoreCard(string name, int score1, int score2, int score3)
{
    int total = score1 + score2 + score3;
    int average = total / 3;
    Console.WriteLine($"Hello {name}, your total score is {total} and \n your average score is {average}.");
    Console.WriteLine("Hello " + name + " your total scare is " + total + " and your average score is " + average + ".");
};

ScoreCard("Melissa", 80, 90, 100);

int Cube(int num)
{
    int result = num * num * num; 
    return result;
};

Console.WriteLine("The cube of 5 is " + Cube(5)); 