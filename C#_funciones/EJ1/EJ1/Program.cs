using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Se requiere un algoritmo para obtener la suma de diez cantidades mediante
//la utilización de un ciclo "Mientras". Usar Métodos para resolver el ejercicio.

namespace EJ1 {
    internal class Program {
        static void Main(string[] args) {
            double sum = 0;
            int i = 1;
            while (i <= 10) {
                sum = suma(sum);
                i++;
            }


            Console.WriteLine($"{sum}");
        }
        static Double suma(double ant) {
            double num, result = ant; 
            while (true) {
                Console.WriteLine("ingrese un numero para sumar");
                if (double.TryParse(Console.ReadLine(), out num)) {
                    result += num;
                    break;
                }
                else {
                    Console.WriteLine("error, debe ingresar un numero");
                }
            }
            return result;
        }

    }
}
