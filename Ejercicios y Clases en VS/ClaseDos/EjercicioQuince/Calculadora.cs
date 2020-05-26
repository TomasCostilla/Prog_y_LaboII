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
                
            }
            else if(operacion=='-')
                {
                    resultado = numeroA - numeroB;
                    
            }
            else if(operacion=='*')
            {
                resultado = numeroA * numeroB;
                
            }
            else if(operacion=='/')
            {
                Validar(numeroB);
                resultado = numeroA / numeroB;
             
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
