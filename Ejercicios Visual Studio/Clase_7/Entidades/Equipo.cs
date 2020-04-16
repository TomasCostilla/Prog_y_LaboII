using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Entidades
{
    public class Equipo
    {
        private short cantidadDeJugadores;
        private List<Jugador> jugadores;
        private string nombre;

        private Equipo()
        {
            this.jugadores = new List<Jugador>();
        }
        public Equipo(short cantidad, string nombre): this()
        {
            this.cantidadDeJugadores = cantidad;
            this.nombre = nombre;
        }

        public static bool operator +(Equipo e, Jugador j)
        {
            bool ContieneJugador = false;
            
            foreach (Jugador aux in e.jugadores)
            {
                if(j==aux)
                {
                    //e.jugadores.Add(j);
                    ContieneJugador = true;
                }
                else if(ContieneJugador && e.jugadores.Count < e.cantidadDeJugadores)
                {
                    e.jugadores.Add(j);
                }
            }

            //if(!e.jugadores.Contains(j) && e.jugadores.Count < e.cantidadDeJugadores)
            //{
            //    e.jugadores.Add(j);
            //    ContieneJugador = true;
            //}
           
            return ContieneJugador;
        }



    }
}
