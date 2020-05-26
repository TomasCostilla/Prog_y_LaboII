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
using ControlCantina;

namespace WindowsFormsApp1
{
    public partial class FrmCantina : Form
    {
        public FrmCantina()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void FrmCantina_Load(object sender, EventArgs e)
        {
            this.barra1.SetCantina = Cantina.GetCantina(6);
            comboBoxTipo.DataSource = Enum.GetValues(typeof(Botella.Tipo));

            Botella.Tipo tipo;
            Enum.TryParse<Botella.Tipo>(comboBoxTipo.SelectedValue.ToString(), out tipo);
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            /*Al presionar el botón Agregar se agregará una nueva botella al objeto Barra teniendo en cuenta
            los RadioButton (si se encuentra seleccionado Cerveza se creará una nueva botella de ese tipo, y
            si se encuentra Agua una botella de agua).*/

            if(RCerveza.Checked)
            { 
                Cerveza cerv = new Cerveza((int)numericUpDownCap.Value, textBoxMarca.Text,(int)numericUpDown2.Value);
                barra1.AgregarBotella(cerv);
            }
            else
            {
                Agua agua = new Agua((int)numericUpDownCap.Value, textBoxMarca.Text, (int)numericUpDown2.Value);
                barra1.AgregarBotella(agua);
            }


        }
    }
}
