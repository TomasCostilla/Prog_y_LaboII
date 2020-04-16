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
        //private float promedioGoles;
        private int totalGoles;


        private Jugador()
        {
            this.partidosJugados = 0;
           // this.promedioGoles = 0;
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

        #region Propiedades
        public int partidosJug
        {
            get
            {
                return this.partidosJugados;
            }

        }

        public int TotalGoles
        {
            get
            {
                return this.totalGoles;
            }

        }

        public float PromedioG
        {
            get
            {
                float PromedioGoles;

                if (this.partidosJugados == 0)
                {
                    PromedioGoles = 0;
                }
                else
                    PromedioGoles = this.totalGoles / this.partidosJugados;

                return PromedioGoles;
            }
        }

        public int PropDni
        {
            get
            {
                return this.dni;
            }
            set
            {
                this.dni = value;
            }
        }

        public string PropNom
        {
            get
            {
                return this.nombre;
            }
            set
            {
                this.nombre = value;
            }

        }
        #endregion



        /*public float GetPromedioGoles()
        {
            if(this.partidosJugados==0)
            {
                this.promedioGoles = 0;
            }
            else
                this.promedioGoles = this.totalGoles / this.partidosJugados
;
            return this.promedioGoles;
        }*/
        public string MostrarDatos()
        {
            StringBuilder texto = new StringBuilder();
            texto.AppendLine("Dni: "+this.dni);
            texto.AppendLine("Nombre: " + this.nombre);
            texto.AppendLine("Partidos Jugados: " + this.partidosJugados);
            //texto.AppendLine("Promedio de Goles: " + this.GetPromedioGoles());
            texto.AppendLine("Promedio de Goles: " + PromedioG); 
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
