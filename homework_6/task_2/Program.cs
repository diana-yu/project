using System;

namespace Methods
{
    class Program
    {
        static double Convert(double sum, double rate)
        {
            return sum * rate;
        }
        
        static void Main()
        {
            double sum;
            double rate;
            
            Console.WriteLine("Enter the amount");
            string input1 = Console.ReadLine();

            Console.WriteLine("Enter the currency conversion rate");
            string input2 = Console.ReadLine();

            sum = double.Parse(input1);
            rate = double.Parse(input2);

            double convertResult = Convert(sum, rate);

            Console.WriteLine($"Convertation rate {convertResult}");

            Console.ReadKey();
        }
    }
}
