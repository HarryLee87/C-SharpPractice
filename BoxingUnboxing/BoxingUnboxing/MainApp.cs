using System;

namespace BoxingUnboxing
{
    class MainApp
    {
        static void Main(string[] args)
        {
            int a = 123;
            object b = (object)a; //the value in a is saved in heap
            int c = (int)b; // the value in b is unboxed and saved in stack

            Console.WriteLine(a); 
            Console.WriteLine(b); 
            Console.WriteLine(c); 

            double x = 3.1414213;
            object y = x;           // the value in x is boxed and saved in heap
            double z = (double)y;   // the value in y is unboxed and saved in stack

            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);
        }
    }
}
