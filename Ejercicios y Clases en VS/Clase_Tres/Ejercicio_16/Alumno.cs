﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_16
{
    public class Alumno
    {
        private byte nota1;
        private byte nota2;
        private float notafinal;
        public string apellido;
        public int legajo;
        public string nombre;

        public void CalcularFinal()
        {/* c. El método CalcularFinal deberá colocar la nota del final sólo si las notas 1 y 2 son mayores o
                iguales a 4, caso contrario la inicializará con -1. Para darle un valor a la nota final utilice
                el método de instancia Next de la clase Random.*/
            Random numAleat = new Random();
            int numero = 0;
            
            numero = numAleat.Next(5,10);
            this.notafinal = numero;
        }

        public void Estudiar(byte notaUno,byte notaDos)
        {
            this.nota1 = notaUno;
            this.nota2 = notaDos;

            if (nota1 >= 4 && nota2 >= 4)
            {
                this.CalcularFinal();
            }
            else
                this.notafinal = -1;
        }

        public string Mostrar()
        {
            /*d.El método Mostrar, expondrá en la consola todos los datos de los alumnos. La nota final se
                mostrará sólo si es distinto de -1, caso contrario se mostrará la leyenda "Alumno
                desaprobado".*/

            StringBuilder muestra = new StringBuilder();
            string resultado = null;

            if (this.notafinal != -1)
            {

                muestra.AppendLine("Legajo: " + this.legajo);
                muestra.AppendLine("Nombre: " + this.nombre);
                muestra.AppendLine("Apellido: " + this.apellido);
                muestra.AppendLine("Nota Uno: " + this.nota1);
                muestra.AppendLine("Nota Dos: " + this.nota2);
                muestra.AppendLine("Nota Final: " + this.notafinal);
                resultado = muestra.ToString();

            }
            else
            {
                muestra.AppendLine("Desaprobado!");
                resultado = muestra.ToString();

            }



            return resultado;
        }


    }
}
