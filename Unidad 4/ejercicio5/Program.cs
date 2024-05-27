using System;

namespace ejercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            // 5. Hacer un programa que solicite 20 números 
            //y luego emitir por pantalla el máximo de los números pares y el mínimo de los números impares.

            /* Solucion 1 (Mia):


            int num, maxNum=0, minNum=0;
            Console.WriteLine("Ingrese 20 numeros");
            
            for (int i = 0; i < 5; i++)
            {
                num = int.Parse(Console.ReadLine());
             
                    if(num%2 == 0 && num>maxNum){
                        maxNum = num;
                    }
                    else if(num%2!= 0 && num < minNum)
                    {          
                        minNum = num;
                        
                    }
            }

            Console.WriteLine("El mayor de los pares es " + maxNum +" y el menor de los impares es " + minNum);*/


            //Solucion 2: Planetada por Maxi

            int num=0, max=0, min=0;
            bool faltaPar = true, faltaImpar=true;
            Console.WriteLine("Ingrese 20 numeros");
            
            for (int i = 0; i < 20; i++)
            {
            num = int.Parse(Console.ReadLine());
                if(num%2==0)
                { //Aca discrimino los pares
                    if(faltaPar==true){ //Aca seteo el primer maximo
                        max=num;
                        faltaPar=false;
                    }
                
                    else if(num>max){ //aca reemplazo el maximo si fuera mas grande
                    
                        max = num;
                    }
                }

                if(num%2!=0) //Aca discrimino impares
                { 
                    if(faltaImpar==true){ //Aca seteo el primer numero minimo
                        min=num;
                        faltaImpar=false;
                    }
                    else if(num<min){ //Aca reemplazo el minimo si fuera mas chico
                        min = num;
                    }
                }

            }

                Console.WriteLine("El maximo por es " + max + " y el minimo impar es " + min);

            


        }
    }
}
