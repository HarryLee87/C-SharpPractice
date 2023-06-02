using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace StringSearch
{
    public class MainApp
    {
        static void Main(string[] args)
        {
            string greeting = "Good Morning";

            Console.WriteLine(greeting);
            Console.WriteLine();

            //indexOf()
            Console.WriteLine("IndexOf 'Good' : {0}", greeting.IndexOf("Good"));
            Console.WriteLine("IndexOf 'o' : {0}", greeting.IndexOf('o'));

            // LastIndexof()
            Console.WriteLine("StartWith 'Good' : {0}", greeting.StartsWith("Good"));
            WriteLine("Startwith 'Morning' : {0}", greeting.StartsWith("Morning"));

            // Endswith()
            WriteLine("EndsWith 'Good' : {0}", greeting.EndsWith("Good"));
            WriteLine("EdnsWith 'Morning' : {0}", greeting.EndsWith("Morning"));

            // Contains()
            WriteLine("Contains 'Evening' : {0}", greeting.Contains("Evening"));
            WriteLine("Contains 'Morning' : {0}", greeting.Contains("Morning"));

            // Replace()
            WriteLine("Replaced 'Morning' with 'Evening': {0}", greeting.Replace("Morning", "Evening"));
        }
    }
}
