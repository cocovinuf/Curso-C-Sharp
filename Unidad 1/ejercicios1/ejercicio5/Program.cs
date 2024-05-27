using System;

namespace ejercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
        //              Ejercicio 5
            
            float nota1, nota2, nota3, promedio;
            Console.WriteLine("Ingrese las 3 notas");
            nota1 = float.Parse(Console.ReadLine());
            nota2 = float.Parse(Console.ReadLine());
            nota3 = float.Parse(Console.ReadLine());
            promedio = (nota1+nota2+nota3)/3;
            Console.WriteLine("El promedio es " + promedio.ToString("0.00")); 
        }
    }
}
