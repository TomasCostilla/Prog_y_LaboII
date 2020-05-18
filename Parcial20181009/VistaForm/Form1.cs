using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace VistaForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PickUp p1 = new PickUp(textBox1.Text, textBox2.Text);
            
            MessageBox.Show(p1.ConsultarDatos(),"Informacion",MessageBoxButtons.OK);
        }
    }
}
