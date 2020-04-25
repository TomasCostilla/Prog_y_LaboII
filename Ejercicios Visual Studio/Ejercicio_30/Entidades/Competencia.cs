using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Competencia
    {
        private short cantidadCompetidores;
        private short cantidadVueltas;
        private List<AutoF1> competidores;

        private Competencia()
        {
            this.competidores = new List<AutoF1>();
        }
        public Competencia(short cantidadvueltas, short cantidadCompetidores)
        {
            this.cantidadVueltas = cantidadvueltas;
            this.cantidadCompetidores = cantidadCompetidores;
        }




    }

}
