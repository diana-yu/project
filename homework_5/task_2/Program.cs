internal partial class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine();
        Console.WriteLine("Rectangle");
        Console.WriteLine();

        int height = 6;
        int width = 10;        

        for (int rowCounter = 0; rowCounter < height; rowCounter++)
        {
            for (int columnCounter = 0; columnCounter < width; columnCounter++)
            {
                Console.Write("*");
            }

            Console.WriteLine();
        }

        Console.WriteLine();
        Console.WriteLine("Right triangle");     
        Console.WriteLine();

        int a = 10;

        for (int rowCounter = 0; rowCounter < a; rowCounter++)
        {
            for (int columnCounter = 0; columnCounter <= rowCounter; columnCounter++)
            {
                Console.Write("*");
            }

            Console.WriteLine();
        }

        Console.WriteLine();
        Console.WriteLine("Triangle");

        int height2 = 10;
        Console.WriteLine();

        for (int i = 0; i < height2; i++)
        {
            Console.SetCursorPosition(height2 - i - 1, Console.CursorTop);
            Console.WriteLine(new string('*', i * 2 + 1));
        }  
    }
}
