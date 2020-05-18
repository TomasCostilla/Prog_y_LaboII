using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    /// <summary>
    /// Clase que hereda de Vehiculo
    /// </summary>
    public class PickUp : Vehiculo
    {
        private string modelo;
        private static int valorHora;

        /// <summary>
        /// Constructor de Clase
        /// </summary>
        static PickUp()
        {
            PickUp.valorHora = 70;
        }
        /// <summary>
        /// Constructor que utiliza el constructor de la clase base(Vehiculo)
        /// </summary>
        /// <param name="patente"></param>
        /// <param name="modelo"></param>
        public PickUp(string patente,string modelo)
            :base(patente)
        {
            this.modelo = modelo;
        }
        /// <summary>
        /// Constructor que recibe tres parametros
        /// </summary>
        /// <param name="patente"></param>
        /// <param name="modelo"></param>
        /// <param name="valorHora"></param>
        public PickUp(string patente,string modelo,int valorHora)
            :this(patente,modelo)
        {
            PickUp.valorHora = valorHora;
        }

        /// <summary>
        /// Metodo sobreescribido de la clase Vehiculo
        /// </summary>
        /// <returns></returns>
        public override string ConsultarDatos()
        {
            StringBuilder texto = new StringBuilder();
            texto.AppendLine(ImprimirTicket());
            texto.AppendLine($"Modelo: {this.modelo}");
            texto.AppendLine($"Valor Hora: {PickUp.valorHora}");
            return texto.ToString();
        }
        /// <summary>
        /// Metodo ImprimirTicket sobreescribido de la clase Vehiculo
        /// </summary>
        /// <returns></returns>
        public override string ImprimirTicket()
        {
            StringBuilder texto = new StringBuilder();
            texto.AppendLine(base.ImprimirTicket());
            texto.AppendLine($"Importe: {this.ingreso.Hour * PickUp.valorHora}");
            return texto.ToString();
        }


    }
}
