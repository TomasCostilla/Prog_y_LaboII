using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Cerveza : Botella
    {
        private const int MEDIDA=330;
        private Tipo tipo;

        public Cerveza(int capacidadML,string marca,int contenidoML) 
            :base(marca,capacidadML,contenidoML)
        {
            this.tipo = Tipo.Vidrio;
        }
        public Cerveza(int capacidadML,string marca,Tipo tipo,int contenidoML)
            :this(capacidadML,marca,contenidoML)
        {
            this.tipo = tipo;
        }

        protected override string GenerarInforme()
        {
            StringBuilder texto = new StringBuilder();

            texto.AppendLine(base.GenerarInforme());
            texto.AppendLine($"Medida: {Cerveza.MEDIDA}");
            texto.AppendLine($"Tipo de Botella: {this.tipo}");
            return texto.ToString();
        }

        public override int ServirMedida()
        {
            int gasta = 0;
            if(Cerveza.MEDIDA<=this.Contenido)
            {
                gasta = (int)(MEDIDA * 0.8);
            }
            else
            {
                gasta = this.contenidoML;
            }
            return this.contenidoML-=gasta;
        }

        public static implicit operator Botella.Tipo(Cerveza cerveza)
        {
            return cerveza.tipo;
        }


    }
}
