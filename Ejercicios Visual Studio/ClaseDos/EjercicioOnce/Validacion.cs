using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioOnce
{
   public class Validacion //Colocar public siempre en CLASES
    {

        public static bool Validar(int valor, int min, int max) //En los metodos la primer letra va en mayuscula
        {
            if (valor >= min && valor <= 100)
            {
                Console.WriteLine("Valor correcto!");
                return true;
            }
            else
                Console.WriteLine("Se detectaron errores!");
                return false;        
        }

        public static bool Mostrar(int menor, int mayor) //En los metodos la primer letra va en mayuscula
        {
            Console.WriteLine("El menor de los datos ingresados fue: {0}",menor);
            Console.WriteLine("El mayor de los datos ingresados fue: {0}", mayor);
            return true;
        }

        public static bool MostrarPromedio(int suma, int total) //En los metodos la primer letra va en mayuscula
        {
            int promedio = 0;
            promedio = suma / total;
            Console.WriteLine("El promedio de los numeros ingresados es: {0}", promedio);
            return true;
        }
    }
}
