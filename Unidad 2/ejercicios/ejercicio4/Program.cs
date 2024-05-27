using System;

namespace ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Hacer un programa para ingresar cuatro números distintos y luego mostrar por pantalla el menor de ellos.

            float n1, n2, n3, n4, menor = 0;
            Console.WriteLine("Ingrese 4 numeros distintos");
            n1 = float.Parse(Console.ReadLine());
            n2 = float.Parse(Console.ReadLine());
            n3 = float.Parse(Console.ReadLine());
            n4 = float.Parse(Console.ReadLine());

            if(n1 < n2)
                menor = n1;
            else 
                menor = n2;
            
            if(n3 < menor)
                menor = n3;
            
            if(n4 < menor)
                menor = n4;
            

            Console.WriteLine("El menor es " + menor);


        }
    }
}
