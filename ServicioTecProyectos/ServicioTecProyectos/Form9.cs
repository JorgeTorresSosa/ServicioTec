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
    public partial class Form9 : Form
    {
        int MovimientoX = 10, movimientoY = 15;

        public Form9()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Imagen1.Left += MovimientoX;
            Imagen1.Top += movimientoY;
            if (Imagen1.Left >= (this.Width - Imagen1.Width) || Imagen1.Left <= 0)
            {
                MovimientoX = -MovimientoX;
            }
            else if (Imagen1.Top >= (this.Height - Imagen1.Height) || Imagen1.Top < 0)
            {
                movimientoY = -movimientoY;
            }

        }

        private void Imagen1_Click(object sender, EventArgs e)
        {

        }
    }
}
