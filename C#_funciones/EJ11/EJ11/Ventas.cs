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
    internal class Ventas {
        public int numeroVentas { get; set; }
        public double total { get; set; }
        public Ventas() {
            numeroVentas = 0;
            total = 0;
        }
        public void mostrar() {
            Console.WriteLine($"============================================");
            Console.WriteLine($"Numero de Ventas realizadas: {numeroVentas}");
            Console.WriteLine($"total de Ventas: ${total}");
            Console.WriteLine($"============================================");
        }
    }
}