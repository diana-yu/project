internal partial class Program
{
    private static void Main(string[] args)
    {
        const double pi = 3.14;
        int radius;
        int height;
        
        Console.WriteLine("Enter the radius");
        string input1 = Console.ReadLine();
        radius = int.Parse(input1);

        Console.WriteLine("Enter the height");
        string input2 = Console.ReadLine();
        height = int.Parse(input2);
        
        Console.WriteLine ("V = " + (pi * Math.Pow(radius, 2) * height));
        Console.WriteLine ("S = " + (2 * pi* radius *(radius + height)));
    }
}