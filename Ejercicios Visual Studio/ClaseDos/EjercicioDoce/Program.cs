using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioDoce
{
    class Program
    {
        static void Main(string[] args)
        {
            /*12.Realizar un programa que sume números enteros hasta que el usuario lo determine, por medio de
              un mensaje "¿Continuar? (S/N)".
              En el método estático ValidaS_N(char c) de la clase ValidarRespuesta, se validará el ingreso de
              opciones.
              El método devolverá un valor de tipo booleano, TRUE si se ingresó una 'S' y FALSE si se ingresó
              cualquier otro valor.*/

            Console.WriteLine("Ejercicio Doce");
            Console.WriteLine("--------------");
            Console.WriteLine();

            
            int sumar = 0;
            bool sigue;

            do
            {
                Console.Write("Ingresar un numero: ");
                int numero = int.Parse(Console.ReadLine());

                Console.Write("¿Continuar?(S/N)  ");
                char caracter = char.Parse(Console.ReadLine());
                sigue=(ValidarRespuesta.ValidaS_N(caracter));
                if(sigue==true)
                {
                    sumar += numero;
                }
            } while(sigue==true);
            ValidarRespuesta.Sumar(sumar);


        }
    }
}
