internal partial class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Введи число від 0 до 100!");
        int number = int.Parse(Console.ReadLine());

        if (number <= 14)
        {
            Console.WriteLine("[0 - 14]");
        }
        else if (number > 14 & number <= 35)
        {
            Console.WriteLine("[15 - 35]");
        }
        else if (number > 35 & number <= 50)
        {
            Console.WriteLine("[36 - 50]");
        }
        else if (number >= 50 & number <= 100)
        {
            Console.WriteLine("[51 - 100]");
        }
        else
        {
            Console.WriteLine("Не входить в 0-100");    
        }
    }
}