namespace ListBox
{
    partial class Form1
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
            this.lstAleatorios = new System.Windows.Forms.ListBox();
            this.btnGerar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnJanela = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstAleatorios
            // 
            this.lstAleatorios.FormattingEnabled = true;
            this.lstAleatorios.Location = new System.Drawing.Point(98, 111);
            this.lstAleatorios.Name = "lstAleatorios";
            this.lstAleatorios.Size = new System.Drawing.Size(92, 147);
            this.lstAleatorios.TabIndex = 0;
            // 
            // btnGerar
            // 
            this.btnGerar.Location = new System.Drawing.Point(12, 47);
            this.btnGerar.Name = "btnGerar";
            this.btnGerar.Size = new System.Drawing.Size(101, 30);
            this.btnGerar.TabIndex = 1;
            this.btnGerar.Text = "Gerar lista";
            this.btnGerar.UseVisualStyleBackColor = true;
            this.btnGerar.Click += new System.EventHandler(this.BtnGerar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(180, 47);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(106, 30);
            this.btnLimpar.TabIndex = 2;
            this.btnLimpar.Text = "Limpar Lista";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.BtnLimpar_Click);
            // 
            // btnJanela
            // 
            this.btnJanela.Location = new System.Drawing.Point(211, 198);
            this.btnJanela.Name = "btnJanela";
            this.btnJanela.Size = new System.Drawing.Size(75, 23);
            this.btnJanela.TabIndex = 3;
            this.btnJanela.Text = "Janela";
            this.btnJanela.UseVisualStyleBackColor = true;
            this.btnJanela.Click += new System.EventHandler(this.BtnJanela_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 291);
            this.Controls.Add(this.btnJanela);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnGerar);
            this.Controls.Add(this.lstAleatorios);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstAleatorios;
        private System.Windows.Forms.Button btnGerar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnJanela;
    }
}

