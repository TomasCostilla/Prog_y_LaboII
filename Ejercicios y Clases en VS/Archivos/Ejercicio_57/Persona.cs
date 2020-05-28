using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace Ejercicio_57
{
    public class Persona
    {
        private string nombre;
        private string apellido;

        public Persona(string nom,string apellido)
        {
            this.nombre = nom;
            this.apellido = apellido;
        }

        public static void Guardar(Persona p)
        {
            Persona aux = p;

            XmlTextWriter writer;
            XmlSerializer ser;

            writer = new XmlTextWriter("C:\\Users\\tomas\\Desktop\\", Encoding.UTF8);
            ser = new XmlSerializer(typeof(aux));

        }
        public static void Leer()
        {

        }


    }
}
