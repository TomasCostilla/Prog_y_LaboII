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

            Equipo Equip1 = new Equipo(10, "Boca");

            DateTime fecha1 = new DateTime(2020, 04, 27);
            DateTime fecha2 = new DateTime(2020, 04, 27);

            DirectorTecnico d1 = new DirectorTecnico("tomas",fecha1);
            DirectorTecnico d2 = new DirectorTecnico("tomas", fecha1);

            Jugador jug1 = new Jugador(123, "tomas", 21, 5);
            Jugador jug2 = new Jugador(234, "Pedro", 10, 6);

            if(jug1 is Persona)
            {
                Console.WriteLine("El jugador 1 es una Persona");
            }

            if(d1 == d2) //Dara True
            {
                Console.WriteLine("Iguales");
            }
            


          /*  if (Equip1 + jug1==false)
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
            }*/


        }
    }
}
