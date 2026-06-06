using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Cierta empresa proporciona un bono mensual a sus trabajadores, el cual puede ser por su antigüedad o bien por 
//el monto de su sueldo (el que sea mayor), de la siguiente forma: Cuando la antigüedad es mayor a 2 años pero 
//menor a 5, se otorga 20 % de su sueldo; cuando es de 5 años o más, 30 %. Ahora bien,
//el bono por concepto de sueldo, 
//si éste es menor a $1000, se da 25 % de éste, cuando éste es mayor a $1000, pero menor o igual a $3500, se otorga 15% 
//de su sueldo, para más de $3500. 10%. Realice el algoritmo correspondiente para calcular los dos tipos de bono, asignando 
//el mayor

namespace EJ8 {
    internal class Program {
        static void Main(string[] args) {

            double bonoSueldo, bonoAntiguo, bonofin, sueldo, antiguedad ;
            
            Console.WriteLine("======================= BONO PARA TRABAJADORES =======================");
            Console.Write("ingrese el sueldo del trabajador: $");
            sueldo = double.Parse(Console.ReadLine());
            Console.Write("ingrese la antiguedad en años del trabajador: ");
            antiguedad = double.Parse(Console.ReadLine());

            if (sueldo > 0 && antiguedad > 0) {
                // bono por concepto de sueldo
                if (sueldo < 1000) {
                    bonoSueldo = sueldo * 0.25;
                }
                else if (sueldo > 1000 && sueldo <= 3500) {
                    bonoSueldo = sueldo * 0.15;
                }
                else {
                    bonoSueldo = 0;
                    Console.WriteLine("debe ingresar un valor valido");
                }


                if (antiguedad > 2 && antiguedad < 5) {
                    bonoAntiguo = sueldo * 0.2;
                }
                else if (antiguedad >= 5) {
                    bonoAntiguo = sueldo * 0.3;
                }
                else {
                    bonoAntiguo = 0;
                    Console.WriteLine("debe ingresar un valor valido");
                }
            }
            else {
                Console.WriteLine("debe ingresar un valor valido");
                bonoSueldo = 0;
                bonoAntiguo = 0;
            }
            if (bonoSueldo > bonoAntiguo) {
                bonofin = sueldo + bonoSueldo;
                Console.WriteLine("en base a sus datos le corresponde un bono de concepto de sueldo ");
                Console.WriteLine($"su bono es de: ${bonoSueldo}, su sueldo final con el bono aplicado es de {bonofin}");
            }
            else {
                bonofin = sueldo + bonoAntiguo;
                Console.WriteLine($"en base a sus datos le corresponde un bono de concepto de antiguedad ");
                Console.WriteLine($"su bono es de: ${bonoAntiguo}, su sueldo final con el bono aplicado es de {bonofin}");
            }
        }
    }
}
