using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_56
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = "C:\\";
            //openFileDialog1.Filter = ""
            string FilePath = string.Empty;


            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                FilePath = openFileDialog1.FileName;

                using (StreamReader arch = new StreamReader(FilePath))
                {
                    richTextBox1.Text = arch.ReadToEnd();
                }
            }
        }

        private void guardarCntrlSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.InitialDirectory = "C:\\";

            string FilePath = string.Empty;

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                FilePath = saveFileDialog1.FileName;
                Guardado(FilePath);
                MessageBox.Show("Guardado!","Guardado", MessageBoxButtons.OK);

                //using (StreamWriter arch = new StreamWriter(FilePath))
                //{
                //    arch.WriteLine(richTextBox1.Text);
                //}
            }
        }

        private void guardarComoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.InitialDirectory = "C:\\";

            string FilePath = string.Empty;

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                FilePath = saveFileDialog1.FileName;
                Guardado(FilePath);
                MessageBox.Show("Guardado!", "Guardado", MessageBoxButtons.OK);
            }
        }


        private void Guardado(string path)
        {
            try
            {
                using (StreamWriter arch = new StreamWriter(path))
                {
                    arch.WriteLine(richTextBox1.Text);
                }
            }
            catch (SecurityException a)
            {
                //
            }
            catch (ArgumentException b)
            {
                Console.WriteLine(b.Message);
            }
        }


    }
}
