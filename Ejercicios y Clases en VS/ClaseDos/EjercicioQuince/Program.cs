using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioQuince
{
    class Program
    {
        static void Main(string[] args)
        {
            /*15. Realizar un programa que permita realizar operaciones matemáticas simples (suma, resta,
              multiplicación y división). Para ello se le debe pedir al usuario que ingrese dos números y la
              operación que desea realizar (pulsando el caracter +, -, * ó /).
              El usuario decidirá cuándo finalizar el programa.
              Crear una clase llamada Calculadora que posea dos métodos estáticos (de clase):
              a. Calcular (público): Recibirá tres parámetros, el primer número, el segundo número y la
              operación matemática. El método devolverá el resultado de la operación.
              b. Validar (privado): Recibirá como parámetro el segundo número. Este método se debe
              utilizar sólo cuando la operación elegida sea la DIVISIÓN. Este método devolverá
              TRUE si el número es distinto de CERO.*/

            Console.WriteLine("Ejercicio Quince");
            Console.WriteLine("----------------");
            Console.WriteLine();

            char caracter = ' ';
            do
            {
                Console.Write("Ingrese el numero A: ");
                int numeroA = int.Parse(Console.ReadLine());
                Console.Write("Ingrese el numero B: ");
                int numeroB = int.Parse(Console.ReadLine());
                Console.WriteLine();
                Console.WriteLine("Suma:  + ");
                Console.WriteLine("Resta: - ");
                Console.WriteLine("Multiplicacion: * ");
                Console.WriteLine("Division: / ");
                Console.Write("Que operacion desea realizar: ");
                char operacion = char.Parse(Console.ReadLine());
                Console.WriteLine("El resultado de la operacion es: " + Calculadora.Calcular(numeroA, numeroB, operacion));
                Console.Write("Desea continuar?(S/N) ");
                caracter = char.Parse(Console.ReadLine());


            } while (caracter!='N');


        }
    }
}
