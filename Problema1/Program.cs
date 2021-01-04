using System;

namespace Problema1
{
    class Program
    {
        static void Main(string[] args)
        {
            int? number;

            Console.WriteLine("Ingresar un Numero entre 0 y 999 ");

            number = Convert.ToInt32(Console.ReadLine());
            if(number >= 100)
            {
                Console.WriteLine("Numero de 3 digitos");
            }           
            if(number >= 10)
            {
                Console.WriteLine("Numero de 2 digitos");
            }
            else
            {
                Console.WriteLine("Numero de 1 digitos");
            }
            
            if(number == 0)
            {
                Console.ReadKey();
            }
        }
    }
}
