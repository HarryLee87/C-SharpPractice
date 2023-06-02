using static System.Console;

namespace Hello
{
    class MainApp
    {
        static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                Console.WriteLine("How to use : Hello.exe <NAME>");
                return;
            }
            WriteLine("Hello, {0}!", args[0]);
        }
    }
}
