using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Persona
    {
        private long dni;
        private string nombre;


        public long Dni 
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

        public string Nombre 
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

        public Persona(long Dni,string nom) 
            : this(nom)
        {
            this.dni = Dni;
        }
        public Persona(string nom)
        {
            this.nombre = nom;
        }

        public string MostrarDatos()
        {
            StringBuilder texto = new StringBuilder();
            texto.AppendLine("DNI: " + Dni);
            texto.AppendLine("Nombre: " + Nombre);
            return texto.ToString();
        }


    }
}
