using System;

namespace ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            //4. Hacer un programa para ingresar tres números 
            //y emitir un cartel aclaratorio si la suma de los dos primeros es mayor al producto del segundo con el tercero.

            int num1,num2,num3, suma=0, prod=0;
            Console.WriteLine("Ingrese 3 numeros");
            num1=int.Parse(Console.ReadLine());
            num2=int.Parse(Console.ReadLine());
            num3=int.Parse(Console.ReadLine());
            suma = num1 + num2;
            prod = num2 * num3;

            if(suma>prod)
                Console.WriteLine("La suma de los dos primeros es mayor al producto del segundo y el tercero");
                else
                {
                    Console.WriteLine("La suma de los dos primeros es menor al producto del segundo y tercero");
                }


        }
    }
}
