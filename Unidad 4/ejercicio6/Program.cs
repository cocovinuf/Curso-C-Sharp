using System;

namespace ejercicio6
{
    class Program
    {
        static void Main(string[] args)
        {
            // Hacer un programa que solicite dos numeros y luego muestre los numeros entre el menor y el mayor de ellos 

            float n1=0, n2=0, intermedios=0;
            Console.WriteLine("Ingrese dos numeros distintos");
            n1 = float.Parse(Console.ReadLine());
            n2 = float.Parse(Console.ReadLine());
            

            if(n1>n2){
                while (intermedios<(n1-1)){
                    intermedios = n2+1;
                    Console.WriteLine(intermedios);
                    n2=intermedios;                
                }
            }
            else
                while (intermedios<(n2-1)){
                    intermedios = n1+1;
                    Console.WriteLine(intermedios);
                    n1=intermedios;
                }
            
            
            
        
  
                        

        }
    }
}
