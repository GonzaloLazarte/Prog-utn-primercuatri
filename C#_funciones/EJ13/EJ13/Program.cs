

//Una empresa les paga a sus empleados con base en las horas trabajadas en
//la semana. Realice un algoritmo para determinar el sueldo semanal de N
//trabajadores y, además, calcule cuánto pagó la empresa por los N empleados. Usando una clase
// con los métodos que crea conveniente.

namespace EJ13 {
    internal class Program {
        static int numEmpleados = 0;
        static void Main(string[] args) {
            Console.WriteLine("============= CALCULADORA DE SUELDOS PARA EMPLEADOS =============");
            Console.WriteLine("");
            validar();
            Salarios salarioEmpleados = new Salarios(numEmpleados);
        }
        static void validar() {
            int num = 0;
            while (true) {
                Console.Write("INGRESE EL NUMERO DE EMPLEADOS: ");
                if (int.TryParse(Console.ReadLine(), out num) && num > 0) {
                    numEmpleados = num;
                    break;
                }
                else {
                    Console.WriteLine("error tipo de dato incorrecto");
                }
            }
        }
    }
}
