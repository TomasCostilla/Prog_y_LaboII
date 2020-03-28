using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioQuince
{
    public class Calculadora
    {

        public static int Calcular(int numeroA, int numeroB, char operacion)
        {
            int resultado = 0;
            if(operacion=='+')
            {
                resultado = numeroA + numeroB;
                Console.WriteLine("El resultado de la suma es: {0}", resultado);
            }
            else if(operacion=='-')
                {
                    resultado = numeroA - numeroB;
                    Console.WriteLine("El resultado de la resta es: {0}", resultado);
            }
            else if(operacion=='*')
            {
                resultado = numeroA * numeroB;
                Console.WriteLine("El resultado de la multiplicacion es: {0}", resultado);
            }
            else if(operacion=='/')
            {
                Validar(numeroB);
                resultado = numeroA / numeroB;
                Console.WriteLine("El resultado de la division es: {0}", resultado);
            }
     
            return resultado;
        }

     private static bool Validar(int numeroB)
        {
            if (numeroB != 0)
                return true;
            else
                return false;
        }

    }
}
