using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    /// <summary>
    /// Clase Publica Estacionamiento
    /// </summary>
    public class Estacionamiento
    {
        private  int espacioDisponible;
        private  string nombre;
        private  List<Vehiculo> vehiculos;

        /// <summary>
        /// Constructor privado
        /// </summary>
        private Estacionamiento()
        {
            this.vehiculos = new List<Vehiculo>();
        }
        /// <summary>
        /// Constructor que recibe dos parametros
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="espaciodisponible"></param>
        public Estacionamiento(string nombre,int espaciodisponible)
        {
            this.nombre = nombre;
            this.espacioDisponible = espaciodisponible;
        }

        /// <summary>
        /// Sobrecarga explicita de string
        /// </summary>
        /// <param name="e"></param>
        public static explicit operator string(Estacionamiento e)
        {
            StringBuilder texto = new StringBuilder();
            texto.AppendLine($"Nombre: {e.nombre}");
            texto.AppendLine($"Espacio disponibles: {e.espacioDisponible}");
            foreach (Vehiculo item in e.vehiculos)
            {
                texto.AppendLine(item.ImprimirTicket());
            }
            return texto.ToString();
        }
        /// <summary>
        /// Sobrecarga !=
        /// </summary>
        /// <param name="e"></param>
        /// <param name="v"></param>
        /// <returns></returns>
        public static bool operator !=(Estacionamiento e,Vehiculo v)
        {
            return !(e == v);
        }
        /// <summary>
        /// Sobrecarga ==
        /// </summary>
        /// <param name="estacionamiento"></param>
        /// <param name="vehiculo"></param>
        /// <returns></returns>
        public static bool operator ==(Estacionamiento estacionamiento, Vehiculo vehiculo)
        {
            if (estacionamiento.vehiculos.Contains(vehiculo))
            {
                return true;
            }
            else
                return false;
            
        }
        /// <summary>
        /// Sobrecarga de "-" que agrega segun validaciones
        /// </summary>
        /// <param name="estacionamiento"></param>
        /// <param name="vehiculo"></param>
        /// <returns></returns>
        public static string operator -(Estacionamiento estacionamiento, Vehiculo vehiculo)
        {
            string textoaRetornar = string.Empty;
            foreach (Vehiculo item in estacionamiento.vehiculos)
            {
                if (item == vehiculo)
                {
                    estacionamiento.vehiculos.Remove(vehiculo);
                    textoaRetornar = vehiculo.ImprimirTicket();
                }
                else
                    textoaRetornar = "El vehiculo no es parte del estacionamiento";
            }
            return textoaRetornar;

        }
        /// <summary>
        /// Sobrecarga que agrega un vehiculo
        /// </summary>
        /// <param name="estacionamiento"></param>
        /// <param name="vehiculo"></param>
        /// <returns></returns>
        public static Estacionamiento operator +(Estacionamiento estacionamiento, Vehiculo vehiculo)
        {
            if(!(estacionamiento.vehiculos.Contains(vehiculo)))
            {
                foreach (Vehiculo item in estacionamiento.vehiculos)
                {
                    if(!(item.Patente==vehiculo.Patente))
                    {
                        if(estacionamiento.espacioDisponible>estacionamiento.vehiculos.Count)
                        {
                            estacionamiento.vehiculos.Add(vehiculo);
                        }
                    }
                }
            }
            return estacionamiento;
        }



    }
}
