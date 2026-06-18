using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Se requiere un algoritmo para obtener la edad promedio de un grupo de N
//alumnos. El valor de N se ingresará por teclado. Usar Métodos para resolver el
//ejercicio.


namespace EJ4 {
    internal class Program {
        private static double prom = 0;
        private static void Main(string[] args) {
            int num = 0, sum = 0;

            Console.WriteLine("==================PROMEDIO DE ALUMNOS==================");
            while (true) {
                Console.WriteLine("ingrese la cantidad de alumnos:");
                if (int.TryParse(Console.ReadLine(), out num) && num > 0) {
                    for (int i = 1; i <= num; i++) {
                        sum += edadalumno(i);
                    }
                    promedio(sum, num);
                    break;
                }
                else {
                    Console.WriteLine("ingrese una cantidad valida");
                }
            }
            Console.WriteLine($"el promedio de edad de {num} alumnos es: {prom}");
            Console.ReadKey();
        }
        static int edadalumno(int j) {
            int edad;
            while (true) {
                Console.WriteLine($"ingrese la edad del {j}° alumno");
                if (int.TryParse(Console.ReadLine(), out edad) && edad > 0) {

                    break;
                }
                else {
                    Console.WriteLine("ingrese un dato de edad valido");
                }
            }
            return edad;
        }
        static void promedio(double _sum, double _num) {
            prom = _sum / _num;
        }

    }
}
