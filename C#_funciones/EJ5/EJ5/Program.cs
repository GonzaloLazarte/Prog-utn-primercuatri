using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Se requiere un algoritmo para obtener la estatura promedio de un grupo
//de personas, cuyo número de miembros se desconoce, el ciclo debe
//efectuarse siempre y cuando se tenga una estatura registrada. Resolver el ejercicio
//usando los métodos que considere necesarios.

namespace EJ5 {
    internal class Program {
        private static double promEst = 0, sum = 0;
        private static int k = 0;
        static void Main(string[] args) {
            string opc = string.Empty;

            opcion(opc);

        }
        static void menu() {
            Console.Clear();
            Console.WriteLine("================================ PROMEDIO DE ESTATURAS ================================");
            Console.WriteLine($"Promedio de estaturas: {promEst}");
            Console.WriteLine("================================ SELECCIONAR OPCION ================================");
            Console.WriteLine("");
            Console.WriteLine("1) INGRESAR ESTATURA");
            Console.WriteLine("0) SALIR");
        }
        static void mostrar() {
            Console.WriteLine("");
        }
        static void opcion(string _opc) {
            while (true) {
                menu();
                while (true) {
                    _opc = Console.ReadLine();
                    if (_opc == "1") {
                        cargarAltura();
                        break;
                    }
                    else if (_opc == "0") {
                        break;
                    }
                    else {
                        Console.Clear();
                        Console.WriteLine("parameto no valido porfavor ingrese una opcion valida");
                        Console.WriteLine("1) INGRESAR ESTATURA");
                        Console.WriteLine("0) SALIR");
                    }
                }
            }
        }
        static void cargarAltura() {
            double alt = 0;
            while (true) {
                Console.Write("INGRESAR UN NUEVO VALOR DE ALTURA: ");
                if (double.TryParse(Console.ReadLine(), out alt) && alt > 0) {
                    sum += alt;
                    k++;
                    calcularProm();
                    break;
                }
                else {
                    Console.WriteLine("INGRESE UN DATO VALIDO");
                }
            }
        }
        static void calcularProm() {
            promEst = sum / k;
        }

    }
}
