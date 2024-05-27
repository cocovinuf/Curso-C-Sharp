using System;

namespace ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            //3. Hacer un programa que solicite 20 edades y luego calcule el promedio de edad de aquellas personas mayores a 18 años.

            int edad, cantEdades=0, sumaEdades=0;

            Console.WriteLine("Ingrese 20 edades");

            for (int i = 0; i < 20; i++)
            {
            edad = int.Parse(Console.ReadLine()); 
                if(edad>18)
                {
                    sumaEdades+=edad;
                    cantEdades++;
                }
            
            }
            if(sumaEdades==0){
                Console.WriteLine("Ninguna edad ingresada es mayor a 18");
            }else{
                Console.WriteLine("El promedio de edad de los mayores de 18 es " + (sumaEdades/cantEdades));
            }
            

        }
    }
}
