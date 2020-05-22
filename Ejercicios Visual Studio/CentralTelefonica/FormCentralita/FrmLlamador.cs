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

        public TipoLlamada TpoLlamada 
        { 
           set
            {
                this.tp = value;
            }
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
                this.TpoLlamada = TipoLlamada.Local;
            }
            else
            {
                this.primerNumero = "#";
                this.TpoLlamada = TipoLlamada.Provincial;
                txtNroDestino.Text += n;
            }
                
        }

        private void cmbFranja_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbFranja.DataSource = Enum.GetValues(typeof(Franja));

            Franja franjas;
            Enum.TryParse<Franja>(cmbFranja.SelectedValue.ToString(), out franjas);
        }

        private void btnLlamar_Click(object sender, EventArgs e)
        {
           if(tp==TipoLlamada.Local)
            {
                Random dur = new Random();
                Random cost = new Random();
                float RandomDuracion = dur.Next(1, 50);
                float costo1 = (float)0.5;
                float costo2 = (float)5.6;
                float costo = cost.Next((int)costo1,(int)costo2);

                Local l1 = new Local(txtNroOrigen.Text, RandomDuracion, txtNroDestino.Text, costo);

            }
           if(primerNumero=="#")
            {
                Random dur = new Random();
                Random cost = new Random();
                float RandomDuracion = dur.Next(1, 50);
                float costo1 = (float)0.5;
                float costo2 = (float)5.6;
                float costo = cost.Next((int)costo1, (int)costo2);
                Provincial l1 = new Provincial(txtNroOrigen.Text, Franja.Franja_1, RandomDuracion, txtNroDestino.Text);

            }

            

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
