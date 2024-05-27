using System;

namespace ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Hacer una función llamada “primo” que reciba un número entero y devuelva 1 si el número es primo o cero si no lo es. 
            // Hacer un programa para ingresar números. 
            // El lote corta cuando se ingresa un número cero. Informar el promedio teniendo en cuenta sólo los números primos.


            // Version 1:

            int n=1, acuPrimos=0, contadorPrimos=-1; 
            float promedio=0;
            bool esPrimo;


            while (n!=0)
            {
                pedirNumeros(ref n); 
                esPrimo = primo(ref n);

                Console.WriteLine("El numero es " + n);

                if(esPrimo){
                    Console.WriteLine("Si es primo");
                    acuPrimos = acuPrimos + n;
                    Console.WriteLine("El acumulador de primos es " + acuPrimos);
                    contadorPrimos++;
                    Console.WriteLine("El contador de primos es " + contadorPrimos);
                    
                }else{
                    Console.WriteLine("NO es primo");
                }
                

            }
            
            
            promedio = acuPrimos/contadorPrimos;

            Console.WriteLine("El promedio es " + promedio);

        } 

        //Version 1

        static bool primo(ref int n){
            int contadorDividendos = 0, contadorPrimos=0, acumuladorPrimos=0, promedio=0;
            bool esPrimo = true;

            for (int i = 1; i <= n; i++)
            {
                if(n%i==0){
                    contadorDividendos++;
                }
            }
            
            if(contadorDividendos>2){
                esPrimo = false;
            }

            return esPrimo;
        }

        static void pedirNumeros(ref int n){
            Console.WriteLine("Ingrese numeros, para finalizar ingrese 0");
            Console.WriteLine("//////////////////////////////////////////////////////////");
            n = int.Parse(Console.ReadLine());
        }


    }
}
