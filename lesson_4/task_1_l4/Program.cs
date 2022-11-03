internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Введи значення!");
        string word = Console.ReadLine();

        // if (word == "яблуко")
        // {
        //     Console.WriteLine("apple");
        // }
        // else if (word == "привт")
        // {
        //     Console.WriteLine("hi");
        // }
        // else
        // {
        //     Console.WriteLine("Не знаю");    
        // }

        switch (word)
            {
                case "яблуко":
                    Console.WriteLine("apple");
                    break;
                case "небо":
                    Console.WriteLine("sky");
                    break;
                default:
                    Console.WriteLine("Не знаю!");
                    break;
            }
    }
}