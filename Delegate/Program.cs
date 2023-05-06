using System;

namespace Delegates
{
    class Program
    {

        static void Main()
        {
            Delegate delegates = new Delegate();
            Console.WriteLine("Введите число с плавающей запятой");
            delegates.Print(double.Parse(Console.ReadLine()));
        }
    }
}
