using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

//Se tienen los nombres de los N alumnos de una escuela, además de su
//promedio general. Realice un algoritmo para capturar esta información, la
//cual se debe almacenar en arreglos, un vector para el nombre y otro para
//el promedio, después de capturar la información se debe ordenar con base
//en su promedio, de mayor a menor, los nombres deben corresponder con
//los promedios.

namespace EJ3 {
    internal class Program {
        static string[] alumnos;
        static int[] nota;
        static void Main(string[] args) {
            Console.WriteLine("ingrese la cantidad de alumnos a cargar ");
            int num = Validnum();
            alumnos = new string[num];
            nota = new int[num];

            Console.WriteLine("Carga de alumnos y notas");
            Carga(num);

            Console.WriteLine("============alumnos ordenados por nota de mayor a menor==========");
            OrdenarVector(num);
            for(int i = 0; i < num; i++) {
                Console.WriteLine($"nombre: {alumnos[i]}----- promedio: {nota[i]}");
            }
        }
        static int Validnum() {
            int result = 0;
            while (true) {
                if (int.TryParse(Console.ReadLine(), out result)) {
                    break;
                }
                else {
                    Console.WriteLine("TIPO DE DATO INCORRECTO");
                }
            }
            return result;
        }
        static void Carga(int num_) {
            for(int i = 0; i < num_; i++) {
                Console.Write($"ingrese el nombre del {i}° alumno:  >>");
                alumnos[i] = Console.ReadLine();
                Console.Write($"ingrese la nota del {i}° alumno:  >>");
                nota[i] = Validnum();
            }
        }
        static void OrdenarVector(int num_) {
            for (int i = 0; i < num_ - 1; i++) {
                for (int j = 0; j < num_ - i -1; j++) {
                    if (nota[j] < nota[j + 1]) {

                        int auxiliar = nota[j];
                        nota[j] = nota[j + 1];
                        nota[j + 1] = auxiliar;

                        string auxnom = alumnos[j];
                        alumnos[j] = alumnos[j + 1];
                        alumnos[j + 1] = auxnom;
                    }
                }
            }
        }




    }
}
