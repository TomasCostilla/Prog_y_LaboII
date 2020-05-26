using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    /// <summary>
    /// Interfaz de Seres Vivos 
    /// </summary>
    public interface ISeresVivos
    {
        string Descripcion { get; set; }
        bool guarda();

    }
}
