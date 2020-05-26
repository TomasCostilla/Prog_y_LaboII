using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioConObjetos
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Se pide crear 3 instancias de la clase Alumno(3 objetos) en la función Main. Colocarle
            nombre, apellido y legajo a cada uno de ellos.
            b.Sólo se podrá ingresar las notas(nota1 y nota2) a través del método Estudiar.
            c.El método CalcularFinal deberá colocar la nota del final sólo si las notas 1 y 2 son mayores o
            iguales a 4, caso contrario la inicializará con - 1.Para darle un valor a la nota final utilice
            el método de instancia Next de la clase Random.
            d.El método Mostrar, expondrá en la consola todos los datos de los alumnos. La nota final se
            mostrará sólo si es distinto de -1, caso contrario se mostrará la leyenda "Alumno
            desaprobado".*/

            Console.WriteLine("Ejercicio 11");
            Console.WriteLine("------------");
            Console.WriteLine();


            Alumno alumno1 = new Alumno();
            Alumno alumno2 = new Alumno();
            Alumno alumno3 = new Alumno();

            #region Completando Datos
            alumno1.legajo = 12345;
            alumno1.nombre = "Tomas";
            alumno1.apellido = "Costilla";

            alumno2.legajo = 41589;
            alumno2.nombre = "Pablo";
            alumno2.apellido = "Costilla";

            alumno3.legajo = 78945;
            alumno3.nombre = "Pedro";
            alumno3.apellido = "Guevara";
            #endregion









        }
    }
}
