using System;

namespace ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. Hacer un programa que solicite 10 números enteros y los guarde en un vector. 
            //Luego recorrer los elementos y determinar e informar cuál es el valor máximo y su posición dentro del vector.

            int num = 0, anterior = 0, maximo = 0, posicion = 0;
            int[] vector = new int[10];

            Console.WriteLine("Ingrese 10 numeros");

            for (int i = 0; i < 10; i++)
            {
                num = int.Parse(Console.ReadLine());
                vector[i] = num;

            }

            
            anterior = vector[0];

            for (int x = 0; x < 10; x++)
            {
                
                
                if(vector[x]>anterior){
                    maximo = vector[x];
                    posicion = x;
                    anterior = vector[x];
                }

            }

            Console.WriteLine("El mayor es " + maximo + " y su posicion es " + (posicion+1));

        }
    }
}
