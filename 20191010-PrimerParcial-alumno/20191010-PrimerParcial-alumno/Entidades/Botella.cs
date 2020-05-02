using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Botella
    {
        public enum Tipo
        {
            Vidrio,Plastico
        }


        protected int capacidadML;
        protected int contenidoML;
        protected string marca;

        public int CapacidadLitros 
        { 
            get
            {
                return this.capacidadML / 1000;
            }
        }
        public int Contenido 
        { 
            get
            {
                return this.contenidoML;
            }
            set
            {
                this.contenidoML = value;
            }
        }
        public float PorcentajeContenido 
        { 
            get
            {
                return (float)this.contenidoML * 100 / this.capacidadML;
            }
        }

        protected Botella(string marca,int capacidadML,int contenidoML) 
        {
            this.marca = marca;
            if(capacidadML < contenidoML)
            {
                this.capacidadML = capacidadML;
                this.contenidoML = capacidadML;
            }
            else
            {
                this.capacidadML = capacidadML;
                this.contenidoML = contenidoML;
            }
        }

        protected virtual string GenerarInforme() 
        {
            StringBuilder texto = new StringBuilder();

            texto.AppendLine($"Marca: {this.marca}");
            texto.AppendLine($"Capacidad: {this.CapacidadLitros}");
            texto.AppendLine($"Contenido: {this.Contenido}");
            return texto.ToString();
        }

        public abstract int ServirMedida();

        public override string ToString()
        {
            return GenerarInforme();
        }

    }
}
