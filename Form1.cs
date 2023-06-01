using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TemporizadorContagemRegressiva
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            string[] dataTexto = new string[3];
            dataTexto = txtData.Text.Split('/');
            lblDias.Text = dataTexto[0] + " dias";
            lblHoras.Text = dataTexto[1] + " horas";
            lblMinutos.Text = dataTexto[2] + " minutos";
            //lblSegundos.Text = data.Second.ToString();
            DateTime dataAtual = DateTime.Now;
            DateTime dataEvento = new DateTime();
            txtDataAtual.Text = dataAtual.ToString();
            dataEvento = DateTime.Parse(txtData.Text.ToString());

            var quantosDias = dataEvento.Subtract(dataAtual);
            string[] dias = quantosDias.ToString().Split('.');
            lblDias.Text = dias[0].ToString() + " Dias";
        }

        private void txtData_Click(object sender, EventArgs e)
        {
            txtData.Text = " ";
        }
        private void txtHora_Click(object sender, EventArgs e)
        {
            txtHora.Text = " ";
        }
    }
}
