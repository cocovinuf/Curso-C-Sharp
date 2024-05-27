using System;

namespace ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
             //              Ejercicio 3
            
            float dist, vel, tiem;
            Console.WriteLine("Ingrese la distancia entre ciudades en km");
            dist = float.Parse(Console.ReadLine());
            Console.WriteLine("Ahora ingrese la velocidad en km/h");
            vel = float.Parse(Console.ReadLine());
            tiem = dist/vel;
            Console.WriteLine("El tiempo aproximado es " + tiem.ToString("0.0") + " horas"); 
        }
    }
}
