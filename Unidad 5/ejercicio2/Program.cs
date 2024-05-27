using System;

namespace ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Les dejo algunos ejercicios de ciclos combinados. Ya son un poco más largos y complejos, así que serán menos así tratan de hacerlos 
            en la semana. Lo que sí, analicen bien ya que tendrán que determinar qué tipo de combinación de ciclos deben aplicar, es decir, 
            si for con for, o for con while, etc.

            1. Hacer un programa para ingresar 10 números. El mismo debe analizar y mostrar por pantalla cuántos de esos números son primos.

            2. Se dispone de una lista de 5 listas de números enteros separados entre ellos por ceros. Se pide determinar e informar:

            El número de grupo con mayor porcentaje de números impares respecto al total de números que forman el grupo.
            Informar cuántos grupos están formados por todos números ordenados de mayor a menor.
            
            3. Hacer un programa para recibir listas de números positivos que están separadas entre sí por un cero. 
            El fin de la carga se notifica con un número negativo. Luego mostrar cuántos números tiene cada lista.
            */

           /*int n=1, numGrup=0, gruposOrdenados=0, contNumsGrupo=0, contMayoresAMenores=0, nAnterior=999999;

            Console.WriteLine("Ingrese la primera lista de numeros, cuando quiera cambiar de lista ingrese un 0. Son 5 listas");

           for (int i = 0; i < 5; i++)
           {
            n=1; // Para que se reinicie n en cada ciclo del for y vuelva a ingresar en el while de abajo
            numGrup++; //Cuento los numeros de grupo
            contNumsGrupo=0; //Seteo la cantidad de numeros de cada grupo a cero denuevo
            contMayoresAMenores=0; //Seteo esta variable bandera a cero denuevo
            nAnterior=999999; // Seteo esta bandera a cero denuevo, si se ingresan solo numeros mayores a este no va a funcionar, hay que solucionar

            while (n!=0)
            {
                n = int.Parse(Console.ReadLine());
                contNumsGrupo++;
                if(n<nAnterior){
                    contMayoresAMenores++;
                    nAnterior = n;
                }

            }

            Console.WriteLine("Eso fue el grupo " + numGrup);

            if(contMayoresAMenores==contNumsGrupo){
                //Console.WriteLine("Se ingresaron de mayor a menor");
                gruposOrdenados++;
            }

            }

            Console.WriteLine("Se ingresaron " + gruposOrdenados + " grupos ordenados de mayor a menor");*/




            int n=1, numGrup=0, gruposOrdenados=0, contMayoresAMenores=0, nAnterior=999999;
            float porcentajeImpares=0, contadorImpares=0, contNumsGrupo=0, porcentajeMaximo=-1, grupoImparesMaximo=0;


            Console.WriteLine("Ingrese la primera lista de numeros, cuando quiera cambiar de lista ingrese un 0. Son 5 listas");

           for (int i = 0; i < 5; i++) //Ciclo que me diferencia las listas
           {
            n=1; // Para que se reinicie n en cada ciclo del for y vuelva a ingresar en el while de abajo
            numGrup++; //Cuento los numeros de grupo
            contNumsGrupo=0; //Seteo la cantidad de numeros de cada grupo a cero denuevo
            contMayoresAMenores=0; //Seteo esta variable bandera a cero denuevo
            nAnterior=999999; // Seteo esta bandera a 999999 denuevo, si se ingresan solo numeros mayores a este no va a funcionar, hay que solucionar
            contadorImpares=0;//Seteo el contador de pares a cero por cada lista
            

            Console.WriteLine("Ingrese el grupo " + numGrup);

            while (n!=0) //Ciclo para ingresar lista  
            {
                
                n = int.Parse(Console.ReadLine());
                contNumsGrupo++;
               
                if(n<nAnterior){ // If con contadores auxiliares para saber si está todo ordenado de mayor a menor 
                    contMayoresAMenores++;
                    nAnterior = n;
                }

                if(n%2!=0){ //Verifico si el numero ingresado es impar
                    contadorImpares++;
                    
                }
            }


            porcentajeImpares = contadorImpares/contNumsGrupo*100;

            if(porcentajeImpares>porcentajeMaximo){
                    porcentajeMaximo = porcentajeImpares;
                    grupoImparesMaximo = numGrup;
            }

          


            if(contMayoresAMenores==contNumsGrupo){
                //Console.WriteLine("Se ingresaron de mayor a menor");
                gruposOrdenados++;
            }


            }

          
            
            Console.WriteLine("El grupo con mas porcentaje de impares fue el grupo " + grupoImparesMaximo);
            Console.WriteLine("Se ingresaron " + gruposOrdenados + " grupos ordenados de mayor a menor");
            






























        }
    }
}
