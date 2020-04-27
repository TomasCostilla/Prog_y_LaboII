using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Ejercicio_33
{
    class Program
    {
        static void Main(string[] args)
        {
            Libro Libro1 = new Libro();

            Libro1[0] = "Tomas";

            Console.WriteLine(Libro1[0]);


        }
    }
}
