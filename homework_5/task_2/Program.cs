internal partial class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine();
        Console.WriteLine("Rectangle");
        Console.WriteLine();

        int height = 10;
        int width = 16;        

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

        for (int rowCounter = 0; rowCounter < height; rowCounter++)
        {
            for (int columnCounter = 0; columnCounter <= rowCounter; columnCounter++)
            {
                Console.Write("*");
            }

            Console.WriteLine();
        }

        Console.WriteLine();
        Console.WriteLine("Triangle");

        Console.WriteLine();

        for (int i = 0; i < height; i++)
        {
            Console.SetCursorPosition(height - i - 1, Console.CursorTop);
            Console.WriteLine(new string('*', i * 2 + 1));
        }  
    }
}
