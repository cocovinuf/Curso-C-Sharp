using System;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            //paso 0: declarando variables
            int n1, n2, res; 

            Console.WriteLine("Ingrese el primer numero");
            n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo numero");
            n2 = int.Parse(Console.ReadLine());

            //Sumando
            res = n1 + n2;

            Console.WriteLine("El resultado es "+ res);
        }
    }
}
