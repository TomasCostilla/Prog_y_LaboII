using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Camion
    {
        //public enum Colores
        //{
        //    Rojo, Blanco, Azul, Gris, Negro
        //}

        public short cantidadRuedas;
        public short cantidadPuertas;
        public Colores color;
        public short cantidadMarchas;
        public int pesoCarga;

        public Camion(short cantRuedas,short cantPuertas,Colores val,short cantMarchas,int PesoCarga)
        {
            this.cantidadRuedas = cantRuedas;
            this.cantidadPuertas = cantPuertas;
            this.color = val;
            this.cantidadMarchas = cantMarchas;
            this.pesoCarga = PesoCarga;
        }
         




    }
}
