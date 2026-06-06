using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Se tiene el nombre y la edad de tres personas. Se desea saber el nombre y la edad de 
//la persona de menor edad

namespace EJ5 {
    internal class Program {
        static void Main(string[] args) {

            string nombre1, nombre2, nombre3;
            int edad1, edad2, edad3;

            Console.Write("ingrese nombre de la primera persona: ");
            nombre1 = Console.ReadLine();
            Console.Write("ingrese edad de la primera persona: ");
            edad1 = int.Parse(Console.ReadLine());
            Console.Write("ingrese nombre de la segunda persona: ");
            nombre2 = Console.ReadLine();
            Console.Write("ingrese edad de la segunda persona: ");
            edad2 = int.Parse(Console.ReadLine());
            Console.Write("ingrese nombre de la tercera persona: ");
            nombre3 = Console.ReadLine();
            Console.Write("ingrese edad de la tercera persona: ");
            edad3 = int.Parse(Console.ReadLine());

            if (edad1 < edad2) {
                if (edad1 < edad3) {
                    Console.WriteLine($"la persona de menor edad es {nombre1} con {edad1}");
                }
                else {
                    Console.WriteLine($"la persona de menor edad es {nombre3} con {edad3}");
                }
            }
            else {
                if (edad2 < 3) {
                    Console.WriteLine($"la persona de menor edad es {nombre2} con {edad2}");
                }
                else {
                    Console.WriteLine($"la persona de menor edad es {nombre3} con {edad3}");
                }
            }
        }
    }
}
