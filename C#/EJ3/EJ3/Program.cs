using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//El 14 de febrero una persona desea comprarle un regalo al ser querido que más aprecia en ese
//momento, su dilema radica en qué regalo puede hacerle, las alternativas que tiene son las siguientes
//Regalo			Costo
//Tarjeta			$10.00 o menos
//Chocolates		$11.00 a $100.00
//Flores			$101.00 a $250.00
//Anillo			Más de $251.00
//Se requiere determinar qué regalo se le puede comprar a ese ser tan especial por el día
//del amor y la amistad.

namespace EJ3 {
    internal class Program {
        static void Main(string[] args) {
            double dineroDisp;

            Console.WriteLine("=============== OPCION DE REAGALO ===============");
            Console.WriteLine("Regalo			Costo");
            Console.WriteLine("Tarjeta			$10.00 o menos");
            Console.WriteLine("Chocolates		$11.00 a $100.00");
            Console.WriteLine("Flores			$101.00 a $250.00");
            Console.WriteLine("Anillo			Más de $251.00");
            Console.WriteLine(" ");
            Console.Write("ingrese su monto disponible:   ");
            dineroDisp = double.Parse(Console.ReadLine());
            // nota mental, los decimales que entran por consola deben usarse con , si usamos . el parse borra el punto
            //dentro del programa osea del lenguaje los decimales si se especifican con . 
            if (dineroDisp > 251.00) {
                Console.WriteLine("le alcanza para comprar un anillo u otro objeto de menor valor");
            }
            else if (dineroDisp >= 101.00 && dineroDisp < 251.00) {
                Console.WriteLine("le alcanza para comprar flores u otro objeto de menor valor");
            }
            else if (dineroDisp >= 11.00 && dineroDisp < 101.00) {
                Console.WriteLine("le alcanza para comprar chocolares u otro objeto de menor valor");
            }
            else {
                if (dineroDisp > 0 && dineroDisp <= 11.00) {
                    Console.WriteLine("le alcanza para comprar una tarjeta");
                }
                else {
                    Console.WriteLine("debe tener dinero para poder comprar");
                }
            }
            Console.ReadKey();//este recorda solo es para detener el programa 
        }
    }
}
