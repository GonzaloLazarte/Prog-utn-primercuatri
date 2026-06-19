using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Realice un algoritmo que, a través de un método principal de impresión, coordine la llamada a dos
//métodos independientes. El primero debe recorrer los números del 0 al 20 e imprimir únicamente los
//valores pares utilizando el operador de residuo. El segundo método debe realizar el mismo
//recorrido (de 0 a 20) pero, utilizando una estructura de salto (continue) cuando detecte un número
//par, debe omitir su impresión para lograr mostrar únicamente los números impares.

namespace EJ8 {
    internal class Program {
        static void Main(string[] args) {
            titulos();
        }
        static void titulos() {
            Console.WriteLine("==================IMPRESION DE NUMEROS PARES==================");
            imprimirPares();
            Console.WriteLine("=================IMPRESION DE NUMERO IMPARES=================");
            imprimirImpares();
        }
        static void imprimirPares() {
            for (int i = 0; i <= 20; i++) {
                double aux = i % 2;
                if (aux == 0) {
                    Console.Write($"{i}, ");
                }
            }
            Console.WriteLine("");
        }
        static void imprimirImpares() {
            for (int i = 0; i <= 20; i++) {
                double aux = i % 2;
                if (aux == 0) {
                    continue;           //este lo que hace es pasar a la siguiente iteracion ignorando el resto de la ejecucion
                }
                Console.Write($"{i}, ");
            }
            Console.WriteLine("");
        }
    }
}
