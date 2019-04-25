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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void BotonIzquierda_Click(object sender, EventArgs e)
        {
            Imagen.Left -= int.Parse(CajaMovimiento.Text);
        }

        private void BotonArriba_Click(object sender, EventArgs e)
        {
            Imagen.Top -= int.Parse(CajaMovimiento.Text);
        }

        private void BotonDerecha_Click(object sender, EventArgs e)
        {
            Imagen.Left += int.Parse(CajaMovimiento.Text);
        }

        private void BotonAbajo_Click(object sender, EventArgs e)
        {
            Imagen.Top += int.Parse(CajaMovimiento.Text);
        }
    }
}
