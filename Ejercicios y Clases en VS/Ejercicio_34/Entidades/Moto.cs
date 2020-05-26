using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Moto
    {
        
        //public enum Colores
        //{
        //    Rojo, Blanco, Azul, Gris, Negro
        //}

        public short cantidadRuedas;
        public short cantidadPuertas;
        public Colores color;
        public short cilindradas;

        public Moto(short cantRuedas,short cantPuertas, Colores val,short cilind)
        {
            this.cantidadRuedas = cantRuedas;
            this.cantidadPuertas = cantPuertas;
            this.color = val;
            this.cilindradas = cilind;
        }


    }
}
