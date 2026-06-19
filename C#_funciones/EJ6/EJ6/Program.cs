using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Se requiere un algoritmo para determinar cuánto ahorrará una persona
//en un año, si al final de cada mes deposita variables cantidades de dinero;
//además, se requiere saber cuánto lleva ahorrado cada mes. Resolver el ejercicio usando los
//métodos que considere necesarios.  

namespace EJ6 {
    internal class Program {
        static void Main(string[] args) {
            
            double sumaDinero = sumarMeses();

            Console.WriteLine($"el monto total ahorrado durante un año es de: ${sumaDinero}");
        }
        static double sumarMeses() {
            double sumaMes = 0;
            for (int i = 1; i <= 12; i++) {
                Console.WriteLine($"INGRESE EL MONTO DE DINERO PARA EL MES {i}");
                sumaMes += validarMonto();
                Console.WriteLine($"El monto ahorrado hasta el mes {i} es de ${sumaMes}");
            }
            return sumaMes;
        }
        static double validarMonto() {
            double numero = 0;
            while (true) {
                if (double.TryParse(Console.ReadLine(), out numero) && numero >= 0) {
                    break;
                }
                else {
                    Console.WriteLine("ingrese un valor valido ");
                }
            }
            return numero;
        }
    }
}
