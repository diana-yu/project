internal class Program
{
    private static void Main(string[] args)
    {
        int a;
        int b;
        int sum = 0;

        Start:
    
        do
        {
            Console.WriteLine("Enter A number");
            string input1 = Console.ReadLine();

            Console.WriteLine("Enter B number");
            string input2 = Console.ReadLine();

            a = int.Parse(input1);
            b = int.Parse(input2);

            Console.WriteLine ("A needs to be < B");
        }

        while (a >= b);

        for (int number = a + 1; number < b; number++)
        {
            sum += number;
        }

        Console.WriteLine("Sum of all numbers = " + sum);

        for (int counter = a + 1; counter < b; counter++)
        {
            if (counter % 2 > 0) 
            {
                Console.WriteLine(counter);
            }
        }

    }
}