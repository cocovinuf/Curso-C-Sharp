using System;

namespace ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
             //              Ejercicio 2
            int num, numCub;
            Console.WriteLine("Ingrese un numero");
            num = int.Parse(Console.ReadLine());
            numCub = num * num * num;
            Console.WriteLine("El cubo del numero ingresado es " + numCub);

        }
    }
}
