using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class MotoCross : VehiculoDeCarrera
    {
        private short cilindrada;

        public MotoCross(short numero,string escuderia)
            :base(numero,escuderia)
        {

        }
        public MotoCross(short numero,string escuderia,short cilindradas)
            :this(numero,escuderia)
        {
            this.cilindrada = cilindradas;
        }

        public short Cilindrada 
        { 
            get
            {
                return this.cilindrada;
            }
            set
            {
                this.cilindrada = value;
            }
        }

        public static bool operator !=(MotoCross m1,MotoCross m2)
        {
            return !(m1 == m2);
        }
        public static bool operator ==(MotoCross m1, MotoCross m2)
        {
            bool iguales = false;
            if(m1.Cilindrada==m2.Cilindrada && m1.Numero==m2.Numero && m1.Escuderia==m2.Escuderia)
            {
                iguales = true;
            }
            return iguales;
        }



    }
}
