internal class Program
{
    private static void Main(string[] args)
    {
        int x = 10;
        int y = 12;
        int z = 3;
        
        Console.WriteLine(x += y - x++ * z);
        Console.WriteLine(z = --x - y * 5);
        Console.WriteLine(y /= x + 5 % z);
        Console.WriteLine(z = x++ + y * 5);
        Console.WriteLine(x = y - x++ * z);
    }
}