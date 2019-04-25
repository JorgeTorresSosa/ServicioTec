namespace ServicioTecProyectos
{
    partial class Form4
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
            this.CajaIntervalo = new System.Windows.Forms.TextBox();
            this.labelcontador = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.BotonIntervalo = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CajaIntervalo
            // 
            this.CajaIntervalo.Location = new System.Drawing.Point(391, 37);
            this.CajaIntervalo.Name = "CajaIntervalo";
            this.CajaIntervalo.Size = new System.Drawing.Size(100, 20);
            this.CajaIntervalo.TabIndex = 8;
            // 
            // labelcontador
            // 
            this.labelcontador.AutoSize = true;
            this.labelcontador.Location = new System.Drawing.Point(114, 44);
            this.labelcontador.Name = "labelcontador";
            this.labelcontador.Size = new System.Drawing.Size(13, 13);
            this.labelcontador.TabIndex = 6;
            this.labelcontador.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Ciclo contador";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // BotonIntervalo
            // 
            this.BotonIntervalo.Location = new System.Drawing.Point(578, 29);
            this.BotonIntervalo.Name = "BotonIntervalo";
            this.BotonIntervalo.Size = new System.Drawing.Size(83, 35);
            this.BotonIntervalo.TabIndex = 9;
            this.BotonIntervalo.Text = "button1";
            this.BotonIntervalo.UseVisualStyleBackColor = true;
            this.BotonIntervalo.Click += new System.EventHandler(this.BotonIntervalo_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(340, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "intervalo";
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CajaIntervalo);
            this.Controls.Add(this.labelcontador);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BotonIntervalo);
            this.Controls.Add(this.label2);
            this.Name = "Form4";
            this.Text = "Form4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox CajaIntervalo;
        private System.Windows.Forms.Label labelcontador;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button BotonIntervalo;
        private System.Windows.Forms.Label label2;
    }
}