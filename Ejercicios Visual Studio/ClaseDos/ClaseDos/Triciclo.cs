using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimerClase
{
    public class Triciclo
    {
        public int atributo1;
        public static string atributo2;

        public int GetAtributo1()
        {
            return this.atributo1;
        }

        public static void SetAtributo2(string aux)
        {
            Triciclo.atributo2 = aux;
        
        }
    }
}
