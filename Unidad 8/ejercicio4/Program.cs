using System;

namespace ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            /*4. Hacer una función de tipo void (porque no va a devolver nada) llamada “positivoNegativoCero” 
            que reciba un número por valor y una variable por referencia. 
            Que analice el número y escriba variable recibida por referencia con:

            a. 1 si el número es positivo.
            b. -1 si el número es negativo.
            c. 0 si el número es cero.*/


            /*int n=0, natu=3;

            Console.WriteLine("Ingrese un numero");
            n = int.Parse(Console.ReadLine());

            positivoNegativoCero(n,ref natu);

            Console.WriteLine("Caso: " + natu);*/

            int g=10, h=-1, z;

            h+=h;
            Console.WriteLine("En este punto " + h);
            h++;
            Console.WriteLine("En este punto " + h);
            g-=h;
            Console.WriteLine("En este punto " + g);
            z=g;
            Console.WriteLine("En este punto " + z);
            g=5;
            Console.WriteLine("En este punto " + g);
            h=5;
            Console.WriteLine("En este punto " + h);

            Console.WriteLine("El resultado es" + z);




        }

        static void positivoNegativoCero(int n, ref int natu){
            if(n>=1){
                natu = 1;
            }else if (n<=-1)
            {
                natu = -1;
            }else
            {
                natu=0;
            }


        }

    }
}
