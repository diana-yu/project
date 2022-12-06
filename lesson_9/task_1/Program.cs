using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {

        static void Main(string[] args)
        {
            Collection c = new Collection();

            PrintHandler handler = x => x + 1;
            c.Print(handler);

            handler = x => x * x;
            c.Print(handler);

            handler = x => x * 3; // заменить на лямбда выражение
            c.Print(handler);

            Predicate predicate = x => x > 50;

            c.FilterAndPrint(predicate);

            // вызвать метод FilterAndPrint и вывести все значения больше чем 50
        }
    }

    public delegate int PrintHandler(int x);
    public delegate bool Predicate(int value);

    class Collection
    {
        private int[] data;

        public Collection()
        {
            data = new int[] { 1, 2, 6, 234, 7, 2, 3345, 67, 8 };
        }

        public void Print(PrintHandler handler)
        {
            Console.WriteLine("-------------------------------");
            for (int i = 0; i < data.Length; i++)
            {
                Console.WriteLine(handler.Invoke(data[i]));
            }
            Console.WriteLine("-------------------------------");
        }

        public void FilterAndPrint(Predicate predicate)
        {
            Console.WriteLine("===============================");
            for (int i = 0; i < data.Length; i++)
            {
                if (predicate.Invoke(data[i]))
                    Console.WriteLine(data[i]);
            }
            Console.WriteLine("===============================");
        }
    }
}