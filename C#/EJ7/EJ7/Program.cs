using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//El presidente de la república ha decidido estimular a todos los estudiantes de una universidad mediante 
//la asignación de becas mensuales, para esto se tomarán en consideración los siguientes criterios: 
//Para alumnos mayores de 18 años
//con promedio mayor o igual a 9, la beca será de $2000.00;
//con promedio mayor o igual a 7.5, beca de 1000.00;
//para los promedios menores de 7.5 pero mayores o iguales a 6.0, de $500.00;
//a los demás se les enviará una carta de invitación incitándolos a que estudien más en el próximo ciclo escolar.
//
//
//A los alumnos de 18 años o menores de esta edad, 
//con promedios mayores o iguales a 9, se les dará $3000;
//con promedios menores a 9 pero mayores o iguales a 8, $2000; 
//para los alumnos con promedios menores a 8 pero mayores o iguales a 6, se les dará $100,
//y a los alumnos que tengan promedios menores a 6 se les enviará carta de invitación. 

namespace EJ7 {
    internal class Program {
        static void Main(string[] args) {

            int edad;
            double promedio, pago;
            string carta;
            bool puede;

            Console.WriteLine("====================== BECAS ======================");
            Console.Write("ingrese su edad: ");
            edad = int.Parse(Console.ReadLine());
            Console.Write("ingrese su promedio: ");
            promedio = double.Parse(Console.ReadLine());

            if (edad > 18 && promedio > 0) {
                if(promedio >= 9 && promedio > 0) {
                    carta = "felicitaciones puedes acceder a uno de nuestros beneficios el monto de tu beca es de:";
                    pago = 2000.00;
                    puede = true;
                }
                else if (promedio >= 7.5 && promedio > 0) {
                    carta = "felicitaciones puedes acceder a uno de nuestros beneficios el monto de tu beca es de:";
                    pago = 1000.00;
                    puede = true;
                }
                else if (promedio >= 6 && promedio < 7.5 && promedio > 0) {
                    carta = "felicitaciones puedes acceder a uno de nuestros beneficios el monto de tu beca es de:"; 
                    pago = 500.00;
                    puede = true;
                }
                else {
                    carta = "lamentamos no puedas acceder a este beneficio te invitamos a seguir esforzandote en tus estudios eintentarlo el proximo año";
                    puede = false;
                    pago = 0;
                }
            }
            else {
                if (edad > 0 && edad <=18 && promedio > 0) {
                    if (promedio >= 9 && promedio > 0) {
                        carta = "felicitaciones puedes acceder a uno de nuestros beneficios el monto de tu beca es de:";
                        pago = 3000.00;
                        puede = true;
                    }
                    else if (promedio >= 8 && promedio < 9 && promedio > 0) {
                        carta = "felicitaciones puedes acceder a uno de nuestros beneficios el monto de tu beca es de:";
                        pago = 2000.00;
                        puede = true;
                    }
                    else if (promedio >= 6 && promedio < 8 && promedio > 0) {
                        carta = "felicitaciones puedes acceder a uno de nuestros beneficios el monto de tu beca es de:";
                        pago = 100.00;
                        puede = true;
                    }
                    else {
                        carta = "promedio muy bajo no puedes acceder a este beneficio te invitamos a seguir esforzandote en tus estudios eintentarlo el proximo año";
                        puede = false;
                        pago = 0;
                    }
                }
                else {
                    Console.WriteLine("la edad o promedio debe ser un numero valido ");
                    carta = "";
                    puede = false;
                    pago = 0;
                }
            }            
            if (puede == true) {
                Console.WriteLine("====================== RESULTADO ======================");
                Console.WriteLine("");
                Console.WriteLine($"{carta} ${pago}");
            }
            else {
                Console.WriteLine(carta);
            }
        }
    }
}
