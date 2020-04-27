using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Ejercicio_34
{
    class Program
    {
        static void Main(string[] args)
        {
            Automovil auto1 = new Automovil(2, 4, Colores.Blanco, 5, 4);
            VehiculoTerrestre vht1 = new VehiculoTerrestre(2, 4, Colores.Azul, 6, 7);

            if(auto1 is VehiculoTerrestre)
            {
                Console.WriteLine("Es vehiculo terrestre");
            }
            
            if(vht1 is Automovil)
            {
                Console.WriteLine("Lo es!");
            }

        }
    }
}
