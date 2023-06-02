namespace Sum;
class Program
{
    static void Main(string[] args)
    {
        //Your math teacher asked you to calculate the sum of the numbers 1 to N, where N is a given number.
        //The given program takes a number as input.
        Console.WriteLine("Enter a max number to be added by 1 to N: ");
        int num = Convert.ToInt32(Console.ReadLine());

        int total = 0;
        int i = 1;
        while(i<=num)
        {
            total += i;
            i++;
        }
        int sum = 0;
        while(num>0)
        {
            sum += num--;
        }
        Console.WriteLine(total);
        Console.WriteLine(sum);
        Console.ReadKey();
    }
}

