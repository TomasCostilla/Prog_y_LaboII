using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    public class Local : Llamada
    {

        protected float costo;

        public Local(Llamada llamada,float costo) :this(llamada.NroOrigen,llamada.Duracion,llamada.NroDestino,costo)
        {

        }
        public Local(string origen,float duracion,string destino, float costo) :base(duracion,destino,origen)
        {
            this.costo = costo;
        }

        public override float CostoLlamada 
        { 
            get
            {
                return CalcularCosto();
            }
        }

        protected override string Mostrar()
        {
            StringBuilder texto = new StringBuilder();

            texto.AppendLine(base.Mostrar());
            texto.AppendLine("Costo: " + CostoLlamada);
            return texto.ToString();
        }

        private float CalcularCosto()
        {
            return this.costo * this.Duracion;
        }

        public override string ToString()
        {
            return Mostrar();
        }

        public override bool Equals(object obj)
        {
            bool retorno = false;
            if(obj is Local)
            {
                retorno = true;
            }
            return retorno;
        }

    }
}
