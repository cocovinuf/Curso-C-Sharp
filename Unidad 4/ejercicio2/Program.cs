using System;

namespace ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            //2. Hacer un programa que solicite el ingreso de 10 números y que muestre el mayor de ellos por pantalla.
            //Solo se debe emitir UN valor por pantalla.

            int mayor=0, num=0;

            Console.WriteLine("Ingrese 10 numeros");

            for (int i = 0; i < 10; i++)
            {
                num = int.Parse(Console.ReadLine());
                if(mayor==0){
                    mayor=num;
                }
                

                if(num>mayor){
                    mayor = num;
                }
            }
            Console.WriteLine("El mayor de los numeros ingresados es " + mayor);
        }
    }
}
