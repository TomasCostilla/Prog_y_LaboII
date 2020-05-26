using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioCatorce
{
    public class CalculoDeArea
    {
        public static double CalcularCuadrado(double valor)
        {
            double resultado = 0;
            double resFinal = 0;
            resultado = valor*valor;
            resFinal = Math.Pow(resultado, 2);
            Console.WriteLine("El Area del Cuadrado es: {0}", resFinal);
            return valor;
        }

        public static double CalcularTriangulo(double A, double B)
        {
            double resultado = 0;
            resultado = A * B;
            Console.WriteLine("El Area del Triangulo es: {0}", resultado);
            return A;
        }

        public static double CalcularCirculo(double radio)
        {
            double resultado = 0;
            double resFinal = 0;
            resultado = Math.Pow(radio, 2);
            resFinal = resultado * 3.14;
            Console.WriteLine("El Area del Ciculo es: {0}", resFinal);
            return radio;
        }
    }
}
