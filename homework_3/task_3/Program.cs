internal partial class Program
{
    private static void Main(string[] args)
    {
        const double pi = 3.14;
        int radius;
        
        Console.WriteLine("Enter the radius");
        string input1 = Console.ReadLine();
        radius = int.Parse(input1);
        Console.WriteLine(pi * Math.Pow(radius, 2)); 
    }
}