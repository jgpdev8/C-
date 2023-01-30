using System;

namespace PositivoOnegativo
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("dime un número");
            num = int.Parse(Console.ReadLine());
            if(num == 0)
            {
                Console.WriteLine("El numero es cero");
            }else if (num < 0)
            {
                Console.WriteLine("El numero es negativo");
            }
            else Console.WriteLine("el numero es positivo");
        }
    }
}
