using System;

namespace practicas
{
    class Program
    {
        static void Main(string[] args)
        {

            int n1=0, n2=0;
            
            pedirNumeros(ref n1, ref n2);
            int resultado = sumar(n1,n2);
            Console.WriteLine("El resultado es: " + resultado);
            Console.WriteLine("El resultado de n1 es " + n1);

        }


        static void pedirNumeros(ref int n1, ref int n2){
            Console.WriteLine("Ingrese un numero");
            n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese otro");
            n2 = int.Parse(Console.ReadLine());
        }

        static int sumar(int a, int b){
            int resulFunc;
            resulFunc = a + b;
            a = 9999;
            return resulFunc;

        }

    }
}
