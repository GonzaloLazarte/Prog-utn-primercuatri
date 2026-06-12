using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Realice un algoritmo que, con base en un número proporcionado (1-7)
//Indique el día de la semana que le corresponde (L-D)

namespace EJ15 {
    internal class Program {
        static void Main(string[] args) {
            int num = 0;
            string dia = "";

            while (true) {
                Console.WriteLine("ingreseun numero entero del 1 al 7");
                if (int.TryParse(Console.ReadLine(), out num) && num >= 1 && num <= 7) {
                    switch (num) {
                        case 1:
                            dia = "L";
                            break;
                        case 2:
                            dia = "M";
                            break;
                        case 3:
                            dia = "M";
                            break;
                        case 4:
                            dia = "J";
                            break;
                        case 5:
                            dia = "V";
                            break;
                        case 6:
                            dia = "S";
                            break;
                        case 7:
                            dia = "D";
                            break;
                    }
                    break;
                }
                else {
                    Console.WriteLine("ERROR ingrese un valor dentro del rango establecido");
                }
            }

            Console.WriteLine($"el numero {num} le corresponde la letra {dia}");

        }
    }
}
