namespace ServicioTecProyectos
{
    partial class Form5
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
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.BotonRestablecer = new System.Windows.Forms.Button();
            this.Imagen = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Imagen)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // BotonRestablecer
            // 
            this.BotonRestablecer.Location = new System.Drawing.Point(636, 54);
            this.BotonRestablecer.Name = "BotonRestablecer";
            this.BotonRestablecer.Size = new System.Drawing.Size(105, 71);
            this.BotonRestablecer.TabIndex = 3;
            this.BotonRestablecer.Text = "Reestablecer";
            this.BotonRestablecer.UseVisualStyleBackColor = true;
            this.BotonRestablecer.Click += new System.EventHandler(this.BotonRestablecer_Click);
            // 
            // Imagen
            // 
            this.Imagen.Image = global::ServicioTecProyectos.Properties.Resources.FACE03;
            this.Imagen.Location = new System.Drawing.Point(12, 12);
            this.Imagen.Name = "Imagen";
            this.Imagen.Size = new System.Drawing.Size(159, 151);
            this.Imagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Imagen.TabIndex = 2;
            this.Imagen.TabStop = false;
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BotonRestablecer);
            this.Controls.Add(this.Imagen);
            this.Name = "Form5";
            this.Text = "Form5";
            ((System.ComponentModel.ISupportInitialize)(this.Imagen)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button BotonRestablecer;
        private System.Windows.Forms.PictureBox Imagen;
    }
}