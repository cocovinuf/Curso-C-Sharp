using System;

namespace ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            float e1, e2,e3, contador = 0, acumulador= 0, promedio;
           ;

            Console.WriteLine("Ingrese 3 edades");

            e1 = float.Parse(Console.ReadLine());
            contador++;
            acumulador += e1;
            e2 = float.Parse(Console.ReadLine());
            contador++;
            acumulador += e2;
            e3 = float.Parse(Console.ReadLine());
            contador++;
            acumulador += e3;

            promedio = acumulador/contador;

            Console.WriteLine("El promedio de las edades es: " + promedio.ToString("0.0"));

        }
    }
}
