using System;

namespace ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*2. Hacer una función llamada “par” que reciba un número entero y devuelva 1 si es par o cero si no lo es. 
            Hacer un programa para ingresar 20 números y mostrar por pantalla cuántos son pares.*/



            // Solucion mia:

            /*int n=0, resul=5, contPares=0;


            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine("Ingrese 20 numeros");
                resul = parOImpar(n);

                if(resul==1){
                    contPares++;
                }

            }
            
            Console.WriteLine("Hay " + contPares + " numeros pares");*/



            // Solucion de maxi:

            int n=0, contPares=0;

            Console.WriteLine("Ingrese un numero");

            

            for (int i = 0; i < 5; i++)
            {
                n = int.Parse(Console.ReadLine());
                if(parOImpar(n)){
                    contPares++;
                }
            }
            Console.WriteLine("Hay " + contPares + " numeros pares");
        }


        // Solucion mia:

        /*static int parOImpar(int n){
            int resul=3;
            n = int.Parse(Console.ReadLine());
            if(n%2==0){
                resul = 1;
            }else{
                resul = 0;
            }
            return resul;
            
            }*/
                



            //Solucion de maxi:

            static bool parOImpar(int n){
                if(n%2==0){
                    return true;
                }else
                {
                    return false;
                }
            }


        
    }
}
