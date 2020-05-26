using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioCatorce
{
    public class PideValores
    {
        public static void PedirporConsola(int opc)
        {
           switch(opc)
            {
                case 1: Console.Write("Ingrese el valor del lado de un Cuadrado: ");
                        double valor = double.Parse(Console.ReadLine());
                        if(valor>0)
                        {
                            CalculoDeArea.CalcularCuadrado(valor);                     
                        }
                        break;
                case 2: Console.Write("Ingrese lado A del triangulo: ");
                        double ladoA = double.Parse(Console.ReadLine());
                        Console.Write("Ingrese lado B del triangulo: ");
                        double ladoB = double.Parse(Console.ReadLine());
                        if(ladoA>0 && ladoB>0)
                        {
                            CalculoDeArea.CalcularTriangulo(ladoA, ladoB);
                        }
                        break;
                case 3: Console.Write("Ingrese el radio del circulo: ");
                        double radio = double.Parse(Console.ReadLine());
                        if(radio>0)
                        {
                            CalculoDeArea.CalcularCirculo(radio);
                        }
                        break;
            }

        }


    }
}
