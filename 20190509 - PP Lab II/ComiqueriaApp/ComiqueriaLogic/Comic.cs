using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComiqueriaLogic
{
    public class Comic : Producto
    {
        public enum TipoComic
        {
            Occidental,
            Oriental
        }

        private string autor;
        private TipoComic tipoComic;

        public Comic(string descripcion,int stock,double precio,string autor,TipoComic tipoComic)
            :base(descripcion,stock,precio)
        {
            this.autor = autor;
            this.tipoComic = tipoComic;
        }

        public override string ToString()
        {
            //Sobrescribir el método ToString. Agregar a lo devuelto por el ToString de la clase base los datos 
            //    del Comic(Autor y TipoComic). Seguir el mismo formato y metodología utilizado en la clase base.
            StringBuilder texto = new StringBuilder();

            texto.AppendLine(base.ToString());
            texto.AppendLine($"Auto: {this.autor}");
            texto.AppendLine($"Tipo Comic: {this.tipoComic}");
            return texto.ToString();
        }



    }
}
