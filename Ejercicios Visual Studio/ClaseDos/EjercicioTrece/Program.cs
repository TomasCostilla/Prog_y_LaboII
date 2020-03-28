using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioTrece
{
    class Program
    {
        /* static void Main(string[] args)
         {
             13.Desarrollar una clase llamada Conversor, que posea dos métodos de clase(estáticos):
               string DecimalBinario(int). Convierte un número de entero a binario.
               int BinarioDecimal(string). Convierte un número binario a entero.

             Console.WriteLine("Ejercicio Trece");
             Console.WriteLine("---------------");
             Console.WriteLine();

             Console.Write("Ingrese un valor a convertir: ");
             int numero = Convert.ToInt32(Console.ReadLine());
             Console.WriteLine(numero);
         }*/

        static void Main(string[] args)
        {

            Console.WriteLine("Ingrese un número entero ");
            int numero = Convert.ToInt32(Console.ReadLine());
            if (numero > 0)
            {
                String cadena = "";
                while (numero > 0)
                {
                    if (numero % 2 == 0)
                    {
                        cadena = "0" + cadena;
                    }
                    else
                    {
                        cadena = "1" + cadena;
                    }
                    numero = (int)(numero / 2);
                }
                Console.WriteLine(cadena);
            }
            else
            {
                if (numero == 0)
                {
                    Console.WriteLine("0");
                }
                else
                {
                    Console.WriteLine("Ingrese solo numeros positivos");
                }
            }
            Console.ReadLine();


        }
    }
}
