using System;

namespace NotaValida
{
    class Program
    {
        static void Main(string[] args)
        {
            double nota;
            Console.WriteLine("Dime la nota que has sacado en Programación");
            nota = double.Parse(Console.ReadLine());
            if(nota>=0 && nota <= 10)
            {
                if(nota < 5)
                {
                    Console.WriteLine("Suspenso");
                }
                else
                {
                    Console.WriteLine("Aprobado");
                }

            }
            else
            {
                Console.WriteLine("Nota no válida");
            }
        }

    }
}
