using System;

namespace ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            // 2. Hacer un programa que solicite 10  números enteros y los guarde en un vector. 
            // Luego recorrer ese vector para calcular el promedio. Mostrar por pantalla los valores que son mayores al promedio.

            int num=0, numsVector=0, suma=0, cont=0, promedio=0, contMay=0, indice=0; 
            int[] vector = new int[10];
            int[] mayores = new int[10];

            Console.WriteLine("Ingrese 10 numeros");

            // Carga numeros en el vector
            for (int i = 0; i < 10; i++)
            {
                num = int.Parse(Console.ReadLine());
                vector[i] = num;
                
            }

            // Itera el vector y saca el promedio          
            for (int x = 0; x < 10; x++)
            {
                numsVector = vector[x];
                suma+= numsVector;
                cont++;
                promedio=suma/cont;
            }



            // itera el vector y saca los mayores al promedio
            for (int y = 0; y < 10; y++)
            {
                
                if(vector[y]>promedio){
                    mayores[indice] = vector[y];
                    indice++;
                    contMay++;
                }

            }


            //Punto 1
            Console.WriteLine("El promedio es: " + promedio);

            //Punto 2
            Console.WriteLine("Los mayores al promedio son: ");
            for (int z = 0; z < contMay; z++)
            {
                Console.WriteLine(mayores[z]);
            }
            






        }
    }
}
