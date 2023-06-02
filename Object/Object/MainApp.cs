using System;

namespace Object
{
    class MainApp
    {
        static void Main(string[] args)
        {
            object a = 123;
            object b = 3.14159265358979323843383279m;
            object c = true;
            object d = "Hello.";

            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
            Console.WriteLine(d);
        }
    }
}
