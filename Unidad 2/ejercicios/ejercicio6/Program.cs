using System;

namespace ejercicio6
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ingresar por pantalla 4 numeros e indicar cuantos son menores a 100

            float a, b, c, d, cont = 0;
            Console.WriteLine("Ingrese 4 numeros");
            a=float.Parse(Console.ReadLine());
            b=float.Parse(Console.ReadLine());
            c=float.Parse(Console.ReadLine());
            d=float.Parse(Console.ReadLine());

            if(a>100)
                cont++;
                        
            if(b>100)
                cont++;
            
            if(c>100)
                cont++;
            
            if(d>100)
                cont++;
            
            if(cont==1)
                Console.WriteLine("Hay " + cont + " numero mayor a 100");
            else
                Console.WriteLine("Hay " + cont + " numeros mayores a 100");



        }
    }
}
