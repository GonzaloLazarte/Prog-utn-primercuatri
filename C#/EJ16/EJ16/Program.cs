using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//El secretario de educación ha decidido otorgar un bono por desempeño
//a todos los profesores con base en la puntuación siguiente:
//Puntos				Premio
//0-100					1 salario
//101-150				2 salarios mínimos
//151-en adelante		3 salarios mínimos
//Realice un algoritmo que permita determinar el monto de bono que
//percibirá un profesor (debe capturar el valor del salario mínimo
//y los puntos del profesor)

namespace EJ16 {
    internal class Program {
        static void Main(string[] args) {
            int puntos = 0;
            double sal = 0, bon = 0;

            Console.WriteLine("===================SISTEMA DE BONOS PARA LOS PROFESORES===================");
            while (true) {
                Console.Write("ingrese el monto del salario minimo: $");
                if (double.TryParse(Console.ReadLine(), out sal) && sal > 0) {
                    while (true) {
                        Console.Write("ingrese la cantidad de puntos que tiene el profesor: ");
                        if (int.TryParse(Console.ReadLine(), out puntos) && puntos >= 0) {
                            if (puntos >= 0 && puntos <= 100) {
                                bon = 1 * sal;
                            }
                            else if (puntos >= 101 && puntos <= 150) {
                                bon = 2 * sal;
                            }
                            else {
                                bon = 3 * sal;
                            }
                            break;
                        }
                        else {
                            Console.WriteLine("ingrese un numero mayor o igual a cero para la cantidad de puntos");
                        }
                    }
                    break;
                }
                else {
                    Console.WriteLine("ingrese un monto mayor a cero para el monto del salario minimo");
                }
            }
            Console.WriteLine("======================= RESULTADOS ===========================");
            Console.WriteLine($"el salario minimo es de {sal}");
            Console.WriteLine($"el profesor con {puntos} le corresponde un bono de: ${bon}");
        }
    }
}
