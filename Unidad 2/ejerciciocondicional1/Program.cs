using System;

namespace ejerciciocondicional1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Bloque IF
            int edad = 40;

            if (edad > 21 && edad < 30)
                Console.WriteLine("Sos mayor a 21 y menor a 30");
            else if (edad < 21)
                Console.WriteLine("Tenes menos de 21");
            else if (edad > 30)
                Console.WriteLine("Tenes mas de 30");
            

            Console.WriteLine("Fin del programa");

        }
    }
}
