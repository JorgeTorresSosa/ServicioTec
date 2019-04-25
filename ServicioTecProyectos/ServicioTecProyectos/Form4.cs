using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ServicioTecProyectos
{
    public partial class Form4 : Form
    {
        int contador1 = 0;
        public Form4()
        {
            InitializeComponent();
        }

        private void BotonIntervalo_Click(object sender, EventArgs e)
        {
            timer1.Interval = int.Parse(CajaIntervalo.Text);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            contador1++;
            labelcontador.Text = contador1.ToString();
        }
    }
}
