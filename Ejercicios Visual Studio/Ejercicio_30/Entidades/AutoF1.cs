using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class AutoF1 : VehiculoDeCarrera
    {
        private short caballosDeFuerza;


        #region Propiedades
        public short CaballosDeFuerza 
        { 
            get
            {
                return this.caballosDeFuerza;
            }
            set
            {
                this.caballosDeFuerza = value;
            }
        }
        #endregion

        #region Constructores
        public AutoF1(short numero, string escuderia) 
            :base(numero,escuderia)
        {
            
        }
        public AutoF1(short numero,string escuderia,short caballosdeFuerza) 
            :this(numero,escuderia)
        {
            this.caballosDeFuerza = caballosdeFuerza;
        }
        #endregion


        //public  string MostrarDatos()
        //{
        //    StringBuilder datos = new StringBuilder();
        //    datos.AppendLine("Cantidad de combustible: " + this.GetCombustible());
        //    datos.AppendLine("En Competencia: " + this.GetEnCompetencia());
        //    datos.AppendLine("Escuderia: " + this.escuderia);
        //    datos.AppendLine("Numero: " + this.numero);
        //    datos.AppendLine("Vueltas Restantes: " + this.GetVueltasRestantes());
        //    return datos.ToString();
        //}
        
        public static bool operator !=(AutoF1 a1,AutoF1 a2)
        {
            return !(a1 == a2);
        }
        public static bool operator ==(AutoF1 a1,AutoF1 a2)
        {
            bool iguales = false;
            if(a1.CaballosDeFuerza == a2.CaballosDeFuerza && a1.Numero==a2.Numero && a1.Escuderia==a2.Escuderia)
            {
                iguales = true;
            }

            return iguales;// && a1.escuderia == a2.escuderia;
        }
        



    }
}
