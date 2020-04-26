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

            if(Comp1+auto1==false)
            {
                Console.WriteLine("Agrego");
                Console.WriteLine(auto1.MostrarDatos());
            }

            

            Console.ReadKey();
            

           /* List<AutoF1> corredores = new List<AutoF1>();
            AutoF1 auto1 = new AutoF1(123, "Tom");
            AutoF1 auto2 = new AutoF1(125, "Tomas");
            AutoF1 auto3 = new AutoF1(126, "To");

            corredores.Add(auto1);
            corredores.Add(auto2);
            corredores.Add(auto3);

            foreach (AutoF1 item in corredores)
            {
                Console.WriteLine(item.MostrarDatos());
            }*/



        }
    }
}
