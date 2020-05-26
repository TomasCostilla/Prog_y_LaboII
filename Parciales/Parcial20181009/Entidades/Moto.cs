using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    /// <summary>
    /// Moto hereda de Vehiculo
    /// </summary>
    public class Moto:Vehiculo
    {
        private int cilindrada;
        private short ruedas;
        private static int valorHora;

        /// <summary>
        /// Constructor de Clase(Static)
        /// </summary>
        static Moto()
        {
            Moto.valorHora = 30;
        }
        /// <summary>
        /// Constructor que recibe patente y cilindrada
        /// </summary>
        /// <param name="patente"></param>
        /// <param name="cilindrada"></param>
        public Moto(string patente,int cilindrada)
            :base(patente)
        {
            this.cilindrada = cilindrada;
            this.ruedas = 2;
            Moto.valorHora = 30;
        }
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="patente"></param>
        /// <param name="cilindrada"></param>
        /// <param name="ruedas"></param>
        public Moto(string patente,int cilindrada,short ruedas)
            :this(patente,cilindrada)
        {
            this.ruedas = 2;
        }
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="patente"></param>
        /// <param name="cilindrada"></param>
        /// <param name="ruedas"></param>
        /// <param name="valorHora"></param>
        public Moto(string patente,int cilindrada,short ruedas,int valorHora)
            :this(patente,cilindrada,2)
        {
            Moto.valorHora = valorHora;
        }

        /// <summary>
        /// Metodo que devuelve un string
        /// </summary>
        /// <returns></returns>
        public override string ConsultarDatos()
        {
            StringBuilder texto = new StringBuilder();
            texto.AppendLine(ImprimirTicket());
            texto.AppendLine($"Cilindrada: {this.cilindrada}");
            texto.AppendLine($"Ruedas: {this.ruedas}");
            texto.AppendLine($"Valor Hora: {Moto.valorHora}");
            return texto.ToString();
        }
        /// <summary>
        /// Metodo llamado por ConsultarDatos()
        /// </summary>
        /// <returns></returns>
        public override string ImprimirTicket()
        {
            StringBuilder texto = new StringBuilder();
            texto.AppendLine(base.ImprimirTicket());
            texto.AppendLine($"Importe: {this.ingreso.Hour * Moto.valorHora}");
            return texto.ToString();
        }

        //public override bool Equals(object obj)
        //{
        //    return (obj.Equals(Moto));
        //}



    }
}
