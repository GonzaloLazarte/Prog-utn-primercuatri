using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Realice un algoritmo que permita determinar el sueldo semanal de un trabajador con base 
//en las horas trabajadas y el pago por hora, considerando que a partir de la hora número 41 
//y hasta la 45, cada hora se le paga el doble, de la hora 46 a la 50, el triple, y que trabajar
//más de 50 horas no está permitido. 

namespace EJ12 {
    internal class Program {
        static void Main(string[] args) {
            double pagohora = 0, sueldo = 0;
            int horas = 0;

            while (true) {
                Console.Write("porfavor ingrese las horas trabajadas: ");
                if (int.TryParse(Console.ReadLine(), out horas) && horas > 0) {
                    while (true) {
                        Console.Write("porfavor el pago por hora: $");
                        if (double.TryParse(Console.ReadLine(), out pagohora) && pagohora > 0) {
                            if (horas >= 41 && horas <= 45) {
                                sueldo = horas * (pagohora * 2);
                            }
                            else if (horas >= 46 && horas <= 50) {
                                sueldo = horas * (pagohora * 3);
                            }
                            else if (horas > 50) {
                                sueldo = 0;
                                Console.WriteLine("No esta permitido trabajar mas de 50 horas");
                            }
                            else {
                                sueldo = horas * pagohora;
                            }
                            break;
                        }
                        else {
                            Console.WriteLine("ingrese un valor valido");
                        }
                    }
                    break;   
                }
                else {
                    Console.WriteLine("ingrese un valor valido");
                }
            }
            Console.WriteLine("================== SUELDO SEMANAL ======================");
            Console.WriteLine($"El sueldo semanal para el trabajador con {horas} horas es de: ${sueldo}");
        }
    }
}
