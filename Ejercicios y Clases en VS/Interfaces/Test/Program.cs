using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instancio un objeto del tipo Interfaz
            ISeresVivos sres = new Persona("Tomas");

            Console.WriteLine("Objeto Instanciado");
            Console.WriteLine(sres.Descripcion);
            Console.WriteLine();



            //Creo una lista de Interfaces del tipo Persona el cual recorro y muestro a traves de la propiedad "Descripcion"
            //declarada en ISeresVivos y implementada en Persona()
            List<ISeresVivos> seres = new List<ISeresVivos>();
            seres.Add(new Persona("Tomas"));
            seres.Add(new Persona("Pablo"));
            seres.Add(new Persona("Usuario"));
            seres.Add(new Persona("Pedro"));

            Console.WriteLine("Lista de objetos Instanciados");
            foreach (ISeresVivos item in seres)
            {
                Console.WriteLine(item.Descripcion);
            }

            Console.ReadKey();
        }
    }
}
