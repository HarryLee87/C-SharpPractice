using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoloLearn
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] games = { "Alien Shooter", "Tic Tac Toe", "Snake", "Puzzle", "Football" };

            //your code goes here
            int N = Convert.ToInt32(Console.ReadLine());
                
            if(N < games.Length && N >= 0)
            {
                Console.WriteLine(games[N]);
            }
            else
            {
                Console.WriteLine("Invalid Number");
            }
            Console.WriteLine("************switch statement*********");
            switch (N)
            {
                case 0:
                    Console.WriteLine(games[0]);
                    break;
                case 1:
                    Console.WriteLine(games[1]);
                    break;
                case 2:
                    Console.WriteLine(games[2]);
                    break;
                case 3:
                    Console.WriteLine(games[3]);
                    break;
                case 4:
                    Console.WriteLine(games[4]);
                    break;
                default:
                    Console.WriteLine("Invalid Number");
                    break;
            }
            Console.WriteLine("***********other way***********");
            try
            {
                Console.Write(games[Int32.Parse(Console.ReadLine())]);
            }
            catch(Exception a)
            {
                Console.Write("Invalid Number");
            }
            Console.ReadKey();
        }
    }
}