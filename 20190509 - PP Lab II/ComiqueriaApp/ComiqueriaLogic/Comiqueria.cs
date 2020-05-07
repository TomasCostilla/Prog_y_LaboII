using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ComiqueriaLogic
{
    public class Comiqueria
    {
        private List<Producto> productos;
        private List<Venta> ventas;


        public Comiqueria()
        {
            this.productos = new List<Producto>();
            this.ventas = new List<Venta>();
        }

        public Producto this[Guid codigo]
        {
            get 
            {
                foreach (Producto item in this.productos)
                {
                    if ((Guid)item == codigo)
                    {
                        return item;
                    }
                }
                return null;
            }
        }

        public static bool operator ==(Comiqueria comiqueria, Producto producto)
        {
            bool encuentra = false;
            foreach (Producto item in comiqueria.productos)
            {
                if(producto.Descripcion==item.Descripcion)
                {
                    encuentra = true;
                }
            }
            return encuentra;
        }
        public static bool operator !=(Comiqueria comiqueria, Producto producto)
        {
            return !(comiqueria == producto);
        }

        public static Comiqueria operator +(Comiqueria comiqueria, Producto producto)
        {
            if(comiqueria!=producto)
            {
                comiqueria.productos.Add(producto);
            }
            return comiqueria;        
        }

        public void Vender(Producto producto)
        {
            Vender(producto, 1);
        }
        public void Vender(Producto producto, int cantidad)
        {
            //Venta v = new Venta(producto,cantidad);

            this.ventas.Add(new Venta(producto, cantidad));
        }

        public string ListarVentas()
        {
            StringBuilder texto = new StringBuilder();

            this.ventas.Sort(Venta.OrdenarFecha);
            foreach (Venta item in this.ventas)
            {
                texto.AppendLine(item.ObtenerDescripcionBreve());    
            }
            return texto.ToString();
        }

        public Dictionary<Guid,string> ListarProductos()
        {
            Dictionary<Guid, string> retorno = new Dictionary<Guid, string>();
            foreach (Producto item in this.productos)
            {
                retorno.Add((Guid)item, item.Descripcion);
            }
            return retorno;
        }


    }
}
