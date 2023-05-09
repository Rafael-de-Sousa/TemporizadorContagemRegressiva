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
            DateTime DataHora = DateTime.Now;
            lblDias.Text = DataHora.Day.ToString();
            lblHoras.Text = DataHora.Hour.ToString();
            lblMinutos.Text = DataHora.Minute.ToString();
            lblSegundos.Text = DataHora.Second.ToString();
        }
    }
}
