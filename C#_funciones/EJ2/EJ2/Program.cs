using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Se requiere un algoritmo para obtener la suma de diez cantidades mediante
//la utilización de un ciclo Repite. Usando dos métodos para resolver el ejercicio.
//El primer método se encargará de solicitar los datos y el segundo método se
//encargará de realizar la suma.

namespace EJ2 {
    internal class Program {
        static void Main(string[] args) {
            decimal numero;

            numero = recibir();
            
            Console.WriteLine($"la suma de los numeros es {numero}");
            Console.ReadKey();
        }
        static decimal recibir() {
            int i = 1;
            decimal num, suma = 0m;
            do {
                Console.WriteLine($"INGRESAR EL {i}° numero");
                if (decimal.TryParse(Console.ReadLine(), out num)) {
                    suma = sumar(suma, num);
                    i++;
                }
                else {
                    Console.WriteLine("error dato no valido, solo se periten numeros");
                }
            }
            while (i <= 10);
            return suma;
        }
        static decimal sumar(decimal sum,decimal numFun) {
            decimal total = sum;

            total += numFun;
            return total;
        }
    }
}
