﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Competencia
    {
        public enum TipoCompetencia
        {
            F1,MotoCross
        }

        private short cantidadCompetidores;
        private short cantidadVueltas;
        private List<VehiculoDeCarrera> competidores;
        private TipoCompetencia tipo;

        private Competencia()
        {
            this.competidores = new List<VehiculoDeCarrera>();
        }
        public Competencia(short cantidadvueltas, short cantidadCompetidores,TipoCompetencia tipo) :this()
        {
            this.cantidadVueltas = cantidadvueltas;
            this.cantidadCompetidores = cantidadCompetidores;
            this.tipo = tipo;
        }

        //public  string MostrarDatos()
        //{
        //    StringBuilder Comp = new StringBuilder();
        //    Comp.AppendLine("Cantidad de Competidores: " + this.cantidadCompetidores);
        //    Comp.AppendLine("Cantidad de Vueltas: " + this.cantidadVueltas);
        //    return Comp.ToString();
        //}

        public static bool operator -(Competencia c,VehiculoDeCarrera a)
        {
            return c - a;
        }
        public static bool operator +(Competencia c, VehiculoDeCarrera a)
        {
            bool inserta = false;

            if(c.tipo==TipoCompetencia.F1)
            {
                if(c.competidores.Count < c.cantidadCompetidores)
                {
                    foreach (VehiculoDeCarrera item in c.competidores)
                    {
                        if (a == item)
                        {
                            //Inserta es Falso
                        }
                        else
                        {
                            c.competidores.Add(a);
                            inserta = true;
                        }
                    }
                }
            }
            else if(c.tipo == TipoCompetencia.MotoCross)
            {
                if (c.competidores.Count < c.cantidadCompetidores)
                {
                    foreach (VehiculoDeCarrera item in c.competidores)
                    {
                        if (a == item)
                        {
                            //Inserta es Falso
                        }
                        else
                        {
                            c.competidores.Add(a);
                            inserta = true;
                        }
                            
                    }
                }
            }

            return inserta;
            
        }
        //public static bool operator ==(Competencia c, VehiculoDeCarrera a)
        //{
        //    bool esMoto = false;
        //    bool esAuto = false;

        //    if(c.tipo==TipoCompetencia.F1)
        //    {
        //        return esAuto = true;
        //    }
        //    else if(c.tipo==TipoCompetencia.MotoCross)
        //    {
        //        return esMoto = true;
        //    }

        //}
        //public static bool operator !=(Competencia c, VehiculoDeCarrera a)
        //{
        //    return !(c == a);
        //}



    }

}
