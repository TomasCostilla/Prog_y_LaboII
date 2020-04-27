using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Entidades
{
    public class Jugador : Persona
    {
        //private int dni;
        //private string nombre;
        private int partidosJugados;
        //private float promedioGoles;
        private int totalGoles;


        private Jugador(int dni,string nombre) 
            :base(dni,nombre)
        {
        
        }
        public Jugador(int dni, string nombre,int totalGoles,int totalPart) 
            :this(dni,nombre)
        {
            this.totalGoles = totalGoles;
            this.partidosJugados = totalPart;
        }
        

        #region Propiedades
        public int partidosJug
        {
            get
            {
                return this.partidosJugados;
            }
            set
            {
                this.partidosJugados = value;
            }
        }
        public int TotalGoles
        {
            get
            {
                return this.totalGoles;
            }
            set
            {
                this.totalGoles = value;
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
        #endregion

        //public string MostrarDatos()
        //{
        //    //StringBuilder texto = new StringBuilder();
        //    ////texto.AppendLine("Dni: "+this.dni);
        //    //texto.AppendLine("Dni: " + PropDni);
        //    ////texto.AppendLine("Nombre: " + this.nombre);
        //    //texto.AppendLine("Nombre: " + PropNom);
        //    ////texto.AppendLine("Partidos Jugados: " + this.partidosJugados);
        //    //texto.AppendLine("Partidos Jugados: " + partidosJug);
        //    ////texto.AppendLine("Promedio de Goles: " + this.GetPromedioGoles());
        //    //texto.AppendLine("Promedio de Goles: " + PromedioG);
        //    ////texto.AppendLine("Total de Goles: " + this.totalGoles);
        //    //texto.AppendLine("Total de Goles: " + TotalGoles);
        //    //return texto.ToString();

        //}

        public static bool operator !=(Jugador j1,Jugador j2)
        {
            return !(j1 == j2);
        }
        public static bool operator ==(Jugador j1,Jugador j2)
        {
            return j1.Dni == j2.Dni;
        }


    }
}
