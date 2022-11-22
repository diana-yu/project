using System;

namespace Methods
{
    class Program
    {
        static string Compare(int number)

       
        {
            string positiveNumber = number > 0 ? "positive":"negative or zero";

            string divisibleNumber = number %  2 == 0 ? "divisible by 2 without remainder" : "not divisible by 2 without remainder";  
                                    
            return ($"The number is {positiveNumber} and {divisibleNumber}");
        }

        static void Main()
        {
            int number;

            Console.WriteLine("Enter number");
            string input1 = Console.ReadLine();

            number = int.Parse(input1);

            string result = Compare(number);

            Console.WriteLine(result);

            Console.ReadKey();
        }
    }
}