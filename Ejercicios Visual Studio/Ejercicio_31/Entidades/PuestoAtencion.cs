using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Entidades
{
    public class PuestoAtencion
    {
        public enum Puesto
        {
            Caja1,Caja2
        }

        private static int numeroActual;
        private Puesto puesto;

        #region Propiedades
        public static int NumeroActual 
        {
            get
            {
                PuestoAtencion.numeroActual += 1;
                return PuestoAtencion.numeroActual;
                //return this.numeroActual;
            }
        }
        #endregion

        public bool Atender(Cliente cli)
        {
            Thread.Sleep(10000);
            return true;
        }

        private PuestoAtencion()
        {
            PuestoAtencion.numeroActual = 0;
        }

        public PuestoAtencion(Puesto puesto)
        {

        }


    }
}
