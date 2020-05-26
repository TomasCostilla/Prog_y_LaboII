using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public enum Colores
    {
        Rojo, Blanco, Azul, Gris, Negro
    }
    public class Automovil
    {

        public short cantidadRuedas;
        public short cantidadPuertas;
        public Colores color;
        public short cantidadMarchas;
        public int cantidadPasajeros;

        public Automovil(short cantRuedas,short cantPuertas,Colores val,short cantMarchas,int cantPasajeros)
        {
            this.cantidadRuedas = cantRuedas;
            this.cantidadPuertas = cantPuertas;
            this.color = val;
            this.cantidadMarchas = cantMarchas;
            this.cantidadPasajeros = cantPasajeros;
        }



    }
}
