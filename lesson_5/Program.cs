internal class Program
{
    private static void Main(string[] args)
    {
        Random r = new Random();

        int height = r.Next(6,33);
        int width = r.Next(1,9);

        for (int rowCounter = 0; rowCounter < height; rowCounter++)
        {
            for (int columnCounter = 0; columnCounter < width; columnCounter++)
            {
                Console.Write("*");
            }

            Console.WriteLine();
        }

    }
}