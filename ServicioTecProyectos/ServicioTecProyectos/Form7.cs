﻿using System;
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
    public partial class Form7 : Form
    {
        int movimiento = 30;

        public Form7()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Imagen.Left > this.Width)
            {
                Imagen.Left = -Imagen.Width;
            }
            Imagen.Left += movimiento;
        }

        private void Imagen_Click(object sender, EventArgs e)
        {

        }
    }
}
