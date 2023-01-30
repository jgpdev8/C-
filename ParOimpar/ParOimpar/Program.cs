using System;

namespace ParOimpar
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("Dime un número");
            num = int.Parse(Console.ReadLine());
            if(num % 2 == 0)
            {
                Console.WriteLine("el número es par");
            }
            else Console.WriteLine("el número es impar");
        }
    }
}
