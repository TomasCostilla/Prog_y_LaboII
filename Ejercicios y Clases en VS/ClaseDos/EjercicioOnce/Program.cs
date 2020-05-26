using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace EjercicioOnce
{
     class Program
    {
        static void Main(string[] args)
        {
            /*11.Realizar una clase llamada Validacion que posea un método estático llamado Validar, que posea la
               siguiente firma: bool Validar(int valor, int min, int max):
               a.valor: dato a validar
               b.min y max: rango en el cual deberá estar la variable valor.
               Pedir al usuario que ingrese 10 números enteros. Validar con el método desarrollado
               anteriormente que esten dentro del rango - 100 y 100.
               Terminado el ingreso mostrar el valor mínimo, el valor máximo y el promedio.
               Nota: Utilizar variables escalares, NO utilizar vectores.*/
            
            Console.WriteLine("Ejercicio 11");
            int iteraciones = 1;
            int menor = 100;
            int mayor = 0;
            int sumar = 0;          
            
            do
            {
                Console.Write("Ingresa un valor: ");
                int valorNum = int.Parse(Console.ReadLine());

                //Validacion.Validar(valorNum, -100, 100);
                if (Validacion.Validar(valorNum, -100, 100) == true)
                {
                    sumar += valorNum;
                    if(valorNum>mayor)
                    {
                        mayor = valorNum;
                    }
                    if(valorNum<menor)
                    {
                        menor = valorNum;
                    }
                }
                iteraciones += 1;
            } while (iteraciones <= 10);
            Validacion.MostrarPromedio(sumar, 10);
            Validacion.Mostrar(menor, mayor);
    

            
            




        }
    }
}
