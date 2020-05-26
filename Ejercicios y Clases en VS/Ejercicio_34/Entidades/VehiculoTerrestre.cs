using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class VehiculoTerrestre : Automovil
    {
        public VehiculoTerrestre(short ruedas, short puertas, Colores val, short marchas, int cantp) 
            : base(ruedas,  puertas,  val, marchas, cantp)
        {

        }


    }
}
