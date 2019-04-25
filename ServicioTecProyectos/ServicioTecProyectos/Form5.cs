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
    public partial class Form5 : Form
    {
        int moviminetoX = 50, moviminetoY = 10;

        public Form5()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Imagen.Left += moviminetoX;
            Imagen.Top += moviminetoY;
        }

        private void BotonRestablecer_Click(object sender, EventArgs e)
        {
            Imagen.Left = 0;
            Imagen.Top = 0;
        }
    }
}
