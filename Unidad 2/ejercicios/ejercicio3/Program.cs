﻿using System;

namespace ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Una casa de video juegos otorga un descuento dependiendo del importe de la compra realizada según los siguientes valores:

            Si el importe es menor a ARS 1000, no hay descuento.
            Si el importe es ARS 1000 o más pero menor a ARS 5000, aplica un descuento del 10%.
            Si el importe es ARS 5000 o más, aplica un descuento del 18%.
            Hacer un programa para ingresar un importe de venta y luego muestre por pantalla el importe final con el descuento que corresponda.*/

            float importe, importeDescontado = 0;
            Console.WriteLine("Ingrese el importe");
            importe = float.Parse(Console.ReadLine());

            if (importe < 1000){
                importeDescontado = importe;
            }
            else if (importe >= 1000 && importe < 5000){;
                importeDescontado = importe * 0.9F;
            }
            else if (importe >= 5000){
                importeDescontado = importe * 0.82F;
            }

            Console.WriteLine("El importe a cobrar es " + importeDescontado);
        }
    }
}
