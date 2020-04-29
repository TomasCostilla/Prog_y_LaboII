using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    public enum Franja
    {
        Franja_1,Franja_2,Franja_3
    }

   public class Provincial : Llamada
    {
        protected Franja franjaHoraria;

        public Provincial(Franja miFranja,Llamada llamada) :this(llamada.NroOrigen,miFranja,llamada.Duracion,llamada.NroDestino)
        {

        }
        public Provincial(string origen,Franja miFranja,float duracion,string destino) :base(duracion,destino,origen)
        {
            this.franjaHoraria = miFranja;
        }


        public float CostoLlamada 
        { 
            get
            {
                return this.CalcularCosto();
            }
        }

        private float CalcularCosto()
        {
            float retorno = default;

            switch(this.franjaHoraria)
            {
                case Franja.Franja_1:
                    retorno = (float)(this.Duracion*0.99);
                    break;
                case Franja.Franja_2:
                    retorno = (float)(this.Duracion * 1.25);
                    break;
                case Franja.Franja_3:
                    retorno = (float)(this.Duracion * 0.66);
                    break;
            }
            return retorno;
        }

        public string Mostrar()
        {
            StringBuilder texto = new StringBuilder();

            texto.AppendLine(base.Mostrar());
            texto.AppendLine("Costo llamada: " + CostoLlamada);
            texto.AppendLine("Franja Horaria: " + this.franjaHoraria);
            return texto.ToString();
        }


    }
}
