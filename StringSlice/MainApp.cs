using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;


namespace StringSlice
{
    public class MainApp
    {
        static void Main(string[] args)
        {
            string greeting = "Good Morning";

            WriteLine(greeting.Substring(0, 5)); //"Good"
            WriteLine(greeting.Substring(5)); // "Morning"
            WriteLine();


            string[] arr = greeting.Split(
                new string[] { " " }, StringSplitOptions.None);
            WriteLine("Word Count : {0}", arr.Length);

            foreach (string element in arr)
                Console.WriteLine("{0}", element);
            
            Console.ReadKey();
        }
    }
}
