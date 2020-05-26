using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class DirectorTecnico : Persona
    {
        private DateTime fechaNacimiento;


        public DateTime FechaNac 
        { 
            get
            {
                return this.fechaNacimiento;
            }
            set
            {
                this.fechaNacimiento = value;
            }
        
        }

        private DirectorTecnico(string nombre) :base(nombre)
        {

        }
        public DirectorTecnico(string nombre, DateTime FchNacimiento) : this(nombre)
        {
            this.fechaNacimiento = FchNacimiento;
        }

        public static bool operator !=(DirectorTecnico d1, DirectorTecnico d2)
        {
            return !(d1 == d2);
        }
        public static bool operator ==(DirectorTecnico d1, DirectorTecnico d2)
        {
            bool iguales = false;
            if(d1.Nombre==d2.Nombre && d1.FechaNac==d2.FechaNac)
            {
                iguales = true;
            }
            return iguales;
        }




    }
}
