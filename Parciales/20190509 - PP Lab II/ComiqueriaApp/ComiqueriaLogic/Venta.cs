using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComiqueriaLogic
{
    public sealed class Venta
    {
        private DateTime fecha;
        private static int porcentajelva;
        private double precioFinal;
        private Producto producto;


        internal DateTime Fecha 
        { 
            get
            {
                return this.fecha;
            }    
        }

        public static double CalcularPrecioFinal(double precioUnidad, int cantidad)
        {
            double resultado = precioUnidad * cantidad;
            double precioFinal = resultado * Venta.porcentajelva/ 100;
            return precioFinal;
        }

        private void Vender(int cantidad)
        {   
            producto.Stock -= cantidad;

            this.fecha = DateTime.Today;
            this.precioFinal = Venta.CalcularPrecioFinal(producto.Precio, cantidad);
        }

        static Venta()
        {
            Venta.porcentajelva = 21;
        }

        internal Venta(Producto producto, int cantidad)
        {
            this.producto = producto;
            Vender(cantidad);
        }

        public string ObtenerDescripcionBreve()
        {
            StringBuilder texto = new StringBuilder();

            texto.Append($"Fecha: {Fecha}");
            texto.Append($" Descripcion: {producto.Descripcion}");
            texto.Append($" PrecioFinal: {(double)this.precioFinal}");
            return texto.ToString();
        }


        public static int OrdenarFecha(Venta v1, Venta v2)
        {
            if (v1.Fecha > v2.Fecha)
                return 1;
            else
                return -1;
        }


    }
}
