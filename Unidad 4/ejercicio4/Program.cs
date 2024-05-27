using System;

namespace ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            //4. Hacer un programa que solicite UN número y luego calcule y emita un cartel aclaratorio si el mismo es primo o no es primo. 
            //Nota: un numero es primo cuando es divisible únicamente por 1 y por sí mismo.

            int numero=0, con=0;
            Console.WriteLine("Ingrese un numero");
            numero = int.Parse(Console.ReadLine());

            for (int i = 1; i <= numero; i++)
            {
                if(numero%i == 0){
                    con++;
                }
            }

            if(con>2){
                Console.WriteLine("El numero NO es primo");
            }
            else{
                Console.WriteLine("El numero SI es primo");
            }

            
        }
    }
}
