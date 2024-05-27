using System;

namespace ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. Hacer un programa para ingresar 10 números. El mismo debe analizar y mostrar por pantalla cuántos de esos números son primos.

            float numero, contadorNoPrimos=0, contadorPrimos=0, noPrimos=0, primos=0;
            Console.WriteLine("Ingrese 10 numeros");    
            

                for (int x = 0; x < 10; x++)
                {
                contadorNoPrimos=0;
                contadorPrimos=0;

                numero = float.Parse(Console.ReadLine());
                    
                for (int i = 1; i <= numero; i++)
                    {
                        if (numero%i == 0){
                            contadorNoPrimos++;
                            
                        }
                        else{
                            contadorPrimos++;
                            
                        }
                    }
                    
                if(contadorNoPrimos>2){
                    //Console.WriteLine("NO es primo");
                    noPrimos++;
                }
                else{
                    //Console.WriteLine("SI es primo");
                    primos++;
                }

                }
                
                   
                

                
                    
            
                Console.WriteLine("Usted ingreso " + primos + " numeros primos");

            
            
                
                    




            

        }
    }
}
