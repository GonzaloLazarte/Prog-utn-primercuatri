using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Se requiere obtener la suma de las cantidades contenidas en un arreglo de
//10 elementos.

namespace ConsoleApp1 {
    internal class Program {
        static void Main(string[] args) {
            int num = 0, sum = 0;
            int[] vector= new int[10];
            Console.WriteLine("INGRESE EL VECTOR");
            for (int i = 0; i < vector.Length; i++) {
                Console.Write($"Elemento: [{i}]  ");
                if (int.TryParse(Console.ReadLine(), out num)) {
                    vector[i] = num;
                    sum += num;
                }
                else {
                    Console.WriteLine("dato del tipo incorrecto");
                    i--;
                }
            }
            Console.WriteLine("INGRESE EL VECTOR");
            for (int i = 0; i < vector.Length; i++) {
                Console.Write($"[{vector[i]}], ");
            }
            Console.WriteLine("");
            Console.WriteLine($"RESULTADO DE LA SUMA DE ELEMENTOS DEL VECTOR :{sum}");
            Console.ReadKey();
        }
    }
}