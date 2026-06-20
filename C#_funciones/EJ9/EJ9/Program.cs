using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Realice un algoritmo para generar N elementos de la sucesión de Fibonacci
//(0, 1, 1, 2, 3, 5, 8, 13,?). Resolver el ejercicio utilizando métodos como crea conveniente

namespace EJ9 {
    internal class Program {
        static void Main(string[] args) {
            Console.WriteLine("==============SUSECION DE FIBONACCI===============");
            Console.WriteLine("ingrese la cantidad de elementos que desea obtener");
            int n = 0;
            while (true) {
                if (int.TryParse(Console.ReadLine(), out n)) {
                    break;
                }
                else {
                    Console.WriteLine("#!#!#! TIPO DE DATO ERRONEO !#!#!#");
                }
            }
            fibo(n);
        }
        static void fibo(int _n) {
            long fst = 0, snd = 1, trd = 0;
            for (int i = 0; i <= _n - 3; i++) {
                if (fst == 0 && snd == 1) {
                    Console.Write($"{fst},  ");
                    Console.Write($"{snd},  ");
                }
                trd = siguiente(fst, snd);
                fst = snd;
                snd = trd;
                Console.Write($"{trd},  ");
            }
        }
        static long siguiente(long _fst, long _snd) {
            long _trd;
            _trd = _fst + _snd;
            return _trd;
        }

    }
}
