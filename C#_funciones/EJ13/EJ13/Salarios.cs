using System;
using System.Collections.Generic;
using System.Text;

namespace EJ13 {
    internal class Salarios {
        private int horasTrabajadas = 0,horasTrabajador = 0;
        private double sueldoPorHora = 0;
        public Salarios(int num) {
            validarPagoHora();
            cargarHoras(num);
            mostrarTotal();
        }
        private void cargarHoras(int _num) {
            int horas = 0;
            for (int i = 0; i < _num; i++) {
                while (true) {
                Console.WriteLine("");
                Console.Write($"INGRESE HORAS SEMANALES DEL {i+1}° EMPLEADO: ");
                    if (int.TryParse(Console.ReadLine(), out horas) && horas >= 1) {
                        horasTrabajadas += horas;
                        horasTrabajador = horas;
                        mostrarSalarioEmpleado(i);
                        break;
                    }
                    else {
                        Console.WriteLine("error tipo de dato incorrecto");
                    }
                }
            }
        }
        private void validarPagoHora() {
            double pago = 0;
            while (true) {
                Console.Write("INGRESE EL PAGO POR HORA: ");
                if (double.TryParse(Console.ReadLine(), out pago) && pago >= 1) {
                    sueldoPorHora += pago;
                    break;
                }
                else {
                    Console.WriteLine("error tipo de dato incorrecto");
                }
            }
        }
        private void mostrarSalarioEmpleado(int _i) {
            Console.WriteLine($"El empleado n° {_i + 1} tiene  un sueldo de: ${horasTrabajador * sueldoPorHora} por trabajar {horasTrabajador}");
        }
        private void mostrarTotal() {
            Console.WriteLine($"la empresa pago un total de: ${horasTrabajadas * sueldoPorHora} por la cantidad de {horasTrabajadas} hs. trabajadas por todos sus empleados");
        }
    }
}
