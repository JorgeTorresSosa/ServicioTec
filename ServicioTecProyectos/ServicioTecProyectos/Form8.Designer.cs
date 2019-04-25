namespace ServicioTecProyectos
{
    partial class Form8
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
            this.Imagen2 = new System.Windows.Forms.PictureBox();
            this.Imagen1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Imagen2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Imagen1)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Imagen2
            // 
            this.Imagen2.Image = global::ServicioTecProyectos.Properties.Resources.FACE03;
            this.Imagen2.Location = new System.Drawing.Point(671, 99);
            this.Imagen2.Name = "Imagen2";
            this.Imagen2.Size = new System.Drawing.Size(117, 111);
            this.Imagen2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Imagen2.TabIndex = 3;
            this.Imagen2.TabStop = false;
            // 
            // Imagen1
            // 
            this.Imagen1.Image = global::ServicioTecProyectos.Properties.Resources.FACE01;
            this.Imagen1.Location = new System.Drawing.Point(12, 99);
            this.Imagen1.Name = "Imagen1";
            this.Imagen1.Size = new System.Drawing.Size(117, 111);
            this.Imagen1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Imagen1.TabIndex = 2;
            this.Imagen1.TabStop = false;
            // 
            // Form8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Imagen2);
            this.Controls.Add(this.Imagen1);
            this.Name = "Form8";
            this.Text = "Form8";
            ((System.ComponentModel.ISupportInitialize)(this.Imagen2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Imagen1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox Imagen2;
        private System.Windows.Forms.PictureBox Imagen1;
    }
}