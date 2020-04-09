using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StringBuilder datos = new StringBuilder();
            datos.AppendLine("Nombre: " + TextNombre.Text);
            datos.AppendLine("Apellido: " + TextApellido.Text);
            datos.AppendLine("Fecha de nacimiento: " + FechNac.SelectionRange);
            datos.AppendLine("Edad: " + TextEdad.Text);
            datos.AppendLine("Genero: " + ComboGen.Text);

            int error = 0;


            if(TextNombre.Text=="")
            {
                MessageBox.Show("Nombre vacio!");
                error = 1;
            }
            else if(TextApellido.Text=="")
            {
                MessageBox.Show("Apellido vacio!");
                error = 1;
            }
            else if (TextEdad.Text == "")
            {
                MessageBox.Show("Edad vacio!");
                error = 1;
            }
            else if (ComboGen.Text == "")
            {
                MessageBox.Show("Genero vacio!");
                error = 1;
            }

            if (error==0)
            {
                if(MessageBox.Show(datos.ToString(), "Boton", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    this.Close();
                }             
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
           
            MessageBox.Show("Estas seguro que deseas cerrar?","Boton", MessageBoxButtons.YesNo,MessageBoxIcon.Error);
            
                
            
        }
    }
}
