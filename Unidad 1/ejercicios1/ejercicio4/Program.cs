using System;

namespace ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            //        Ejercicio 4
            
        const float sueldo = 15000;
        const float comision = 0.05F;
        float sueldoTotal;
        float facturado;

        Console.WriteLine("Ingrese el total facturado");
        facturado = float.Parse(Console.ReadLine());
        sueldoTotal = sueldo + (facturado * comision);
        Console.WriteLine("El total a cobrar es " + sueldoTotal);

        }
    }
}