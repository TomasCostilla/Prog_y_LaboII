using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CentralitaHerencia;

namespace FormCentralita
{
    public partial class FrmMenu : Form
    {
        private Centralita central;

        public FrmMenu()
        {
            InitializeComponent();
        }

        private void btnGenerarLlamada_Click(object sender, EventArgs e)
        {
            central = new Centralita("Empresa de TOM");

            FrmLlamador formLlamador = new FrmLlamador(central);
            formLlamador.ShowDialog();



        }
    }
}
