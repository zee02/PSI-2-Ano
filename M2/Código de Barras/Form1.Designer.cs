namespace Código_de_Barras
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
            this.mtxtEmpresa = new System.Windows.Forms.MaskedTextBox();
            this.mtxtPais = new System.Windows.Forms.MaskedTextBox();
            this.mtxtProduto = new System.Windows.Forms.MaskedTextBox();
            this.lblControlo = new System.Windows.Forms.Label();
            this.btnGerar = new System.Windows.Forms.Button();
            this.lblBarras = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // mtxtEmpresa
            // 
            this.mtxtEmpresa.Location = new System.Drawing.Point(158, 56);
            this.mtxtEmpresa.Mask = "0000";
            this.mtxtEmpresa.Name = "mtxtEmpresa";
            this.mtxtEmpresa.Size = new System.Drawing.Size(57, 20);
            this.mtxtEmpresa.TabIndex = 0;
            this.mtxtEmpresa.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // mtxtPais
            // 
            this.mtxtPais.Location = new System.Drawing.Point(53, 57);
            this.mtxtPais.Mask = "000";
            this.mtxtPais.Name = "mtxtPais";
            this.mtxtPais.Size = new System.Drawing.Size(57, 20);
            this.mtxtPais.TabIndex = 1;
            this.mtxtPais.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mtxtPais.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.MtxtPais_MaskInputRejected);
            // 
            // mtxtProduto
            // 
            this.mtxtProduto.Location = new System.Drawing.Point(263, 56);
            this.mtxtProduto.Mask = "00000";
            this.mtxtProduto.Name = "mtxtProduto";
            this.mtxtProduto.Size = new System.Drawing.Size(53, 20);
            this.mtxtProduto.TabIndex = 2;
            this.mtxtProduto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblControlo
            // 
            this.lblControlo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblControlo.Location = new System.Drawing.Point(353, 56);
            this.lblControlo.Name = "lblControlo";
            this.lblControlo.Size = new System.Drawing.Size(50, 20);
            this.lblControlo.TabIndex = 3;
            this.lblControlo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblControlo.Click += new System.EventHandler(this.Label1_Click);
            // 
            // btnGerar
            // 
            this.btnGerar.Location = new System.Drawing.Point(158, 131);
            this.btnGerar.Name = "btnGerar";
            this.btnGerar.Size = new System.Drawing.Size(124, 40);
            this.btnGerar.TabIndex = 4;
            this.btnGerar.Text = "Gerar Código";
            this.btnGerar.UseVisualStyleBackColor = true;
            this.btnGerar.Click += new System.EventHandler(this.Button1_Click);
            // 
            // lblBarras
            // 
            this.lblBarras.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblBarras.Font = new System.Drawing.Font("EAN-13", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBarras.Location = new System.Drawing.Point(90, 218);
            this.lblBarras.Name = "lblBarras";
            this.lblBarras.Size = new System.Drawing.Size(252, 106);
            this.lblBarras.TabIndex = 5;
            this.lblBarras.Text = "0000000000000";
            this.lblBarras.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(167, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Empresa";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(61, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "País";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(269, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Produto";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(357, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Controlo";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 379);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblBarras);
            this.Controls.Add(this.btnGerar);
            this.Controls.Add(this.lblControlo);
            this.Controls.Add(this.mtxtProduto);
            this.Controls.Add(this.mtxtPais);
            this.Controls.Add(this.mtxtEmpresa);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Código de Barras EAN-13";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox mtxtEmpresa;
        private System.Windows.Forms.MaskedTextBox mtxtPais;
        private System.Windows.Forms.MaskedTextBox mtxtProduto;
        private System.Windows.Forms.Label lblControlo;
        private System.Windows.Forms.Button btnGerar;
        private System.Windows.Forms.Label lblBarras;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}

