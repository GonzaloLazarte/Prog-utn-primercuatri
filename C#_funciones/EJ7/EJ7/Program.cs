using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Se requiere un algoritmo para determinar, de N cantidades, cuántas son
//menores o iguales a cero y cuántas mayores a cero. Resolver el ejercicio utilizando métodos como
//crea conveniente

namespace EJ7 {
    internal class Program {
        static int mayores = 0, iguales = 0, menores = 0;
        static void Main(string[] args) {
            int N = 0;
            N = ingresarCant();
            contarCant(N);
            mostrarCant();
        }
        static int ingresarCant() {
            int numero = 0;
            while (true) {
                Console.Clear();
                Console.Write("INGRESE LA CANTIDAD DE NUMEROS A COMPARAR:  ");
                if (int.TryParse(Console.ReadLine(), out numero)) {
                    break;
                }
                else {
                    Console.WriteLine("el dato debe ser un numero intente de nuevo");
                }
            }
            return numero;
        }
        static void contarCant(int _N) {
            for (int i = 1; i <= _N; i++) {
                Console.WriteLine($"ingresar el: {i}° numero");
                ingresarSeparar();
            }
        }
        static void ingresarSeparar() {
            double num = 0;
            while (true) {
                if (double.TryParse(Console.ReadLine(), out num)) {
                    break;
                }
                else {
                    Console.WriteLine("solo se pueden comparar numeros");
                }
            }
            if (num > 0) {
                mayores++;
            }
            else if (num < 0) {
                menores++;
            }
            else {
                iguales++;
            }
        }
        static void mostrarCant() {
            Console.WriteLine("================RESULTADOS==================");
            Console.WriteLine($"numeros mayores a cero: {mayores}");
            Console.WriteLine($"numeros iguales a cero: {iguales}");
            Console.WriteLine($"numeros menores a cero: {menores}");
        }
    }
}
