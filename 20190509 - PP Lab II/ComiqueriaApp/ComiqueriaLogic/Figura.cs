using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComiqueriaLogic
{
   public class Figura : Producto
    {
        private double altura;

        public Figura(int stock,double precio,double altura)
            :this($"Figura{altura} cm",stock,precio,altura)
        {

        }
        public Figura(string descripcion,int stock,double precio,double altura)
            :base(descripcion,stock,precio)
        {
            this.altura = altura;
        }

        //Sobrescribir el método ToString.Agregar a lo devuelto por el ToString 
        //    de la clase base los datos de la Figura (Altura).
        //    Seguir el mismo formato y metodología utilizado en la clase base. 

        public override string ToString()
        {
            StringBuilder texto = new StringBuilder();
            texto.AppendLine(base.ToString());
            texto.AppendLine($"Altura: {this.altura}");
            return texto.ToString();
        }


    }
}
