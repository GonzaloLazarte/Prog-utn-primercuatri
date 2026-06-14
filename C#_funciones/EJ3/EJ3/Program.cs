using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Se requiere un algoritmo para obtener la suma de diez cantidades mediante
//la utilización de un ciclo FOR. Usando dos métodos para resolver el ejercicio.
//El primer método se encargará de solicitar los datos y el segundo método se
//encargará de realizar la suma y el tercero de imprimir la suma.

namespace EJ3 {
    internal class Program {
        private static double sum;
        static void Main(string[] args) {
            int i;
            for (i = 1; i <= 10; i++) {
                suma(solicita(i));
            }
            mostrar();
        }
        static double solicita(int j) {
            double num;
            while (true) {
                Console.WriteLine($"ingrese el {j}° numero: ");
                if (double.TryParse(Console.ReadLine(), out num)) {
                    break;
                }
                else {
                    Console.WriteLine("error datoingresado no valido solo se permiten numeros");
                }
            }
            return num;
        }
        static void suma(double numFunc) {
            sum += numFunc;
        }
        static void mostrar() {
            Console.WriteLine($"el resultado de la suma es {sum}");
        }
    }
}
