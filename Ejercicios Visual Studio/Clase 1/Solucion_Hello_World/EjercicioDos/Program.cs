using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioDos
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Ingresar un número y mostrar: el cuadrado y el cubo del mismo. Se debe validar que el número sea
              mayor que cero, caso contrario, mostrar el mensaje: "ERROR. ¡Reingresar número!".
              Nota: Utilizar el método ‘Pow’ de la clase Math para realizar la operación.*/

            Console.WriteLine("Ejercicio dos");
            double valor;
            double cuadrado;
            double potencia = 2;
            double cubo;


            Console.Write("ingrese un numero: ");
            valor = float.Parse(Console.ReadLine());

            if(valor>0)
            {
                cuadrado = Math.Pow(valor, potencia);
                Console.WriteLine("La potencia del numero es: {0}", cuadrado);
                potencia = 3;
                cubo = Math.Pow(valor, potencia);
                Console.WriteLine("La potencia al cubo del numero es: {0}", cubo);
            }
            else
            {
                Console.WriteLine("ERROR. Reingresar numero!");
            }

        }
    }
}
