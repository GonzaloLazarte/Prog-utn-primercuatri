using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//El dueño de un estacionamiento requiere determinar cuánto debe cobrar por el uso del estacionamiento a sus
//clientes.Las tarifas son las siguientes:
//Las dos primeras horas a $5 c/u
//Las siguientes tres a $4 c/u
//Las cincos siguientes a $3 c/u
//Después de diez horas el costo por cada una es de dos pesos.

namespace EJ4 {
    internal class Program {
        static void Main(string[] args) {

            int horas;
            double cobro;

            Console.WriteLine("=================== ESTACIONAMIENTO =====================");
            Console.Write("Ingrese el tiempo que se va a quedar: ");
            horas = int.Parse(Console.ReadLine());
            if (horas > 0) {
                if (horas <= 2) {
                    cobro = horas * 5;
                }
                else if (horas <= 5) {
                    cobro = (2 * 5) + ((horas - 2) * 4);
                }
                else if (horas <= 10) {
                    cobro = (2 * 5) + (3 * 4) + ((horas - 5) * 3);
                }
                else {
                    cobro = (2 * 5) + (3 * 4) + (5 * 3) + ((horas - 10) * 3);
                }
                Console.WriteLine($"el monto a cobrar por estacionar {horas} horas es de: ${cobro}");
            }
            else {
                Console.WriteLine("debe ingresar una cantidad de horas valida");
            }
        }
    }
}
