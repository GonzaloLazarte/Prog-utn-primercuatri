using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Realice un algoritmo que permita determinar qué paquete se puede comprar 
//una persona con el dinero que recibirá en diciembre, considerando lo siguiente:
//Paquete A. Si recibe $50,000 o más se comprará una televisión, un modular, 
//tres pares de zapatos, cinco camisas y cinco pantalones. 
//Paquete B. Si recibe menos de $50,000 pero más (o igual) de $20,000, se 
//comprará una grabadora, tres pares de zapatos, cinco camisas y cinco pantalones.
//Paquete C. Si recibe menos de $20,000 pero más (o igual) de $10,000, se comprará 
//dos pares de zapatos, tres camisas y tres pantalones.
//Paquete D. Si recibe menos de $10,000, se tendrá que conformar con un par de zapatos, 
//dos camisas y dos pantalones.

namespace EJ17 {
    internal class Program {
        static void Main(string[] args) {
            double dinero = 0;
            string text = "", msj = "";
            while (true) {
                Console.Write("ingrese la cantidad de dinero que recibira en diciembre: $");
                if (double.TryParse(Console.ReadLine(), out dinero) && dinero >= 0) {
                    if (dinero >= 50.000) {
                        text = "a";
                    }
                    else if (dinero >= 20.000 &&  dinero < 50.000) {
                        text = "b";
                    }
                    else if (dinero >= 10.000 && dinero < 20.000) {
                        text = "c";
                    }
                    else {
                        text = "d";
                    }

                    switch (text) {
                        case "a":
                            msj = "Paquete A: una televisión, un modular, tres pares de zapatos, cinco camisas y cinco pantalones.";
                            break;
                        case "b":
                            msj = "Paquete B: una grabadora, tres pares de zapatos, cinco camisas y cinco pantalones.";
                            break;
                        case "c":
                            msj = "Paquete C: dos pares de zapatos, tres camisas y tres pantalones";
                            break;
                        case "d":
                            msj = "Paquete D: un par de zapatos, dos camisas y dos pantalones.";
                            break;
                    }
                    break;
                }
                else {
                    Console.WriteLine("ingrese una cantidad de dinero valida");
                }
            }
            Console.WriteLine("==================RESULTADOS===================");
            Console.WriteLine($" con el monto de {dinero} que recibira en diciembre le alcanza para comprarse el {msj}");
        }
    }
}
