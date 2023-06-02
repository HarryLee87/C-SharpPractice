using System;

namespace IntegralConverstion
{
    class MainApp
    {
        static void Main(string[] args)
        {
            sbyte a = 127;
            Console.WriteLine(a);

            int b = (int)a;
            Console.WriteLine(b);

            int x = 128; //the max of sbyte 1 greater than 127
            Console.WriteLine(x);

            sbyte y = (sbyte)x; //overflow
            Console.WriteLine(y);

        }
    }
}
