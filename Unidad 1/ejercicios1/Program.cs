using System;

namespace ejercicios1
{
    class Program
    {
        static void Main(string[] args)
        {

            //          Ejercicio 1
            /*int primero, segundo, resul;
            //Escribe en console
            Console.WriteLine("Ingrese un numero");
            //Le indica al programa que lo escrito en consola es un numero entero
            primero = int.Parse(Console.ReadLine());
            //Vuelve a escribir en consola
            Console.WriteLine("Ingrese otro numero");
            //Le indica al programa que lo escrito en consola es un numero entero
            segundo = int.Parse(Console.ReadLine());
            //Suma los dos primeros numeros y el resultado lo asigna a la variable "resul"
            resul = primero + segundo;
            //Escribe el resultado en consola concatenando un texto con la variable "resul"
            Console.WriteLine("La suma de ambos numeros es " + resul); */
            
            //              Ejercicio 2
            /*int num, numCub;
            Console.WriteLine("Ingrese un numero");
            num = int.Parse(Console.ReadLine());
            numCub = num * num * num;
            Console.WriteLine("El cubo del numero ingresado es " + numCub);*/

            //              Ejercicio 3
            
            float dist, vel, tiem;
            Console.WriteLine("Ingrese la distancia entre ciudades en km");
            dist = float.Parse(Console.ReadLine());
            Console.WriteLine("Ahora ingrese la velocidad en km/h");
            vel = float.Parse(Console.ReadLine());
            tiem = dist/vel;
            Console.WriteLine("El tiempo aproximado es " + tiem.ToString("0.0") + " horas"); 

            //              Ejercicio 4
            /*
            int facturado;
            double sueldo;
            Console.WriteLine("Ingrese el monto facturado");
            facturado = int.Parse(Console.ReadLine());
            sueldo = facturado + (facturado * 0.05);
            Console.WriteLine("El total a cobrar es " + sueldo);*/

            //              Ejercicio 5
            /*
            float nota1, nota2, nota3, promedio;
            Console.WriteLine("Ingrese las 3 notas");
            nota1 = int.Parse(Console.ReadLine());
            nota2 = int.Parse(Console.ReadLine());
            nota3 = int.Parse(Console.ReadLine());
            promedio = (nota1+nota2+nota3)/3;
            Console.WriteLine("El promedio es " + promedio); */

        }
    }
}
