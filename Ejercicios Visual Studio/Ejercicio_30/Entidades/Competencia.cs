using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Competencia
    {
        private short cantidadCompetidores;
        private short cantidadVueltas;
        private List<AutoF1> competidores;

        private Competencia()
        {
            this.competidores = new List<AutoF1>();
        }
        public Competencia(short cantidadvueltas, short cantidadCompetidores) :this()
        {
            this.cantidadVueltas = cantidadvueltas;
            this.cantidadCompetidores = cantidadCompetidores;
        }

        public  string MostrarDatos()
        {
            StringBuilder Comp = new StringBuilder();
            Comp.AppendLine("Cantidad de Competidores: " + this.cantidadCompetidores);
            Comp.AppendLine("Cantidad de Vueltas: " + this.cantidadVueltas);
            return Comp.ToString();
        }




        public static bool operator -(Competencia c,AutoF1 a)
        {
            return c - a;
        }
        public static bool operator +(Competencia c, AutoF1 a)
        {
            bool contieneAuto = false;

            if (c.competidores.Count < c.cantidadCompetidores)
            {

                foreach (AutoF1 item in c.competidores)
                {
                    if(a==item)
                    {
                        //True
                        contieneAuto = true;
                    }
                    else
                    {
                        
                        c.competidores.Add(a);

                        contieneAuto = false;
                    }

                }      
                
            }
            return contieneAuto;
        }
        public static bool operator ==(Competencia c, AutoF1 a)
        {
            return c == a;
        }
        public static bool operator !=(Competencia c, AutoF1 a)
        {
            return !(c == a);
        }



    }

}
