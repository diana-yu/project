internal partial class Program
{
    private static void Main(string[] args)
    {
        long a;
        long b;
        long c;
        Console.WriteLine("one");
        string input1 = Console.ReadLine();
        Console.WriteLine("two");
        string input2 = Console.ReadLine();
        Console.WriteLine("three");
        string input3 = Console.ReadLine();
        a = long.Parse(input1);
        b = long.Parse(input2);
        c = long.Parse(input3);
        float avg = ((float)(a + b + c) / 3 );
        Console.WriteLine("Середнє арифметичне " + (avg));
    }
}