using System;

namespace ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Evaluando

            int numero;
            Console.WriteLine("Ingrese un numero del 1 al 5");
            numero = int.Parse(Console.ReadLine());

            switch(numero){
                case 1:
                    Console.WriteLine("Usted ingreso el numero 1");
                    break;
                case 2:
                    Console.WriteLine("Usted ingreso el numero 2");
                    break;
                case 3:
                    Console.WriteLine("Usted ingreso el numero 3");
                    break;
                case 4:
                    Console.WriteLine("Usted ingreso el numero 4");
                    break;
                case 5:
                    Console.WriteLine("Usted ingreso el numero 5");
                    break;
                default:
                    Console.WriteLine("ERROR: Debe ingresar un numero del 1 al 5");
                    break;
            }
        }
    }
}
