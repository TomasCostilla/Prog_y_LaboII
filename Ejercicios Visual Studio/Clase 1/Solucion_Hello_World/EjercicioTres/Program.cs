using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioTres
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Console.WriteLine("Ejercicio Tres");
            Mostrar por pantalla todos los números primos que haya hasta el número que ingrese el usuario
              por consola.
              Nota: Utilizar estructuras repetitivas, selectivas y la función módulo(%).

            int resultadouno;
            int resultadodos;
            int uno;
            int auxvalor;

            Console.Write("Ingrese un numero: ");
            int valor = int.Parse(Console.ReadLine());

            for (int i = 1; i <= valor; i++)
            {
                auxvalor = i;
                if (auxvalor%i==0 && auxvalor%1==0)
                {
                    Console.WriteLine("Los numeros primos son: ");
                    Console.WriteLine(auxvalor); 
                }
            }*/

            int num = 1, resto, divisor, salirWhile, cantidadNumerosMostrar, contador = 0;

            Console.Write("Cuantos numeros primos mostramos: ");
            cantidadNumerosMostrar = int.Parse(Console.ReadLine());

            // bucle hasta que se hayan encontrado los numeros indicados
            while (contador < cantidadNumerosMostrar)
            {
                divisor = 2; salirWhile = 0;

                // bucle para encontrar los numeros primos
                // la variable num se va incrementando en cada iteracción del primer while
                while ((divisor < num) & (salirWhile == 0))
                {

                    // buscamos el resto de la división
                    resto = num % divisor;

                    if (resto == 0)
                    {
                        salirWhile = 1;
                    }
                    else
                    {
                        divisor = divisor + 1;
                    }
                }

                if (salirWhile == 0)
                {
                    Console.Write(num + " ");
                    contador = contador + 1;
                }

                num = num + 1;
            }

            Console.WriteLine();
        

    }
    }
}
