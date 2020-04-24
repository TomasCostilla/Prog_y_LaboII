using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class AutoF1
    {
        private short cantidadCombustible;
        private bool enCompetencia;
        private string escuderia;
        private short numero;
        private short vueltasRestantes;

        public short Combustible 
        {
            get
            {
                return this.cantidadCombustible;
            } 
            set
            {
                this.cantidadCombustible = value;
            }
        }
        public bool EnCompetencia
        {
            get
            {
                return this.enCompetencia;
            }           
            set
            {
                this.enCompetencia = value;
            }
        }

        public short Vueltas
        {
            get
            {
                return this.vueltasRestantes;
            }
            set
            {
                this.vueltasRestantes = value;
            }
        }



        public AutoF1(short numero, string escuderia)
        {
            this.numero = numero;
            this.escuderia = escuderia;
        }

        public  string MostrarDatos()
        {
            StringBuilder datos = new StringBuilder();
            datos.AppendLine("Cantidad de combustible: " + this.cantidadCombustible);
            datos.AppendLine("En Competencia: " + this.enCompetencia);
            datos.AppendLine("Escuderia: " + this.escuderia);
            datos.AppendLine("Numero: " + this.numero);
            datos.AppendLine("Vueltas Restantes: " + this.vueltasRestantes);
            return datos.ToString();
        }




    }
}
