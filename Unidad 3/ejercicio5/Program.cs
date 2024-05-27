using System;

namespace ejercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            //5. Hacer un programa para ingresar 4 números. Luego analizar e informar por pantalla si los mismos se 
            //encuentran ordenados de forma decreciente .

            float n1,n2,n3,n4;
            Console.WriteLine("Ingrese 4 numeros");
            n1=float.Parse(Console.ReadLine());
            n2=float.Parse(Console.ReadLine());
            n3=float.Parse(Console.ReadLine());
            n4=float.Parse(Console.ReadLine());

            if(n1>n2 && n2>n3 && n3>n4)
                Console.WriteLine("Los numeros están ordenados de forma decreciente");
                else
                {
                    Console.WriteLine("Los numeros NO están ordenados de forma decreciente");
                }
      
        }
    }
}
