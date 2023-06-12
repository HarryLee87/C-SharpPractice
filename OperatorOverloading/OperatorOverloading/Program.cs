namespace OperatorOverloading;
class Program
{
    static void Main(string[] args)
    {
        Score tm1 = new Score(2, 3);
        Score tm2 = new Score(4, 2);

        Score finalScores = tm1 + tm2;


        Console.WriteLine("Round 1: " + finalScores.Round1Score);
        Console.WriteLine("Round 2: " + finalScores.Round2Score);
    }
}

