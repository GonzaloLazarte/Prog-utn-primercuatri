using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Se les dará un bono por antigüedad a los empleados de una tienda. Si tienen un año, se les dará $100; 
//si tienen 2 años, $200, y así sucesivamente hasta los 5 años. Para los que tengan más de 5, el
//bono será de $1000. Realice un algoritmo para determinar el bono que recibirá un trabajador.

namespace EJ11 {
    internal class Program {
        static void Main(string[] args) {

            int antiguedad = 0;
            double  bono = 0;
            bool val, i = true;

            Console.WriteLine("=================CALCULADORA DE BONOS==================");
            Console.WriteLine();

            while (i) {
                Console.Write("ingrese la antiguedad del trabajador en años: ");

                if (int.TryParse(Console.ReadLine(), out antiguedad) && antiguedad > 0) {
                    if (antiguedad <= 5) {
                        bono = antiguedad * 100;
                    }
                    else {
                        bono = 1000;
                    }
                    break;
                }
                else {
                    Console.WriteLine("Porfavor ingrese un valor de antiguedad valido");
                    Console.WriteLine("");
                }
            }
            Console.WriteLine($"el bono para el trabajador con antiguedad de {antiguedad} años es de: ${bono}");

        }
    }
}
