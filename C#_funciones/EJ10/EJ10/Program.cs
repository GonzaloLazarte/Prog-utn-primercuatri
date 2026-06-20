using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Una empresa tiene el registro de las horas que trabaja diariamente un
//empleado durante la semana (seis días) y requiere determinar el total de
//éstas, así como el sueldo que recibirá por las horas trabajadas.

namespace EJ10 {
    internal class Program {
        static double pagoHora = 0;
        static void Main(string[] args) {
            double sueldo = 0;
            int horasSemanales = 0;
            Console.WriteLine("=============CALCULADORA DE SUELDO SEMANAL=============");
            definirPago();
            horasSemanales = solicitarDatos();
            sueldo = sueldoSemana(horasSemanales);

            Console.WriteLine("============= RESULTADOS DE SUELDO =============");
            Console.WriteLine($"PAGO POR HORA: ${pagoHora}");
            Console.WriteLine($"HORAS TRABAJADAS SEMANALMENTE: {horasSemanales} hs.");
            Console.WriteLine($"SUELDO SEMANAL CORRESPONDIENTE: ${sueldo}");
            Console.WriteLine("================================================");

        }
        static int solicitarDatos() {
            int horaTotal = 0, hora = 0;
            while (true) {
                Console.WriteLine("PORFAVOR INGRESE LAS HORAS QUE TRABAJA POR DIA");
                if (int.TryParse(Console.ReadLine(), out hora) && hora > 0) {
                    horaTotal = hora * 6;
                    break;
                }
                else {
                    Console.WriteLine("##########  valor invalido intente nuevamente  ##########");
                }
            }
            return horaTotal;
        }
        static void definirPago() {
            double pago;
            while (true) {
                Console.Write("ingresar pago por hora trabajada: $");
                if (double.TryParse(Console.ReadLine(), out pago) && pago > 0) {
                    pagoHora = pago;
                    break;
                }
                else {
                    Console.WriteLine("##########  valor invalido intente nuevamente  ##########");
                }
            }
        }
        static double sueldoSemana(int _horaTotal) {
            double _sueldo = 0;
            _sueldo = _horaTotal * pagoHora;
            return _sueldo;
        }
    }
}
