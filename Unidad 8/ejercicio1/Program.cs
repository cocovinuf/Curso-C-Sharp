using System;

namespace ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 1. Hacer una función llamada “producto” que reciba dos números enteros y que devuelva el producto de ambos. 
            Luego hacer un programa que pida el precio de un artículo y la cantidad vendida y muestre por pantalla el monto total a pagar. 
            Usar la función.*/


            int n1=0, n2=0, resultado=0;
           
            pedirNumeros(ref n1, ref n2);
            resultado = producto(n1,n2);

            Console.WriteLine("El monto total a pagar es de:  " + resultado);

        }

        static void pedirNumeros(ref int n1, ref int n2){
            Console.WriteLine("Ingrese el precio del artículo");
            n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la cantidad vendida");
            n2 = int.Parse(Console.ReadLine());
        }


        static int producto(int num1, int num2){
            int resultado = num1*num2;
            return resultado;
        }
    }
}
