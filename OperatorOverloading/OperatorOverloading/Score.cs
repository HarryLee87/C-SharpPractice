using System;
namespace OperatorOverloading
{
	public class Score
	{
		public int Round1Score { get; set; }
		public int Round2Score { get; set; }
        public Score(int r1, int r2)
        {
            Round1Score = r1;
            Round2Score = r2;
        }

        public static Score operator+(Score a, Score b)
        {
            int x = a.Round1Score + b.Round2Score;
            int y = a.Round1Score + b.Round2Score;
            Score res = new Score(x, y);
            return res;
        }
    }
}

