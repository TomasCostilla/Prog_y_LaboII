using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    public class Centralita
    {

        private List<Llamada> listadeLlamadas;
        protected string razonSocial;


        public Centralita()
        {
            this.listadeLlamadas = new List<Llamada>();
            this.razonSocial = "";
        }
        public Centralita(string nombreEmpresa) :this()
        {
            this.razonSocial = nombreEmpresa;
        }


        public float GananciasPorLocal 
        { 
            get
            {
                return this.CalcularGanancia(TipoLlamada.Local);
            }
        }
        public float GananciasPorProvincial 
        { 
            get
            {
                return this.CalcularGanancia(TipoLlamada.Provincial);
            }
        }
        public float GananciasPorTotal 
        { 
            get
            {
                return this.CalcularGanancia(TipoLlamada.Todas);
            }
        }
        public List<Llamada> Llamadas 
        { 
            get
            {
                return this.listadeLlamadas;
            }
        }


        private string Mostrar()
        {
            StringBuilder texto = new StringBuilder();
            texto.AppendLine("Razon Social: " + this.razonSocial);
            texto.AppendLine("Ganancia Total: " + this.GananciasPorTotal);
            texto.AppendLine("Ganancia Local: " + this.GananciasPorLocal);
            texto.AppendLine("Ganancia Provincial: " + this.GananciasPorProvincial);
            foreach (Llamada item in this.listadeLlamadas)
            {
                texto.AppendLine(item.ToString());
            }
            return texto.ToString();
        }



        private float CalcularGanancia(TipoLlamada tipo)
        {

            float retorno = default;

            foreach (Llamada item in this.listadeLlamadas)
            {
                switch (tipo)
                {
                    case TipoLlamada.Local:
                        if (item is Local)
                            retorno += ((Local)item).CostoLlamada;

                        break;
                        
                    case TipoLlamada.Provincial:
                        if (item is Provincial)
                            retorno += ((Provincial)item).CostoLlamada;

                        break;
                    case TipoLlamada.Todas:
                        if (item is Local)
                            retorno += ((Local)item).CostoLlamada;
                        else if (item is Provincial)
                            retorno += ((Provincial)item).CostoLlamada;

                        break;
                    
                }
            }
            return retorno;
        }

        public void OrdenarLlamadas()
        {
            this.listadeLlamadas.Sort(Llamada.OrdenarporDuracion);
        }

        public override string ToString()
        {
            return Mostrar();
        }

        private void AgregarLlamada(Llamada nuevaLlamada)
        {
            this.listadeLlamadas.Add(nuevaLlamada);
        }
        public static bool operator ==(Centralita c,Llamada llamada)
        {
            bool existe = false;
            foreach (Llamada item in c.listadeLlamadas)
            {
                if(item==llamada)
                {
                    existe = true;
                }
            }
            return existe;
        }
        public static bool operator !=(Centralita c, Llamada llamada)
        {
            return !(c == llamada);
        }
        public static Centralita operator +(Centralita c, Llamada nuevallamada)
        {
            //bool existe = false;
            if(c==nuevallamada)
            {
                //No agrega
            }
            else
                c.AgregarLlamada(nuevallamada);
            
            return c;
        }

    }
}
