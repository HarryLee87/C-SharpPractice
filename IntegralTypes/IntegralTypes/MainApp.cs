namespace IntegralTypes
{
    class MainApp
    {
        static void Main(string[] args)
        {
            sbyte a = 127;
            byte b = 40;

            Console.WriteLine($"a = {a}, b = {b}");

            short c = -30000;
            ushort d = 60000;

            Console.WriteLine($"c = {c}, d = {d}");

            int e = -1000_0000; // 7 of 0
            uint f = 3_0000_0000; // 8 of 0

            Console.WriteLine($"e = {e}, f = {f}");

            long g = -5000_0000_0000; // 11 of 0
            ulong h = 200_0000_0000_0000_0000; // 18 of 0

            Console.WriteLine($"g = {g}, h = {h}");

            byte i = 240; // Decimal litteral
            Console.WriteLine($"i={i}");

            byte j = 0b1111_0000; // Binary Letteral
            Console.WriteLine($"j={j}");

            byte k = 0XF0;        // Hexadecimal Letteral
            Console.WriteLine($"k={k}");

            uint l = 0x1234_abcd; // Hexadecimal Letteral
            Console.WriteLine($"l = {l}");


        }
    }
}
