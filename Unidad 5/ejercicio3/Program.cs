using System;

namespace ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            //3. Hacer un programa para recibir listas de números positivos que están separadas entre sí por un cero. 
            //El fin de la carga se notifica con un número negativo. Luego mostrar cuántos números tiene cada lista.

            // numList: El numero de lista que se está ingresando
            // num: El numero que va a conformar parte de la lista
            // cantList: La cantidad de numeros que tiene cada lista

           /* int n=1, numList=0, cantList=-1;
            bool sigue=true;

            Console.WriteLine("Ingrese las listas separadas por 0, cuando no quiera ingresar mas listas ingrese -1");        

            while (sigue)
            {
                n=1;
                numList++;
                Console.WriteLine("Lista nº " + numList);

                while (n!=0 && n>0){      
                    n = int.Parse(Console.ReadLine());       
                    cantList++;         

                    if(n<0)
                    {
                        sigue=false;
                        
                    }


                }             
               
            }       
                
            Console.WriteLine("La lista tiene " + cantList + " numeros");*/
            

            

            //3. Hacer un programa para recibir listas de números positivos que están separadas entre sí por un cero. 
            //El fin de la carga se notifica con un número negativo. Luego mostrar cuántos números tiene cada lista.



            int n=1, numList=0, cantList=0;
            bool sigue=true;

            Console.WriteLine("Ingrese las listas separadas por 0, cuando no quiera ingresar mas listas ingrese -1");        

            while (sigue)
            {
                n=1;
                numList++;
                Console.WriteLine("Lista nº " + numList);
                cantList=-1;

                while (n!=0 && n>0) // Carga las listas hasta que aparece un negativo
                {      
                    n = int.Parse(Console.ReadLine());       
                           

                    if(n<0)
                    {
                        sigue=false;
                        
                    }else
                    {
                        cantList++;  
                    }
                }             
               
               Console.WriteLine("La lista " + numList+ " tiene " + cantList + " numeros");

            }       
                
            
            









        }
    }
}
