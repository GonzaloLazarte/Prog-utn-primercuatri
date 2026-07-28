
//La cadena de tiendas de autoservicio "El mandilón" cuenta con sucursales
//en C ciudades diferentes de la República, en cada ciudad cuenta con T
//tiendas y cada tienda cuenta con N empleados, asimismo, cada una registra
//lo que vende de manera individual cada empleado, cuánto fue lo que
//vendió cada tienda, cuánto se vendió en cada ciudad y cuánto recaudó la
//cadena en un solo día. Resolver el ejercio con un clase para validar datos
//y otra para calcular las ventas.

namespace EJ14 {
    internal class Program {
        static int C = 0, T = 0, N = 0; 
        static void Main(string[] args) {
            Console.WriteLine("=============== EL MANDILON ================");
            Console.WriteLine(" Porfavor ingrese los datos de la franquicia");
            for (int i = 1; i <= 3; i++) {
                if (i == 1) {
                    Console.Write("Numero de ciudades cubiertas: ");
                    C = validar();
                }
                else if (i == 2) {
                    Console.Write("Numero de tiendas por ciudad: ");
                    T = validar();
                }
                else if (i == 3) {
                    Console.Write("Numero de empleados por tienda: ");
                    N = validar();
                }
            }
          


        }
        static int validar() {
            int entrada = 0;
            while (true) {
                if (int.TryParse(Console.ReadLine(), out entrada ) && entrada >= 1) {
                    return entrada;
                }
                else {
                    Console.WriteLine("Entrada invalida, porfavor ingrese un numero entero mayor a 0");
                }
            }
        }
    }
}
