using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Ejercicio_30
{
    class Program
    {
        static void Main(string[] args)
        {
            Competencia Comp1 = new Competencia(10, 5);
            AutoF1 auto1 = new AutoF1(123, "Tom");
            AutoF1 auto2 = new AutoF1(456, "Pedro");

            Console.WriteLine(Comp1.MostrarDatos());


             if(Comp1+auto1==false)
             {
                 Console.WriteLine("Se agrego el auto a la competencia!");
             }

         


        }
    }
}
