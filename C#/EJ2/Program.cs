using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Realice un Algoritmo para determinar el sueldo semanal de un trabajador
//con base en la horas trabajadas y el pago por hora, considerando que
//después de las 40 horas cada hora se considera como excedente y se
//paga el doble

namespace EJ2 {
    internal class Program {
        static void Main(string[] args) {
            int horas;
            double sueldo, extra, pagoHora;

            Console.WriteLine("==================== DETERMINAR SUELDO SEMANAL ====================");
            Console.Write("ingrese las horas trabajadas: ");
            horas = int.Parse(Console.ReadLine());
            Console.Write("ingrese el pago por hora: ");
            pagoHora = double.Parse(Console.ReadLine());

            if (horas > 40) {
                extra = ((horas - 40)*pagoHora) * 2;
                sueldo = (40 * pagoHora) + extra;
            }
            else {
                sueldo = horas * pagoHora;
            }
            Console.WriteLine($"el sueldo semanal sera de: ${sueldo}");

        }
    }
}
