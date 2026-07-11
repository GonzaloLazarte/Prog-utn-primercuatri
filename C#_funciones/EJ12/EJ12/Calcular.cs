using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ12 {
    internal class Calcular {
        private int suma, mensual,aux;
        
        public Calcular() {
            mensual = 10;
            aux = 0;
            suma = 0;
        }
        public void Ejecutar() {
            for (int i = 1; i <= 12; i++) {
                aux = mensual;
                Console.WriteLine($"total a pagar en el mes {i}: ${mensual}");
                suma += mensual;
                mensual = aux * 2;
            }
            Console.WriteLine($"SUMA TOTAL DE LOS MESES PAGADOS: $ {suma}");
        }


    }
}
