using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Realice un algoritmo para determinar si una persona puede votar con base
//en su edad en las próximas elecciones

namespace EJ1 {
    internal class Program {
        
        static void Main(string[] args) {

            int edad;
            Console.WriteLine("==============DETERMINAR VOTANTE===============");
            Console.Write("ingrese su edad:");
            edad = int.Parse(Console.ReadLine());
            if (edad >= 18) {
                Console.WriteLine("SI puede votar");
            }
            else if (edad <= 0) {
                Console.WriteLine("la edad no es valida");
            }
            else {
                Console.WriteLine($"NO puede votar le faltan {18 - edad} Años");
            }

        }
    }
}
