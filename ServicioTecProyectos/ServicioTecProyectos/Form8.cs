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
    public partial class Form8 : Form
    {
        int movimiento = 10;

        public Form8()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Imagen1.Left += movimiento;
            Imagen2.Left -= movimiento;
            if (Imagen1.Left >= (Imagen2.Left - Imagen1.Width) || Imagen1.Left < 0)
            {
                movimiento = -movimiento;
            }
        }
    }
}
