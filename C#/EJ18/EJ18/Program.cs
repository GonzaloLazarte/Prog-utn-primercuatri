using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Realice un algoritmo que permita determinar la cantidad del bono navideño 
//que recibirá un empleado de una tienda, considerando que si su antigüedad 
//es mayor a cuatro años o su sueldo es menor de dos mil pesos, le corresponderá 
//25 % de su sueldo, y en caso contrario sólo le corresponderá 20 % de éste.

namespace EJ18 {
    internal class Program {
        static void Main(string[] args) {
            int ant = 0;
            double sueldo, bono;

            Console.WriteLine("====================BONOS NAVIDEÑOS=====================");
            do {
                Console.Write("ingrese la antiguedad del empleado en años: ");
                if (int.TryParse(Console.ReadLine(), out ant) && ant > 0) {
                    break;
                }
                else {
                    Console.WriteLine("ingrese un valor para la antiguedad valido");
                }
            }
            while (true);
            do {
                Console.Write("ingrese el salario del empleado: ");
                if (double.TryParse(Console.ReadLine(), out sueldo) && sueldo > 0) {
                    break;
                }
                else {
                    Console.WriteLine("ingrese un valor para la antiguedad valido");
                }
            }
            while (true);

            if (ant > 4 || sueldo < 2000) {
                bono = sueldo * 0.25;
            }
            else {
                bono = sueldo * 0.20;
            }

            Console.WriteLine("======================RESULTADOS======================");
            Console.WriteLine($"para un empleado con una antiguedad de {ant} años y un sueldo de ${sueldo} le corresponde un bono extra de ${bono}");

        }
    }
}
