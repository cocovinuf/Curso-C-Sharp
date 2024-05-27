using System;

namespace ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Hacer un programa para ingresar un número y luego se emita un cartel por pantalla “Positivo” 
            //si el número es mayor a cero, “Negativo” si el número es menor a cero o “Cero” si el número es igual a cero

            float numero;
            Console.WriteLine("Ingrese un numero");
            numero = float.Parse(Console.ReadLine());
            if (numero > 0)
            Console.WriteLine("Es positivo");
            else if (numero < 0)
            Console.WriteLine("Es negativo");
            else
            Console.WriteLine("Es cero");
        }
    }
}
