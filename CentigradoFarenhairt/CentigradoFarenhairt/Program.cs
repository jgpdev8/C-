using System;

namespace CentigradoFarenhairt
{
    class Program
    {
        static void Main(string[] args)
        {
            string opcion;
            double grados;
            Console.WriteLine("¿Que grados quieres convertir, Centigrados o Farenheit");
            opcion = Console.ReadLine();
            Console.WriteLine("Dime los grados");
            grados = double.Parse(Console.ReadLine());

            if (opcion == "centigrados")
            {
                grados = (grados * 9 / 5) + 32;
                Console.WriteLine(grados);
            }
            else
            {
                grados = (grados - 32) * 5/9;
                Console.WriteLine(grados);
            }
        }
    }
}
