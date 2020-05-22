using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    public enum TipoLlamada
    {
        Local,
        Provincial,
        Todas
    }
    public abstract class Llamada
    {

        protected float duracion;
        protected string nroDestino;
        protected string nroOrigen;

        #region Propiedades

        /// <summary>
        /// Propiedad Abstracta
        /// </summary>
        public abstract float CostoLlamada { get; }
        
        public float Duracion 
        { 
            get
            {
                return this.duracion;
            } 
        }
        public string NroDestino 
        { 
            get
            {
                return this.nroDestino;
            }
        }
        public string NroOrigen 
        { 
            get
            {
                return this.nroOrigen;
            }
        }
        #endregion

        //Constructor
        public Llamada(float duracion,string nrodestino,string nroOrigen)
        {
            this.duracion = duracion;
            this.nroDestino = nrodestino;
            this.nroOrigen = nroOrigen;
        }

        protected virtual string Mostrar()
        {
            StringBuilder texto = new StringBuilder();
            texto.AppendLine("Duracion: " + Duracion);
            texto.AppendLine("Numero de Destino: " + NroDestino);
            texto.AppendLine("Numero de Origen: " + NroOrigen);
            return texto.ToString();
        }

        public static int OrdenarporDuracion(Llamada llamada1, Llamada llamada2)
        {
            if (llamada1.Duracion > llamada2.Duracion)
                return 1;
            else
                return -1;
        }

        public static bool operator !=(Llamada l1, Llamada l2)
        {
            bool retorno = false;
            if (!(l1.Equals(l2)) && l1.NroDestino != l2.NroDestino && l1.NroOrigen != l2.NroOrigen)
                retorno = true;

            return retorno;
        }
        public static bool operator ==(Llamada l1,Llamada l2)
        {
            bool retorno = false;
            if ((l1.Equals(l2)) && l1.NroDestino == l2.NroDestino && l1.NroOrigen == l2.NroOrigen)
                retorno = true;

            return retorno;
        }


    }
}
