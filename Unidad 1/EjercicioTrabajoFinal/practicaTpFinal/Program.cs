using System;

namespace practicaTpFinal
{
    class Program
    {
        static void Main(string[] args)
        {
            // Hacer un programa que permita ingresar una lista de numeros que corte con un cero. A partir de estos datos informar:

            // a. El mayor de los pares 
            // b. La cantidad de impares
            // c. El menor de los primos 

            // Nota: Evaluar el uso de una funcion que analice si un numero es primo o no y devuelva true o false segun corresponda 


            int numero=1, contadorVueltas=0, parAnterior=0, contadorImpares=0, primoAnterior=0, primoMenor=0;
            bool primerPrimo=true;
            Console.WriteLine("Ingrese numeros, para finalizar ingrese un cero");

            while (numero!=0)
            {
                ingresoNumeros(ref numero);

                    if(contadorVueltas==0 && numero%2==0){
                        parAnterior=numero;
                    }
                    
                    if(numero%2==0 && numero>parAnterior){
                        parAnterior = numero;

                    }
                    
                    if(numero%2!=0){
                        contadorImpares++;
                    }
                    
                    if(identificadorPrimos(numero)){
                        Console.WriteLine("Es primo");
                        if(primerPrimo){
                            primoAnterior=numero;
                            primerPrimo=false;
                        }

                        if(numero<primoAnterior){
                            Console.WriteLine("Es un primo menor al anterior");
                            primoAnterior=numero;
                        }

                        
                    }


                contadorVueltas++;
            }
            

            Console.WriteLine("El mayor par fue " + parAnterior);
            Console.WriteLine("La cantidad de impares fue: " + contadorImpares);
            Console.WriteLine("El menor de los primos fue " + primoAnterior);


        }

        static void ingresoNumeros(ref int n){
            n = int.Parse(Console.ReadLine());
            
        }



        static bool identificadorPrimos(int n){
            int divisores=0;

            for (int i = 1; i <= n; i++)
            {
                if(n%i==0){
                    divisores++;
                }
            }

            if(divisores==2){
                return true;
            }else
            {
                return false;
            }
        }



    }
}
