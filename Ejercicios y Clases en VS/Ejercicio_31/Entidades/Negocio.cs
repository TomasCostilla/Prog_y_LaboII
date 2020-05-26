using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Negocio
    {
        private PuestoAtencion.Puesto caja;
        private Queue<Cliente> clientes;
        private string nombre;

        public Cliente ProxCliente 
        {
            /*get
            {
                return this.clientes.;
            }*/
            set
            {
                bool existe = false;
                foreach (Cliente item in this.clientes)
                {
                    if (value == item)
                    {
                        existe = true;
                    }
                    else
                    {
                        this.clientes.Enqueue(value);
                    }
                        
                }
            }
        }

        private Negocio()
        {
            this.clientes = new Queue<Cliente>();
            this.caja = PuestoAtencion.Puesto.Caja1;
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
            bool esta = false;
            foreach (Cliente item in n.clientes)
            {
                if(c==item)
                {
                    esta = true;
                }
                else
                {
                    n.clientes.Enqueue(c);
                }
            }
            return esta;
        }
        public static  bool operator ~(Negocio n)
        {
            
            
            return false;
        }
        public static bool operator +(Negocio n, Cliente c)
        {
            bool contieneCli = false;
            foreach (Cliente item in n.clientes)
            {
                if (c == item)
                {
                    contieneCli = true;
                }
                else
                    n.clientes.Enqueue(c);
            }
            return contieneCli;
        }



    }
}
