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
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Imagen.Load(@"C:\Users\tosoj\OneDrive\Documents\Visual Studio 2017\Projects\ServicioTecProyectos\ServicioTecProyectos\Imagenes\FACE02.JPG");
        }

        private void Imagen_Click(object sender, EventArgs e)
        {
            Imagen.Image = Image.FromFile(@"C:\Users\tosoj\OneDrive\Documents\Visual Studio 2017\Projects\ServicioTecProyectos\ServicioTecProyectos\Imagenes\FACE03.JPG");
        }
    }
}
