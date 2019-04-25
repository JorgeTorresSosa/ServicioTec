namespace ServicioTecProyectos
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.CajaMovimiento = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BotonAbajo = new System.Windows.Forms.Button();
            this.BotonDerecha = new System.Windows.Forms.Button();
            this.BotonIzquierda = new System.Windows.Forms.Button();
            this.BotonArriba = new System.Windows.Forms.Button();
            this.Imagen = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Imagen)).BeginInit();
            this.SuspendLayout();
            // 
            // CajaMovimiento
            // 
            this.CajaMovimiento.Location = new System.Drawing.Point(643, 99);
            this.CajaMovimiento.Name = "CajaMovimiento";
            this.CajaMovimiento.Size = new System.Drawing.Size(91, 20);
            this.CajaMovimiento.TabIndex = 13;
            this.CajaMovimiento.Text = "10";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(580, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Espaciado";
            // 
            // BotonAbajo
            // 
            this.BotonAbajo.Location = new System.Drawing.Point(408, 202);
            this.BotonAbajo.Name = "BotonAbajo";
            this.BotonAbajo.Size = new System.Drawing.Size(34, 35);
            this.BotonAbajo.TabIndex = 11;
            this.BotonAbajo.Text = "v";
            this.BotonAbajo.UseVisualStyleBackColor = true;
            this.BotonAbajo.Click += new System.EventHandler(this.BotonAbajo_Click);
            // 
            // BotonDerecha
            // 
            this.BotonDerecha.Location = new System.Drawing.Point(451, 161);
            this.BotonDerecha.Name = "BotonDerecha";
            this.BotonDerecha.Size = new System.Drawing.Size(34, 35);
            this.BotonDerecha.TabIndex = 10;
            this.BotonDerecha.Text = ">";
            this.BotonDerecha.UseVisualStyleBackColor = true;
            this.BotonDerecha.Click += new System.EventHandler(this.BotonDerecha_Click);
            // 
            // BotonIzquierda
            // 
            this.BotonIzquierda.Location = new System.Drawing.Point(363, 161);
            this.BotonIzquierda.Name = "BotonIzquierda";
            this.BotonIzquierda.Size = new System.Drawing.Size(34, 35);
            this.BotonIzquierda.TabIndex = 9;
            this.BotonIzquierda.Text = "<";
            this.BotonIzquierda.UseVisualStyleBackColor = true;
            this.BotonIzquierda.Click += new System.EventHandler(this.BotonIzquierda_Click);
            // 
            // BotonArriba
            // 
            this.BotonArriba.Location = new System.Drawing.Point(408, 119);
            this.BotonArriba.Name = "BotonArriba";
            this.BotonArriba.Size = new System.Drawing.Size(34, 35);
            this.BotonArriba.TabIndex = 8;
            this.BotonArriba.Text = "^";
            this.BotonArriba.UseVisualStyleBackColor = true;
            this.BotonArriba.Click += new System.EventHandler(this.BotonArriba_Click);
            // 
            // Imagen
            // 
            this.Imagen.Image = global::ServicioTecProyectos.Properties.Resources.FACE01;
            this.Imagen.Location = new System.Drawing.Point(48, 185);
            this.Imagen.Name = "Imagen";
            this.Imagen.Size = new System.Drawing.Size(124, 126);
            this.Imagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Imagen.TabIndex = 7;
            this.Imagen.TabStop = false;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CajaMovimiento);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BotonAbajo);
            this.Controls.Add(this.BotonDerecha);
            this.Controls.Add(this.BotonIzquierda);
            this.Controls.Add(this.BotonArriba);
            this.Controls.Add(this.Imagen);
            this.Name = "Form3";
            this.Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)(this.Imagen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox CajaMovimiento;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BotonAbajo;
        private System.Windows.Forms.Button BotonDerecha;
        private System.Windows.Forms.Button BotonIzquierda;
        private System.Windows.Forms.Button BotonArriba;
        private System.Windows.Forms.PictureBox Imagen;
    }
}