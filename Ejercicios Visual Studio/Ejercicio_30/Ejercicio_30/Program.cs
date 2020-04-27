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
            Competencia Comp1 = new Competencia(10, 3, Competencia.TipoCompetencia.F1);

            AutoF1 a1 = new AutoF1(1234, "Rojo", 120);
            AutoF1 a2 = new AutoF1(4567, "Verde", 120);

         
             if(a1 is VehiculoDeCarrera)
            {
                Console.WriteLine("Lo es");
            }

            Console.WriteLine(Comp1.MostrarDatos());

            bool resultado = Comp1 + a1;
            if(resultado==true)
            {
                Console.WriteLine("Inserto!");
            }

            MotoCross m1 = new MotoCross(12346, "Marron", 5);

            bool resultadoM = Comp1 + m1;

            if(resultadoM==false)
            {
                Console.WriteLine("No se puede agregar una moto a una carrera de autos!");
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
