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
    public partial class Form1 : Form
    {
        Form[] formas = new Form[9];
        int contador = 0;
        public Form1()
        {
            InitializeComponent();
            formas[0] = new Form10();
            formas[1] = new Form2();
            formas[2] = new Form3();
            formas[3] = new Form4();
            formas[4] = new Form5();
            formas[5] = new Form7();
            formas[6] = new Form6();
            formas[7] = new Form8();
            formas[8] = new Form9();
        }

        private void BotonAtras_Click(object sender, EventArgs e)
        {
            if (contador > 0)
            {
                contador--;
                FormaEnPanel(formas[contador]);

            }
        }

        private void BotonSiguiente_Click(object sender, EventArgs e)
        {
            if (contador < 8)
            {
                contador++;
                FormaEnPanel(formas[contador]);

            }
        }

        private void FormaEnPanel(object formahija)
        {
            if (this.panel1.Controls.Count > 0)
            {
                this.panel1.Controls.RemoveAt(0);
            }
            Form forma = formahija as Form;
            forma.TopLevel = false;
            forma.Dock = DockStyle.Fill;
            this.panel1.Controls.Add(forma);
            this.panel1.Tag = forma;
            forma.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FormaEnPanel(formas[contador]);
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            panel1.Width = this.Width;
            panel1.Height = this.Height - 100;
            BotonAtras.Top = this.Height - 80;
            BotonSiguiente.Top = this.Height - 80;
            BotonSiguiente.Left = this.Width - (BotonSiguiente.Width + 30);
        }
    }
}
