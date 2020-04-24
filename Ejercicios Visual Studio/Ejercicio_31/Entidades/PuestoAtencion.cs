using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class PuestoAtencion
    {
        public enum Puesto
        {
            Caja1,Caja2
        }

        private int numeroActual;
        private Puesto puesto;

        #region Propiedades
        public int NumeroActual 
        {
            get
            {
                return this.numeroActual;
            }
        }
        #endregion

        public bool Atender(Cliente cli)
        {
            return true;
        }

        private PuestoAtencion()
        {
            this.numeroActual = 0;
        }

        public PuestoAtencion(Puesto puesto)
        {

        }


    }
}
