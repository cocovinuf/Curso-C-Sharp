using System;

namespace ejercicio1._1
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 1. Hacer un programa que solicite el ingreso de dos números y luego calcular:

                La resta si el primero es mayor que el segundo.
                La suma si son iguales.
                El producto si el primero es menor.
                Se deberá emitir un cartel por pantalla con el resultado correspondiente. */


            int num1, num2, resultado = 0;
            Console.WriteLine("Ingrese 2 numeros");
            num1 = int.Parse(Console.ReadLine());
            num2 = int.Parse(Console.ReadLine());
            
            if(num1>num2)
                resultado = num1 - num2;
            else if(num1==num2)
                resultado = num1 + num2;
            else if(num1<num2)
                resultado = num1*num2;
            
            Console.WriteLine("El resultado es " + resultado);
            
        
            


        }
    }
}
