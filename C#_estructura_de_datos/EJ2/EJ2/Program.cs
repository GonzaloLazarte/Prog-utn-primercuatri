using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Se requiere un algoritmo para obtener un vector (C) de N elementos que
//contenga la suma de los elementos correspondientes de otros dos vectores
//(A y B).

namespace EJ2 {
    internal class Program {
        static void Main(string[] args) {
            int dim = 0;
            
            Console.WriteLine("==========================SUMA DE VECTORES==========================");
            while (true) {
                Console.WriteLine("ingrese las dimensiones de los vectores a sumar ");
                if (int.TryParse(Console.ReadLine(), out dim)) {
                    break;
                }
                else {
                    Console.WriteLine("error el tipo de dato debe ser un numero entero");
                }
            }
            int[] VecA = new int[dim];
            int[] VecB = new int[dim];
            int[] VecC = new int[dim];
            Console.WriteLine("INGRESE LOS ELEMETNOS DEL VECTOR A");
            VecA = CargarVector(dim);
            Console.WriteLine("INGRESE LOS ELEMETNOS DEL VECTOR B");
            VecB = CargarVector(dim);
            VecC= sumarVector(VecA, VecB, dim);
            Console.WriteLine("Resultado de la suma de vectores");
            for (int i = 0; i < dim; i++) {
                Console.Write($"[{VecC[i]}]");
            }
        }
        static int[] CargarVector(int dim_) {
            int[] vectorCarga = new int[dim_];
            for(int i = 0; i < dim_; i++) {
                while (true) {
                    Console.Write($"valor para [{i}] >> ");
                    if (int.TryParse(Console.ReadLine(), out vectorCarga[i])) {
                        break;
                    }
                    else {
                        Console.WriteLine("error solo se aceptan valores enteros");
                    }
                }
            }
            return vectorCarga;
        }
        static int[] sumarVector(int[] vecA_, int[] vecB_, int dim_) {
            int[] vecresult = new int[dim_];
            for(int i = 0; i < dim_; i++) {
                vecresult[i] = vecA_[i] + vecB_[i];
            }
            return vecresult;
        }
    }
}