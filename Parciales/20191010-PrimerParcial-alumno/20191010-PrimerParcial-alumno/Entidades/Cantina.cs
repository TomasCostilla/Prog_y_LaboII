using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Cantina
    {

        private List<Botella> botellas;
        private static int espaciosTotales;
        private static Cantina singleton;

        public List<Botella> Botellas 
        { 
            get
            {
                return this.botellas;
            }
        }


        private Cantina(int espacios)
        {
            this.botellas = new List<Botella>();
            Cantina.espaciosTotales = espacios;
        }

        public static Cantina GetCantina(int espacios)
        {
            if (singleton is null)
            {
                singleton = new Cantina(espacios);
            }
            else
            {
                Cantina.espaciosTotales = espacios;
            }

            return singleton;
        }



        public static bool operator +(Cantina c,Botella b)
        {
            bool hayEspacio = false;
            if(c.botellas.Count < Cantina.espaciosTotales)
            {
                c.botellas.Add(b);
                hayEspacio = true;
            }
            return hayEspacio;
        }




    }
}
