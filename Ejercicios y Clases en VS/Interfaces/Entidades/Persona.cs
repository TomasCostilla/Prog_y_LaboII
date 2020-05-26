using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Persona : ISeresVivos
    {
        string nombre;

     
        public Persona(string nombre)
        {
            this.nombre = nombre;
        }

        public string Descripcion 
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

        public bool guarda()
        {
            return true;
        }

    }
}
