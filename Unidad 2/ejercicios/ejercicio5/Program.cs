using System;

namespace ejercicio5
{
    class Program
    {
        static void Main(string[] args)
        {

            //Hacer un programa para ingresar cuatro números y luego mostrar por pantalla cuáles son mayores a 100.

             float n1, n2, n3, n4, con = 0;
            Console.WriteLine("Ingrese 4 numeros distintos");
            n1 = float.Parse(Console.ReadLine());
            n2 = float.Parse(Console.ReadLine());
            n3 = float.Parse(Console.ReadLine());
            n4 = float.Parse(Console.ReadLine());

            if(n1>100){
                Console.Write(" " + n1 + " ");
                con++;
            }
                
            if(n2>100){
                Console.Write(" " + n2 + " ");
                con++;
            }
                
            if(n3>100){
                Console.Write(" "+ n3 + " ");
                con++;
            }
                
            if(n4>100){
                Console.Write( " " +n4 + " ");
                con++;
            }
            
            if(con>0){
                Console.WriteLine("son mayores a 100");
            }
            
            if(con==0)
                Console.WriteLine("Ninguno es mayor a 100");

        }
    }
}
