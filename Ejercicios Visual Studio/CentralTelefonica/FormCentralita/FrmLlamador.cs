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
    public partial class FrmLlamador : Form
    {
        private TipoLlamada tp;
        private string primerNumero;

        public FrmLlamador(Centralita central)
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

            //txtNroDestino.Text = numero.ToString();
        }

        private void txtNroDestino_TextChanged(object sender, EventArgs e)
        {
            

        }

        private void btnUno_Click(object sender, EventArgs e)
        {
            AgregaNumero(btnUno.Text);
        }

        private void btnDos_Click(object sender, EventArgs e)
        {
            AgregaNumero(btnDos.Text);
        }

        private void btnNum_Click(object sender, EventArgs e)
        {
            AgregaNumero(btnNum.Text);
        }

        private void btnTres_Click(object sender, EventArgs e)
        {
            AgregaNumero(btnTres.Text);
        }

        private void btnCuatro_Click(object sender, EventArgs e)
        {
            AgregaNumero(btnCuatro.Text);
        }

        private void btnCinco_Click(object sender, EventArgs e)
        {
            AgregaNumero(btnCinco.Text);
        }

        private void btnSeis_Click(object sender, EventArgs e)
        {
            AgregaNumero(btnSeis.Text);
        }

        private void btnSiete_Click(object sender, EventArgs e)
        {
            AgregaNumero(btnSiete.Text);
        }

        private void btnOcho_Click(object sender, EventArgs e)
        {
            AgregaNumero(btnOcho.Text);
        }

        private void btnNueve_Click(object sender, EventArgs e)
        {
            AgregaNumero(btnNueve.Text);
        }

        private void btnAst_Click(object sender, EventArgs e)
        {
            AgregaNumero(btnAst.Text);
        }

        private void btnCero_Click(object sender, EventArgs e)
        {
            AgregaNumero(btnCero.Text);
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNroDestino.Clear();
        }

        public void AgregaNumero(string n)
        {
            if(n!="#")
            {
                txtNroDestino.Text += n;
            }
            else
            {
                this.primerNumero = "#";
                this.tp = TipoLlamada.Provincial;
                txtNroDestino.Text += n;
            }
                
        }

        private void cmbFranja_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbFranja.DataSource = Enum.GetValues(typeof(Franja));

            Franja franjas;
            Enum.TryParse<Franja>(cmbFranja.SelectedValue.ToString(), out franjas);
        }
    }
}
