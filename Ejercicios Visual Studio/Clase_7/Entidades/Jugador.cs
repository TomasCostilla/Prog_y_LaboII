using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Entidades
{
    public class Jugador
    {
        private int dni;
        private string nombre;
        private int partidosJugados;
        private float promedioGoles;
        private int totalGoles;


        private Jugador()
        {
            this.partidosJugados = 0;
            this.promedioGoles = 0;
            this.totalGoles = 0;
        }
        public Jugador(int dni, string nombre) :this()
        {
            this.dni = dni;
            this.nombre = nombre;
        }
        public Jugador(int dni, string nombre, int totalGoles, int totalPartidos) : this(dni, nombre)
        {
            this.totalGoles = totalGoles;
            this.partidosJugados = totalPartidos;
        }


        public float GetPromedioGoles()
        {
            float resultado = 0;
            resultado = this.totalGoles / this.partidosJugados;
            return resultado;
        }
        public string MostrarDatos()
        {
            StringBuilder texto = new StringBuilder();
            texto.AppendLine("Dni: " + this.dni);
            texto.AppendLine("Nombre: " + this.nombre);
            texto.AppendLine("Partidos Jugados: " + this.partidosJugados);
            texto.AppendLine("Promedio de Goles: " + this.GetPromedioGoles());
            texto.AppendLine("Total de Goles: " + this.totalGoles);
            return texto.ToString();
        }

        public static bool operator !=(Jugador j1,Jugador j2)
        {
            return !(j1 == j2);
        }
        public static bool operator ==(Jugador j1,Jugador j2)
        {
            return j1.dni == j2.dni;
        }


    }
}
