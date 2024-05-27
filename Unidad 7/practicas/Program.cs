using System;

namespace practicas
{
    class Program
    {
        static void Main(string[] args)
        {
            
            bool[] siOno = new bool[11];
            int n;

            Console.WriteLine("Ingrese la lista de 10 datos booleanos, 1= true 0=false");
            for (int x  = 0; x < 10; x++)
            {
                n = int.Parse(Console.ReadLine());
                if(n==1)
                    siOno[x] = true;
                else if(n==0)
                {
                    siOno[x] = false;
                }
                else
                {
                    Console.WriteLine("ERROR, INGRESE 1 O 0");
                    x--;
                }
               
            }
            



            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(siOno[i]);
            }
            

        }
    }
}
