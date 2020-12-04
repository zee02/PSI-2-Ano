namespace Exercício_de_Aula_sobre_Ficheiros
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
            this.lblFrase = new System.Windows.Forms.Label();
            this.rtbEscreve = new System.Windows.Forms.RichTextBox();
            this.rtbLer = new System.Windows.Forms.RichTextBox();
            this.btnEscrever = new System.Windows.Forms.Button();
            this.btnLer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblFrase
            // 
            this.lblFrase.AutoSize = true;
            this.lblFrase.Location = new System.Drawing.Point(12, 67);
            this.lblFrase.Name = "lblFrase";
            this.lblFrase.Size = new System.Drawing.Size(36, 13);
            this.lblFrase.TabIndex = 0;
            this.lblFrase.Text = "Frase:";
            // 
            // rtbEscreve
            // 
            this.rtbEscreve.Location = new System.Drawing.Point(15, 83);
            this.rtbEscreve.Name = "rtbEscreve";
            this.rtbEscreve.Size = new System.Drawing.Size(212, 127);
            this.rtbEscreve.TabIndex = 1;
            this.rtbEscreve.Text = "";
            this.rtbEscreve.TextChanged += new System.EventHandler(this.RtbEscreve_TextChanged);
            // 
            // rtbLer
            // 
            this.rtbLer.Location = new System.Drawing.Point(293, 98);
            this.rtbLer.Name = "rtbLer";
            this.rtbLer.Size = new System.Drawing.Size(218, 126);
            this.rtbLer.TabIndex = 2;
            this.rtbLer.Text = "";
            // 
            // btnEscrever
            // 
            this.btnEscrever.Location = new System.Drawing.Point(48, 224);
            this.btnEscrever.Name = "btnEscrever";
            this.btnEscrever.Size = new System.Drawing.Size(146, 23);
            this.btnEscrever.TabIndex = 3;
            this.btnEscrever.Text = "Escrever no ficheiro";
            this.btnEscrever.UseVisualStyleBackColor = true;
            this.btnEscrever.Click += new System.EventHandler(this.BtnEscrever_Click);
            // 
            // btnLer
            // 
            this.btnLer.Location = new System.Drawing.Point(326, 62);
            this.btnLer.Name = "btnLer";
            this.btnLer.Size = new System.Drawing.Size(152, 23);
            this.btnLer.TabIndex = 4;
            this.btnLer.Text = "Ler do ficheiro";
            this.btnLer.UseVisualStyleBackColor = true;
            this.btnLer.Click += new System.EventHandler(this.BtnLer_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 259);
            this.Controls.Add(this.btnLer);
            this.Controls.Add(this.btnEscrever);
            this.Controls.Add(this.rtbLer);
            this.Controls.Add(this.rtbEscreve);
            this.Controls.Add(this.lblFrase);
            this.Name = "Form1";
            this.Text = "Ficheiros";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFrase;
        private System.Windows.Forms.RichTextBox rtbEscreve;
        private System.Windows.Forms.RichTextBox rtbLer;
        private System.Windows.Forms.Button btnEscrever;
        private System.Windows.Forms.Button btnLer;
    }
}

