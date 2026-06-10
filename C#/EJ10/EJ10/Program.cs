using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Determinar a qué lugar podrá ir de vacaciones una persona, considerando que la línea de autobuses "La tortuga" cobra
//por kilómetro recorrido. Se debe considerar el costo del pasaje tanto de ida, como de vuelta; 
//los datos que se conocen y que son fijos son: México, 750 km; P.V., 800 km; Acapulco, 1200 km, y Cancún, 1800
//km. También se debe considerar la posibilidad de tener que quedarse en casa.

namespace EJ10 {
    internal class Program {
        static void Main(string[] args) {

            double km, monto, pjemex, pjepv, pjeaca, pjecan;
            int mex = 750, pv = 800, aca = 1200, can = 1800;
            string mensaje = "no le alcanza para ir y volver de un destino mejor le recomendamos qeudarse en casa:";
            string m = "MEXICO", p = "P.V.", a = "ACAPULCO", c = "CANCUN", men = "";
            bool i = true;

            Console.WriteLine("======================== LA TORTUGA s.a. ==========================");
            Console.WriteLine("");
            Console.Write("porfavor ingrese el costo por kiometro recorrido:  $");
            km = double.Parse(Console.ReadLine());
            Console.WriteLine("");
            Console.WriteLine("COSTOS DE PASAJES IDA Y VUELTA: ");
            Console.WriteLine($"{m}: ${pjemex = km * mex * 2}");
            Console.WriteLine($"{p}: ${pjepv = km * pv * 2}");
            Console.WriteLine($"{a}: ${pjeaca = km * aca * 2}");
            Console.WriteLine($"{c}: ${pjecan = km * can * 2}");
           
            while (i == true) {
                Console.Write("ingrese el monto disponible por el usuario:  $");
                monto = double.Parse(Console.ReadLine());
                if (monto > km) {

                    if (monto >= pjemex && monto < pjepv) {
                        men = m;
                        Console.WriteLine($"¡¡con el monto de: ${monto} usted puede viajar de ida y vuelta a {men}!!");
                        
                    }
                    else if (monto >= pjepv && monto < pjeaca) {
                        men = p;
                        Console.WriteLine($"¡¡con el monto de: ${monto} usted puede viajar de ida y vuelta a {men}!!");
                        
                    }
                    else if (monto >= pjeaca && monto < pjecan) {
                        men = a;
                        Console.WriteLine($"¡¡con el monto de: ${monto} usted puede viajar de ida y vuelta a {men}!!");
                        
                    }
                    else if (monto >= pjecan) {
                        Console.WriteLine($"¡¡con el monto de: ${monto} usted puede viajar de ida y vuelta a {m}, {p}, {a}, {c}!!");
                    }
                    else {
                        Console.WriteLine(mensaje);
                    }
                    i = false;
                }
                else {
                    Console.WriteLine($"ingrese un monto mayor al costo por kilometro, {mensaje}");
                }
            }


        }
    }
}
