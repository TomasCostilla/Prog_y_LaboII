using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioCatorce
{
    class Program
    {
        static void Main(string[] args)
        {
            /*14. Realizar una clase llamada CalculoDeArea que posea 3 métodos de clase (estáticos) que realicen el
              cálculo del área que corresponda:
              a. double CalcularCuadrado(double)
              b. double CalcularTriangulo(double, double)
              c. double CalcularCirculo(double)
              El ingreso de los datos como la visualización se deberán realizar desde el método Main().*/

            Console.WriteLine("Ejercicio Catorce");
            Console.WriteLine("-----------------");
            Console.WriteLine();

            char caracter = ' ' ;

            do
            {
                Console.WriteLine("1.- Calcular Area de un Cuadrado...");
                Console.WriteLine("2.- Calcular Area de un Triangulo...");
                Console.WriteLine("3.- Calcular Area de un Circulo...");
                Console.WriteLine("4.- Salir...");
                Console.WriteLine();
                Console.Write("Ingrese una opcion a elegir: ");
                int opc = int.Parse(Console.ReadLine());
                switch (opc)
                {
                    case 1:
                        PideValores.PedirporConsola(opc);
                        Console.Write("Desea continuar?(S/N) ");
                        caracter = char.Parse(Console.ReadLine());
                        break;
                    case 2:
                        PideValores.PedirporConsola(opc);
                        Console.Write("Desea continuar?(S/N) ");
                        caracter = char.Parse(Console.ReadLine());
                        break;
                    case 3:
                        PideValores.PedirporConsola(opc);
                        Console.Write("Desea continuar?(S/N) ");
                        caracter = char.Parse(Console.ReadLine());
                        break;
                }
            } while (caracter!='N');


        }
    }
}
