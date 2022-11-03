
    int a;
    int b;
    //string name = "Сума";

    Console.WriteLine("Введи число 1");
    string input1 = Console.ReadLine();
    Console.WriteLine("Введи число 2");
    string input2 = Console.ReadLine();
    a = int.Parse(input1);
    b = int.Parse(input2);
    Console.WriteLine("Summa %s", a + b);
    Console.WriteLine(a - b);
    Console.WriteLine(a * b);
    Console.WriteLine((double) a / b);
