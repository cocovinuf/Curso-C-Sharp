﻿using System;

namespace ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 3. Hacer un programa que solicite una cadena de caracteres y dos caracteres sueltos (tres ingresos). 
            El programa deberá generar una cadena donde todas las ocurrencias del primer carácter dado hayan sido reemplazadas por el segundo. 
            Mostrar el resultado en pantalla. Ejemplo:
            CADENA FUENTE: “La mar estaba serena"
            CARÁCTER 1: ‘a’ CARÁCTER 2: ‘i’
            CADENA RESULTADO: “Li mir estibi sereni"*/


            /*
            char[] frase = new char[30];
            int indice = 0;
            char letraNueva, letraVieja;

            Console.WriteLine("Ingrese la frase letra por letra");
            char letra = char.Parse(Console.ReadLine()); 

            while (letra!= '0' && indice<30)
            {
                frase[indice] = letra;
                letra = char.Parse(Console.ReadLine()); 
                indice++;
            }
            frase[indice] = '\0';
            indice = 0;

            Console.WriteLine("Usted ingreso: ");
    
            while (frase[indice]!='\0')
            {
                Console.Write(frase[indice]);
                indice++;
            }
            
            Console.WriteLine("Ingrese letra a reemplazar");
            letraVieja = char.Parse(Console.ReadLine());
            
            Console.WriteLine("Ingrese letra nueva ");
            letraNueva = char.Parse(Console.ReadLine());

            indice = 0;
            while (frase[indice]!='\0')
            {
               if(frase[indice]==letraVieja){
                frase[indice] = letraNueva;
               }
               indice++;
            }

            indice=0;
            Console.WriteLine("Finalmente queda: ");

            while (frase[indice]!='\0')
            {
                Console.Write(frase[indice]);
                indice++;
            }
            */


            string frase;
            char letraVieja, letraNueva;

            Console.WriteLine("Ingrese la frase");
            frase = Console.ReadLine();

            Console.WriteLine("Ingrese la letra a reemplazar");
            letraVieja = char.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese la letra a nueva");
            letraNueva = char.Parse(Console.ReadLine());

            frase = frase.Replace(letraVieja, letraNueva);

            Console.WriteLine("Su frase es: " + frase);


     
        }
    }
}
