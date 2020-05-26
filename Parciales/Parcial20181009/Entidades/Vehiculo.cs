using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Vehiculo
    {
        protected DateTime ingreso;
        private string patente;


        /// <summary>
        /// Propiedad Patente
        /// </summary>
        public string Patente 
        { 
            get
            {
                return this.patente;
            }
            set
            {
                if (value.Length == 6)
                    this.patente = value;
            }
        }

        /// <summary>
        /// Constructor publico de Vehiculo
        /// </summary>
        /// <param name="patente"></param>
        public Vehiculo(string patente)
        {
            this.Patente = patente;
            this.ingreso = DateTime.Now.AddHours(-3);
        }


        /// <summary>
        /// Metodo abstracto que no tiene implementacion en Vehiculos
        /// </summary>
        /// <returns></returns>
        public abstract string ConsultarDatos();
        
        /// <summary>
        /// Metodo que retorna un string
        /// </summary>
        /// <returns></returns>
        public virtual string ImprimirTicket()
        {
            StringBuilder texto = new StringBuilder();
            texto.AppendLine(texto.ToString());
            texto.AppendLine($"Ingreso: {this.ingreso}");
            return texto.ToString();
        }
        /// <summary>
        /// Metodo ToString Sobrecargado
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            StringBuilder texto = new StringBuilder();
            texto.AppendFormat("Patente {0}", this.patente);
            return texto.ToString();
        }

        public static bool operator !=(Vehiculo v1,Vehiculo v2)
        {
            return !(v1.patente == v2.patente);
        }
        public static bool operator ==(Vehiculo v1, Vehiculo v2)
        {
            return (v1.patente == v2.patente);
        }

    }
}
