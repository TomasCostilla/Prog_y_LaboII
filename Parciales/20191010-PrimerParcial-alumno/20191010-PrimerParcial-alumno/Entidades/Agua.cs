using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Agua : Botella
    {
        private const int MEDIDA = 400;

        public Agua(int capacidadML,string marca,int contenidoML) 
            :base(marca,capacidadML,contenidoML)
        {
            
        }

        protected override string GenerarInforme()
        {
            StringBuilder texto = new StringBuilder();

            texto.AppendLine(base.GenerarInforme());
            texto.AppendLine($"Medida: {Agua.MEDIDA}");
            return texto.ToString();
        }

        public override int ServirMedida()
        {
            return ServirMedida(Agua.MEDIDA);
        }
        public int ServirMedida(int medida)
        {
            int gasta = 0;
            if(medida <= this.Contenido)
            {
                gasta = medida;
            }
            else
            {
                gasta = this.Contenido;
            }
            return this.Contenido = this.Contenido-gasta;
        }




    }
}
