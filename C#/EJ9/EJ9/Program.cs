using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Una compañía de seguros para autos ofrece dos tipos de póliza: cobertura amplia (A) y daños a terceros (B). 
//Para el plan A, la cuota base es de $1,200, y para el B, de $950. A ambos planes se les carga
//10% del costo si la persona que conduce tiene por hábito beber alcohol,
//5% si utiliza lentes, 
//5% si padece alguna enfermedad como deficiencia ardiaca o diabetes, y si tiene más de 40 años, se le carga
//20%, de lo contrario sólo 10%. Todos estos cargos se realizan sobre el costo base. Determinar cuánto le cuesta 
//a una persona contratar una póliza.

namespace EJ9 {
    internal class Program {
        static void Main(string[] args) {

            string poliz = "", op = "";
            double bas = 0, alc = 0, len = 0, cor = 0, ed = 0;
            bool i, ialc, ilen, icor, ied;
            i = true;
            ialc = true;
            ilen = true;
            icor = true;
            ied = true;

            while (i == true) {
                Console.WriteLine("ingrese el tipo de poliza A/B ");
                poliz = Console.ReadLine();
                
                if (poliz=="A" || poliz == "a") {
                    poliz = "A";
                    bas = 1200;
                    //alcohol
                    while (ialc == true) {
                        Console.WriteLine("la persona tiene el habito de beber alcohol? s/n ");
                        op = Console.ReadLine();
                        if (op == "s" || op == "S") {
                            alc = bas * 0.1;
                            ialc = false;
                        }
                        else if (op == "n" || op == "N") {
                            alc = 0;
                            ialc = false;
                        }
                        else {
                            Console.WriteLine("ingrese una opcion valida");
                        }
                    }
                    //lentes
                    while (ilen == true) {
                        Console.WriteLine("la persona utiliza lentes? s/n ");
                        op = Console.ReadLine();
                        if (op == "s" || op == "S") {
                            len = bas * 0.05;
                            ilen = false;
                        }
                        else if (op == "n" || op == "N") {
                            len = 0;
                            ilen = false;
                        }
                        else {
                            Console.WriteLine("ingrese una opcion valida");
                        }
                    }
                    //corazon o diabetes
                    while (icor == true) {
                        Console.WriteLine("la persona padece enfermedades cardiacas o de daibetes? s/n ");
                        op = Console.ReadLine();
                        if (op == "s" || op == "S") {
                            cor = bas * 0.05;
                            icor = false;
                        }
                        else if (op == "n" || op == "N") {
                            cor = 0;
                            icor = false;
                        }
                        else {
                            Console.WriteLine("ingrese una opcion valida");
                        }
                    }
                    //edad
                    while (ied == true) {
                        Console.WriteLine("la persona tiene el habito de beber alcohol? s/n ");
                        op = Console.ReadLine();
                        if (op == "s" || op == "S") {
                            ed = bas * 0.2;
                            ied = false;
                        }
                        else if (op == "n" || op == "N") {
                            ed = bas * 0.1;
                            ied = false;
                        }
                        else {
                            Console.WriteLine("ingrese una opcion valida");
                        }
                    }
                    i = false;
                }
                else if (poliz == "B" || poliz == "b") {
                    poliz = "B";
                    bas = 950;
                    //alcohol
                    while (ialc == true) {
                        Console.WriteLine("la persona tiene el habito de beber alcohol? s/n ");
                        op = Console.ReadLine();
                        if (op == "s" || op == "S") {
                            alc = bas * 0.1;
                            ialc = false;
                        }
                        else if (op == "n" || op == "N") {
                            alc = 0;
                            ialc = false;
                        }
                        else {
                            Console.WriteLine("ingrese una opcion valida");
                        }
                    }
                    //lentes
                    while (ilen == true) {
                        Console.WriteLine("la persona utiliza lentes? s/n ");
                        op = Console.ReadLine();
                        if (op == "s" || op == "S") {
                            len = bas * 0.05;
                            ilen = false;
                        }
                        else if (op == "n" || op == "N") {
                            len = 0;
                            ilen = false;
                        }
                        else {
                            Console.WriteLine("ingrese una opcion valida");
                        }
                    }
                    //corazon o diabetes
                    while (icor == true) {
                        Console.WriteLine("la persona padece enfermedades cardiacas o de daibetes? s/n ");
                        op = Console.ReadLine();
                        if (op == "s" || op == "S") {
                            cor = bas * 0.05;
                            icor = false;
                        }
                        else if (op == "n" || op == "N") {
                            cor = 0;
                            icor = false;
                        }
                        else {
                            Console.WriteLine("ingrese una opcion valida");
                        }
                    }
                    //edad
                    while (ied == true) {
                        Console.WriteLine("la persona tiene el habito de beber alcohol? s/n ");
                        op = Console.ReadLine();
                        if (op == "s" || op == "S") {
                            ed = bas * 0.2;
                            ied = false;
                        }
                        else if (op == "n" || op == "N") {
                            ed = bas * 0.1;
                            ied = false;
                        }
                        else {
                            Console.WriteLine("ingrese una opcion valida");
                        }
                    }
                    i = false;
                }
                else {
                    Console.WriteLine("debe ingresar una opcion valida para el tipo de poliza ");
                }
            
            }

            Console.WriteLine("=====================CCOTIZACION FINAL DE POLIZA=======================");
            Console.WriteLine($"Los extras por cada concepto a pagar para una poliza de categoria {poliz} son:");
            Console.WriteLine($"costo base de la poliza {poliz}:                    |${bas}");
            Console.WriteLine($"habitos de beber:                             |${alc}");
            Console.WriteLine($"usa lentes:                                   |${len}");
            Console.WriteLine($"padece enfermedades cardiacas o de diabetes:  |${cor}");
            Console.WriteLine($"tiene mas de 40 años:                         |${ed}");
            Console.WriteLine("");
            Console.WriteLine($"total a pagar: ${bas + alc + len + cor + ed}");
            Console.WriteLine("");
            Console.ReadKey();


        }
    }
}
