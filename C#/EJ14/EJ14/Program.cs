using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Realice un algoritmo que, con base en una calificación proporcionada (0-10), 
//indique con letra la calificación que le corresponde: 10 es "A", 9 es "B", 8 es "C", 
//7 y 6 son "D", y de 5 a 0 son "F".

namespace EJ14 {
    internal class Program {
        static void Main(string[] args) {
            int nota;
            string letra;

            while (true) {
                Console.WriteLine("Porfavor ingrese una nota para calificar");
                if (int.TryParse(Console.ReadLine(), out nota) && nota >= 0 && nota <= 10) {
                   switch (nota) {
                        case 10:
                            letra = "A";
                            break;
                        case 9:
                            letra = "B";
                            break;
                        case 8:
                            letra = "C";
                            break;
                        case 7:
                            letra = "D";
                            break;
                        case 6:
                            letra = "D";
                            break;
                        default:
                            letra = "F";
                            break;
                    }
                    break;
                }
                else {
                    Console.WriteLine("ERROR INGRESE UN NUMERO VALIDO");
                }

            }
            Console.WriteLine($"la nota {nota} corresponde a la letra {letra}");

        }
    }
}
