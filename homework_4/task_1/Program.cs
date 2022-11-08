internal class Program
{
    private static void Main(string[] args)
    {
        
        Console.WriteLine("Введи число 1");
        int operand1 = int.Parse(Console.ReadLine());
       
        Console.WriteLine("Введи знак!");
        string sign = Console.ReadLine();
           
        Console.WriteLine("Введи число 2");
        int operand2 = int.Parse(Console.ReadLine());

        switch (sign)
            {
                case "+":
                    Console.WriteLine(operand1 + operand2);
                    break;
                case "-":
                    Console.WriteLine(operand1 - operand2);
                    break;
                case "*":
                    Console.WriteLine(operand1 * operand2);
                    break;
                case "/":
                    if (operand2 == 0)
                        Console.WriteLine("На 0 не ділять");
                    else
                        Console.WriteLine(operand1 / operand2);
                    break;
                default:
                    Console.WriteLine("Не знаю!");
                    break;
            }

    }
}