using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Cliente
    {
        private string nombre;
        private int numero;

        #region Propiedades
        public string PropNombre
        {
            get
            {
                return this.nombre;
            }
            set
            {
                this.nombre = value;
            }
        }

        public int PropNum
        {
            get
            {
                return this.numero;
            }
            set
            {
                this.numero = value;
            }
        }
        #endregion

        #region Constructores
        public Cliente(int numero)
        {
            this.numero = numero;
        }
        public Cliente(int numero, string nombre) : this(numero)
        {
            this.nombre = nombre;
        }
        #endregion

        #region Sobrecargas

        public static bool operator !=(Cliente c1,Cliente c2)
        {
            return !(c1 == c2);
        }
        public static bool operator ==(Cliente c1, Cliente c2)
        {
            return c1 == c2;
        }
        #endregion


    }
}
