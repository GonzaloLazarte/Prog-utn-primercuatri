using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Los alumnos de una escuela desean realizar un viaje de estudios, pero requieren determinar cuánto 
//les costará el pasaje, considerando que las tarifas del autobús son las siguientes: si son más de 100
//alumnos, el costo es de $20; si son entre 50 y 100, $35; entre 20 y 49, $40, y si son menos de 20 alumnos, 
//$70 por cada uno. Realice el algoritmo para determinar el costo del pasaje de cada alumno.

namespace EJ13 {
    internal class Program {
        static void Main(string[] args) {

            int alumnos = 0;
            double total = 0, pasaje = 0;

            while (true) {
                Console.Write("ingrese la cantidad de alumnos que asistiran al viaje escolar: ");
                if (int.TryParse(Console.ReadLine(), out alumnos) && alumnos > 0) {
                    if (alumnos > 100) {
                        pasaje = 20;
                    }
                    else if (alumnos >= 50 && alumnos <= 100) {
                        pasaje = 35;
                    }
                    else if (alumnos >= 2 && alumnos <= 49) {
                        pasaje = 40;
                    }
                    else if (alumnos < 20) {
                        pasaje = 70;
                    }
                    break;
                }
                else {
                    Console.WriteLine("##### ERROR DEBE VIAJAR ALGUIEN MINIMAMENTE #####");
                }
            }
            Console.WriteLine("=====================COSTOS DE LOS PASAJES==========================");
            Console.WriteLine($"para {alumnos} el costo de pasaje para cada uno es de: ${pasaje}");
            Console.WriteLine($"el total para que viajen todos los alumnos es de: ${total = alumnos * pasaje}");
        }
    }
}
