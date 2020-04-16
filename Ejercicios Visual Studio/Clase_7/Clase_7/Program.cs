using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Clase_7
{
    class Program
    {
        static void Main(string[] args)
        {

            Equipo Equip1 = new Equipo(10, "boca");
            Jugador jug1 = new Jugador(123, "Tomas");
            Jugador jug2 = new Jugador(234, "pepe", 10, 2);
            Jugador jug3 = new Jugador(234, "pepe", 20, 3);



            //Console.WriteLine("jugador: "+jug1.MostrarDatos());
            //Console.WriteLine("jugador: " + jug2.MostrarDatos());

            if (Equip1 + jug1==false)
            {
                Console.WriteLine("agrego: {0}", jug1.MostrarDatos());
            }
            if(Equip1 + jug2==false)
            {
                Console.WriteLine("agrego: {0}", jug2.MostrarDatos());
            }
            if (jug2==jug3)
            {
                Console.WriteLine("igual DNI");
            }


        }
    }
}
