using System;

namespace ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
                //Ejercicio 1
            int primero, segundo, resul;
            //Escribe en console
            Console.WriteLine("Ingrese un numero");
            //Le indica al programa que lo escrito en consola es un numero entero
            primero = int.Parse(Console.ReadLine());
            //Vuelve a escribir en consola
            Console.WriteLine("Ingrese otro numero");
            //Le indica al programa que lo escrito en consola es un numero entero
            segundo = int.Parse(Console.ReadLine());
            //Suma los dos primeros numeros y el resultado lo asigna a la variable "resul"
            resul = primero + segundo;
            //Escribe el resultado en consola concatenando un texto con la variable "resul"
            Console.WriteLine("La suma de ambos numeros es " + resul); 
        }
    }
}
