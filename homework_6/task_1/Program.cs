using System;

namespace Methods
{
    class Program
    {
        static int Add(int firstNumber, int secondNumber)
        {
            return firstNumber + secondNumber;
        }

        static int Sub(int firstNumber, int secondNumber)
        {
            return firstNumber - secondNumber;
        }

        static int Mul(int firstNumber, int secondNumber)
        {
            return firstNumber * secondNumber;
        }

        static double Div (int firstNumber, int secondNumber)
        {
            if (secondNumber != 0)
                {
                    return (double)firstNumber / secondNumber;
                }
            else
                {
                    return Double.NaN;
                }
        }

        static void Main()
        {
            int firstNumber;
            int secondNumber;
            string arithmeticSign;
            
            Console.WriteLine("Enter first number");
            string input1 = Console.ReadLine();

            Console.WriteLine("Enter the sign of an arithmetic operation");
            string input2 = Console.ReadLine();
            
            Console.WriteLine("Enter second number");
            string input3 = Console.ReadLine();

            firstNumber = int.Parse(input1);
            arithmeticSign = (input2);
            secondNumber = int.Parse(input3);   
            
            switch (arithmeticSign)
            {
                case "+":
                     int sumResult = Add(firstNumber, secondNumber);
                     Console.WriteLine($"{firstNumber} + {secondNumber} = {sumResult}");
                    break;
                case "-":
                    int subResult = Sub(firstNumber, secondNumber);
                    Console.WriteLine($"{firstNumber} - {secondNumber} = {subResult}");
                    break;
                case "*":
                    int mulResult = Mul(firstNumber, secondNumber);
                    Console.WriteLine($"{firstNumber} * {secondNumber} = {mulResult}");
                    break;
                case "/":
                    double divResult = Div(firstNumber, secondNumber);
                    Console.WriteLine($"{firstNumber} / {secondNumber} = {divResult}");
                    break;
                default:
                    Console.WriteLine("I don`t know");
                    break;
            }

            Console.ReadKey();
        }
    }
}
