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


        #region GettersAndSetters
        public void SetCombustible(short combustible)
        {
            this.cantidadCombustible = combustible;
        }
        public short GetCombustible()
        {
            return this.cantidadCombustible;
        }

        public void SetEnCompetencia(bool val)
        {
            this.enCompetencia = val;
        }
        public bool GetEnCompetencia()
        {
            return this.enCompetencia;
        }

        public void SetVueltasRestantes(short Vueltas)
        {
            this.vueltasRestantes = Vueltas;
        }
        public short GetVueltasRestantes()
        {
            return this.vueltasRestantes;
        }
        #endregion

        #region Constructores
        public AutoF1()
        {
            this.enCompetencia = false;
            this.cantidadCombustible = 0;
            this.vueltasRestantes = 0;
        }
        public AutoF1(short numero, string escuderia) :this()
        {
            this.numero = numero;
            this.escuderia = escuderia;
        }
        #endregion


        public  string MostrarDatos()
        {
            StringBuilder datos = new StringBuilder();
            datos.AppendLine("Cantidad de combustible: " + this.GetCombustible());
            datos.AppendLine("En Competencia: " + this.GetEnCompetencia());
            datos.AppendLine("Escuderia: " + this.escuderia);
            datos.AppendLine("Numero: " + this.numero);
            datos.AppendLine("Vueltas Restantes: " + this.GetVueltasRestantes());
            return datos.ToString();
        }
        
        public static bool operator !=(AutoF1 a1,AutoF1 a2)
        {
            return !(a1 == a2);
        }
        public static bool operator ==(AutoF1 a1,AutoF1 a2)
        {
            bool iguales = false;
            if(a1.numero == a2.numero)
            {
                iguales = true;
            }

            return iguales;// && a1.escuderia == a2.escuderia;
        }
        



    }
}
