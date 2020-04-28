using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    public class Llamada
    {

        protected float duracion;
        protected string nroDestino;
        protected string nroOrigen;

        #region Propiedades
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

    }
}
