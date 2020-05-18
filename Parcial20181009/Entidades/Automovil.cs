using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    /// <summary>
    /// Clase heredada de Vehiculo
    /// </summary>
    public class Automovil : Vehiculo
    {
        private ConsoleColor color;
        private static int valorHora;

        /// <summary>
        /// Constructor de Clase(Static)
        /// </summary>
        static Automovil()
        {
            Automovil.valorHora = 50;
        }
        /// <summary>
        /// Constructor que recibe dos parametros
        /// </summary>
        /// <param name="patente"></param>
        /// <param name="color"></param>
        public Automovil(string patente,ConsoleColor color)
            :base(patente)
        {
            this.color = color;
        }
        /// <summary>
        /// Constructor que recibe tres parametros
        /// </summary>
        /// <param name="patente"></param>
        /// <param name="color"></param>
        /// <param name="valorHora"></param>
        public Automovil(string patente,ConsoleColor color,int valorHora)
            :this(patente,color)
        {
            Automovil.valorHora = valorHora;
        }

        /// <summary>
        /// Metodo sobreescribido de Vehiculo
        /// </summary>
        /// <returns></returns>
        public override string ConsultarDatos()
        {
            StringBuilder texto = new StringBuilder();
            texto.AppendLine(ImprimirTicket());
            texto.AppendLine($"Color: {this.color}");
            texto.AppendLine($"Valor Hora: {Automovil.valorHora}");
            return texto.ToString();
        }
        /// <summary>
        /// Metodo sobreescribido de Vehiculo
        /// </summary>
        /// <returns></returns>
        public override string ImprimirTicket()
        {
            StringBuilder texto = new StringBuilder();
            texto.AppendLine(base.ImprimirTicket());
            texto.AppendLine($"Importe: {this.ingreso.Hour * Automovil.valorHora}");
            return texto.ToString();
        }



    }
}
