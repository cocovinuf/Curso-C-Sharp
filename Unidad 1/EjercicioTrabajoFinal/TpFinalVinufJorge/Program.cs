using System;

namespace TpFinalVinufJorge
{
    class Program
    {
        static void Main(string[] args)
        {
            hola(ref int n1, ref int n2);
            hacerAlgo2(ref int n1, ref int n2);

        }

        static int hacerAlgo2(ref int numero, ref int numero2){
            int res;
            numero = numero*2;
            numero2 = numero*3;

            res = numero * numero2;
            return res;
        }

        static void hola(ref int n1, ref int n2){
            Console.WriteLine("Ingrese un numero");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese un numero");
            int b = int.Parse(Console.ReadLine());
      
            Console.WriteLine("El resultado es " + hacerAlgo2(ref a, ref b));
            Console.WriteLine("El resultado es " + hacerAlgo2(ref a, ref b));
            Console.WriteLine("El resultado es " + hacerAlgo2(ref a, ref b));
        }
    }
}
