using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Negocio
    {
        private PuestoAtencion caja;
        private Queue<Cliente> clientes;
        private string nombre;

        /*public Cliente cliente 
        {
            get 
            {
                string resultado = this.clientes[];
                return this.clientes[];
            } 
                      
            set; 
        }*/

        private Negocio()
        {
            this.clientes = new Queue<Cliente>();
            this.nombre = "";
        }
        public Negocio(string nombre)
        {
            this.nombre = nombre;
        }

        public static bool operator !=(Negocio n,Cliente c)
        {
            return !(n == c);
        }
        public static bool operator ==(Negocio n, Cliente c)
        {
            return (n == c);
        }
        public static bool operator ~(Negocio n)
        {
            return false;
        }
        public static bool operator +(Negocio n, Cliente c)
        {
            return n + c;
        }



    }
}
