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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void BotonCambios_Click(object sender, EventArgs e)
        {
            Imagen.Left = int.Parse(CajaPosicionX.Text);
            Imagen.Top = int.Parse(CajaPosicionY.Text);
            Imagen.Width = int.Parse(CajaAncho.Text);
            Imagen.Height = int.Parse(CajaLargo.Text);
        }
    }
}
