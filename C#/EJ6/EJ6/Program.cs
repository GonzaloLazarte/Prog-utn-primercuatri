using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Determinar el costo y el descuento que tendrá un artículo. Considere que si su precio
//es mayor o igual a $200 se le aplica un descuento del 15%, y su precio es mayor a $100
//pero menor a $200, el decuento es de 12%, y si es menor a $100, sólo 10%

namespace EJ6 {
    internal class Program {
        static void Main(string[] args) {

            double precioArt, descuento, precioDescuento;
            string nombreDesc;

            Console.WriteLine("================ descuentos de productos ================");
            Console.Write("ingrese el precio del articulo: $");
            precioArt = double.Parse(Console.ReadLine());

            if (precioArt >= 200) {
                descuento = precioArt * 0.15;
                precioDescuento = precioArt - descuento;
                nombreDesc = "15%";
            }
            else if (precioArt >= 100 && precioArt < 200) {
                descuento = precioArt * 0.12;
                precioDescuento = precioArt - descuento;
                nombreDesc = "12%";
            }
            else {
                descuento = precioArt * 0.1;
                precioDescuento = precioArt - descuento;
                nombreDesc = "10%";
            }

            Console.WriteLine($"el costo es: ${precioArt} y el descuento aplicado es de {nombreDesc} = ${descuento}");
            Console.WriteLine($"el precio final con descuento aplicado es de: ${precioDescuento}");

        }
    }
}
