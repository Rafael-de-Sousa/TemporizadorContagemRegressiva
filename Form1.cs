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
        }
    }
}
