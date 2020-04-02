using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_16
{
    class Program
    {
        static void Main(string[] args)
        {
            /*a.Se pide crear 3 instancias de la clase Alumno (3 objetos) en la función Main. Colocarle
                nombre, apellido y legajo a cada uno de ellos.
                b. Sólo se podrá ingresar las notas (nota1 y nota2) a través del método Estudiar.
                c. El método CalcularFinal deberá colocar la nota del final sólo si las notas 1 y 2 son mayores o
                iguales a 4, caso contrario la inicializará con -1. Para darle un valor a la nota final utilice
                el método de instancia Next de la clase Random.
                d. El método Mostrar, expondrá en la consola todos los datos de los alumnos. La nota final se
                mostrará sólo si es distinto de -1, caso contrario se mostrará la leyenda "Alumno
                desaprobado".*/

            Alumno alumno1 = new Alumno();
            Alumno alumno2 = new Alumno();
            Alumno alumno3 = new Alumno();

            #region Instanciando Alumnos
            alumno1.legajo = 123;
            alumno1.nombre = "Tomas";
            alumno1.apellido = "Costilla";

            alumno2.legajo = 456;
            alumno2.nombre = "Pedro";
            alumno2.apellido = "Guevara";

            alumno3.legajo = 789;
            alumno3.nombre = "Pablo";
            alumno3.apellido = "Guevara";
            #endregion

            #region Variables
            //Notas Alumno 1
            byte notaAlum1;
            byte notaDosAlum1;

            //Notas Alumno 2
            byte notaAlum2;
            byte notaDosAlum2;

            //Nota Alumno 3
            byte notaAlum3;
            byte notaDosAlum3;
            #endregion


            Console.Write("Ingrese Nota 1 para el alumno1: ");
            notaAlum1 = byte.Parse(Console.ReadLine());
            Console.Write("Ingrese Nota 2 para el alumno1: ");
            notaDosAlum1 = byte.Parse(Console.ReadLine());

            alumno1.Estudiar(notaAlum1, notaDosAlum1);
            

            Console.Write("Ingrese Nota 1 para el alumno2: ");
            notaAlum2 = byte.Parse(Console.ReadLine());
            Console.Write("Ingrese Nota 2 para el alumno2: ");
            notaDosAlum2 = byte.Parse(Console.ReadLine());

            alumno2.Estudiar(notaAlum2, notaDosAlum2);

            Console.Write("Ingrese Nota 1 para el alumno3: ");
            notaAlum3 = byte.Parse(Console.ReadLine());
            Console.Write("Ingrese Nota 2 para el alumno3: ");
            notaDosAlum3 = byte.Parse(Console.ReadLine());

            alumno3.Estudiar(notaAlum3, notaDosAlum3);

            Console.WriteLine(alumno1.Mostrar());
            Console.WriteLine(alumno2.Mostrar());
            Console.WriteLine(alumno3.Mostrar());




        }
    }
}
