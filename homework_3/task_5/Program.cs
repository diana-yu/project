internal partial class Program
{
    private static void Main(string[] args)
    {
//       int uberflu?;
//       int  _Identifier;
//       int \u006fIdentifier;
//       int &myVar;
//       int myVariab1le;

        Console.WriteLine("uberflu? - ? - Недопустимий символ при створенні змінної");
        Console.WriteLine("_Identifier_ - Допустимі символи");
        Console.WriteLine("\u006fIdentifier - Допустимі символи");    
        Console.WriteLine("&myVar - & - Недопустимий символ");
        Console.WriteLine("myVariab1le - Допустимі символи");
    }    
}
