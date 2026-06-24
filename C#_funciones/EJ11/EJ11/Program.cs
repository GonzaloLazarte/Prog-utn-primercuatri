using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Un empleado de la tienda "Tiki Taka" realiza N ventas durante el día, se requiere
//saber cuántas de ellas fueron mayores a $1000, cuántas fueron mayores
//a $500 pero menores o iguales a $1000, y cuántas fueron menores o
//iguales a $500. Además, se requiere saber el monto de lo vendido en cada
//categoría y de forma global.

namespace EJ11 {
    internal class Program {
        static Ventas Mayores = new Ventas();
        static Ventas Medias = new Ventas();
        static Ventas Menores = new Ventas();
        static void Main(string[] args) {
            Console.WriteLine("===============TIKI TAKA==============");
            numeroVentas();

            Console.Clear();
            Console.WriteLine($"           MONTOS MAYORES A 1000            ");
            Mayores.mostrar();
            Console.WriteLine($"MONTOS MAYORES A 500 Y MENORES O IGUALES A 1000");
            Medias.mostrar();
            Console.WriteLine($"           MONTOS MENORES A 500             ");
            Menores.mostrar();
            Console.WriteLine($"MONTO GLOBAL:{Mayores.total + Medias.total + Menores.total} ");

        }
        static void numeroVentas() {
            int num = 0;
            Console.WriteLine($"ingrese el numero de ventas realizadas en el dia");
            while (true) { 
                if(int.TryParse(Console.ReadLine(),out num) && num > 0) {
                    ingresarMonto(num);
                    break;   
                }
                else {
                    Console.WriteLine("error tipo de dato ingresado incorrecto");
                }
            }
        }
        static void ingresarMonto(int _num) {
            double valor = 0;
            for (int i = 1; i <= _num; i++) {
                while (true) {
                    Console.WriteLine($"ingrese el valor de la {i} venta:");
                    if (double.TryParse(Console.ReadLine(), out valor) && valor > 0) {
                        validarIngreso(valor);
                        break;
                    }
                    else {
                        Console.WriteLine("error tipo de dato ingresado incorrecto");
                    }
                }
            }
        }
        static void validarIngreso( double _valor) {

            if (_valor > 1000) {
                Mayores.total += _valor;
                Mayores.numeroVentas++;
            }
            else if (_valor > 500 && _valor <= 1000) { 
                Medias.total += _valor;
                Medias.numeroVentas++;  
            }
            else if ( _valor <= 500) {
                Menores.total += _valor;
                Menores.numeroVentas++;
            }
        }

    }
}
