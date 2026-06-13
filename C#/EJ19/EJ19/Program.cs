using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//La secretaria de salud requiere un algoritmo que permita determinar qué tipo de vacuna (A, B o C) debe 
//aplicar a una persona, considerando que si es mayor de 70 años, 
//sin importar el sexo, se le aplica la tipo C; si tiene entre 16 y 69 años, 
//y es mujer, se le aplica la B, y si es hombre, la A; si es menor
//de 16 años, se le aplica la tipo A, sin importar el sexo.

namespace EJ19 {
    internal class Program {
        static void Main(string[] args) {

            int edad;
            string genero;
            TIPOVAC tipo;
            GENERO tipogen;
            Console.WriteLine("======================SECRETARIA DE SALUD======================");
            Console.WriteLine("======================PLAN DE VACUNACION======================");
            while (true) {
                Console.WriteLine("ingrese un la edad del paciente: ");
                if (int.TryParse(Console.ReadLine(), out edad) && edad > 0) {
                    while (true) {
                        Console.WriteLine("ingrese el genero del paciente: ");
                        genero = Console.ReadLine()?.ToLower()??string.Empty;
                        if (Enum.TryParse(genero, out tipogen)) {

                            if(edad >= 70) {
                                tipo = TIPOVAC.C;
                            }
                            else if (edad >= 16) {
                                tipo = tipogen == GENERO.femenino ? TIPOVAC.B : TIPOVAC.A;
                            }
                            else {
                                tipo = TIPOVAC.A;
                            }
                            break;
                        }
                        else {
                            Console.WriteLine("genero no valido");
                        }
                    }
                    break;
                }
                else {
                    Console.WriteLine("ERROR edad no valida");
                }
            }

            Console.WriteLine("========================RESULTADOS==========================");
            Console.WriteLine($"la persona con {edad} años del genero {tipogen} le corresponde la vacuna del tipo {tipo}");

        }
        public enum TIPOVAC {
            A,
            B,
            C
        }
        public enum GENERO {
            masculino,
            femenino,
        }
    }
}
