using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Libro
    {
        private List<string> paginas; //= new List<string>();


        public Libro()
        {
            this.paginas = new List<string>();
        }

        public string this[int i]
        {
            get 
            {
                if (i >= 0 && i < this.paginas.Count - 1)
                {
                    return this.paginas[i];
                }
                else
                    return string.Empty;                  
            }
            set 
            {
                if(i>this.paginas.Count)
                {
                    this.paginas[i] = value;
                }
            }
        }


    }
}
