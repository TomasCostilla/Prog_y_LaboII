using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Practica uno"); //Console.WriteLine Escribe por consola
            int sigue = 0;
            int mayor = 0;
            int menor = 10;
            int auxmenor;
            int promedio = 0;
            int suma = 0;

            do
            {
                Console.WriteLine("Ingrese un numero: ");
                int valor = int.Parse(Console.ReadLine());
                auxmenor = valor;
                suma += valor;

                if(valor>mayor)
                {
                    mayor = valor;
                }
                if(valor<menor)
                {
                    menor = auxmenor;
                }
                sigue++;
            } while (sigue < 5);

            promedio = suma / 5;
            Console.WriteLine("El numero mayor ingresado fue: {0}",mayor);
            Console.WriteLine("El numero menor ingresado fue: {0}", menor);
            Console.WriteLine("La suma fue: {0}", suma);
            Console.WriteLine("El promedio fue de: {0}", promedio);


            /*Console.WriteLine("ingrese tu nombre: ");
            string minombre = Console.ReadLine();
            Console.WriteLine("tu nombre es: {0}",minombre);*/
            //Console.ReadKey();
            //string[] nombre = new string[3] {"Tom", "pablo","salva"};
            /*foreach (string elementos in nombre)
            {
                Console.WriteLine(elementos);
            }*/

            /*for (int i = 0; i < nombre.Length; i++)
            {
                string elementos = nombre[i];
                Console.WriteLine(elementos);
            }*/

        }
    }
}
