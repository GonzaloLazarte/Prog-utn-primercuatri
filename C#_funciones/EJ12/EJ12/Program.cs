using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Una persona adquirió un producto para pagar en 20 meses. El primer mes
//pagó $10, el segundo $20, el tercero $40 y así sucesivamente. Realice un
//algoritmo para determinar cuánto debe pagar mensualmente y el total de
//lo que pagó después de los 10 meses. Resolver el ejercicio con una clase
//y los métodos que sean necesarios.

namespace EJ12 {
    internal class Program {
        static void Main(string[] args) {
            Calcular calculo = new Calcular();
            calculo.Ejecutar();

        }
    }
}
