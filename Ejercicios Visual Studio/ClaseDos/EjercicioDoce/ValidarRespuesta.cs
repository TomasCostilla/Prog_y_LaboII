using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioDoce
{
   public class ValidarRespuesta
    {
        public static bool ValidaS_N(char c)
        {
            if (c=='S')
                return true;
            else
                Console.WriteLine("Usted ha salido del Programa...");
                return false;
        }

        public static bool Sumar(int suma)
        {
            Console.WriteLine("La suma de los numeros es: {0}", suma);
            return true;
        }
    }
}
