using System;

namespace ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 4. Una empresa comercializa 15 tipos de artículos y por cada venta realizada genera un registro con los siguientes datos:
            - Número de Artículo (1 a 15)
            - Cantidad Vendida 

            Puede haber varios registros para el mismo artículo y el último se indica con número de artículo igual a 0.
            Se pide determinar e informar:
            a) El número de artículo que más se vendió en total.
            b) Los números de artículos que no registraron ventas.
            c) Cuantas unidades se vendieron del número de artículo 10. */


            
            
            int[] listaVentas= new int[16];
            int numArt = 0, cantidadVendida=0, numeroAnterior=0, artMasVen=0;
            bool sigue=true;
            
            
            while (sigue){
                Console.WriteLine("Ingrese el Nº de artículo");      
                numArt = int.Parse(Console.ReadLine());

                if(numArt!=0){       
                    Console.WriteLine("¿Cuanto vendió?");           
                    cantidadVendida = int.Parse(Console.ReadLine());
                    listaVentas[numArt] = listaVentas[numArt]+ cantidadVendida;
                }else{
                       
                    sigue=false;
                }
            }          

            //Consigna 1:
            numeroAnterior = listaVentas[1];

            for (int i = 1; i < 16; i++)
            {
                if(listaVentas[i]>numeroAnterior){
                    artMasVen = i;
                    numeroAnterior = listaVentas[i];
                }
            }
            Console.WriteLine("El artículo mas vendido fue el " + artMasVen);



            // Consigna 2:
            int[] sinVentas= new int[16];
            int a = 0;
            for (int x = 0; x < 16; x++)
            {

            if(listaVentas[x]==0){
                sinVentas[a] = x;
                a++; 
            }

            }
            Console.WriteLine("Los artículos sin ventas fueron: ");
            for (int y = 1; y < a; y ++)
            {
                Console.Write(sinVentas[y]);
                Console.Write(" ");
            }
            
            Console.WriteLine(" ");






            // Consigna 3:
            Console.WriteLine("Del artículo 10 se vendieron " + listaVentas[10] + " unidades");



        }
    }
}
