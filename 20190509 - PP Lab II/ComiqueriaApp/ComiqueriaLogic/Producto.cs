using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComiqueriaLogic
{
    public abstract class Producto
    {
        private Guid codigo;
        private string descripcion;
        private double precio;
        private int stock;

        protected Producto(string descripcion,int stock,double precio)
        {
            this.codigo = Guid.NewGuid();
            this.descripcion = descripcion;
            this.stock = stock;
            this.precio = precio;
        }

        public string Descripcion 
        { 
            get
            {
                return this.descripcion;
            }
        }

        public double Precio 
        { 
            get
            {
                return this.precio;
            }
        }

        public int Stock 
        { 
            get
            {
                return this.stock;
            }
            set
            {
                if(value >= 0)
                {
                    this.stock = value;
                }
            }
        }

        public static explicit operator Guid(Producto p)
        {
            return p.codigo;
        }


        public override string ToString()
        {
            StringBuilder texto = new StringBuilder();

            texto.AppendLine($"Descripcion: {this.Descripcion}");
            texto.AppendLine($"Codigo: {this.codigo}");
            texto.AppendLine($"Precio: {this.Precio}");
            texto.AppendLine($"Stock: {this.Stock}");

            return texto.ToString();
        }





    }
}
