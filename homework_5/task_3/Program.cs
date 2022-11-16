internal partial class Program
{
    private static void Main(string[] args)
    {
        int number;
        int result = 1;

        Console.WriteLine("Enter number of clients");
        string input1 = Console.ReadLine();

        number = int.Parse(input1);

        do
        {
            result = result * number--;
        }
       
        while (number > 1);

        Console.WriteLine("Result = " + result);
    }
}