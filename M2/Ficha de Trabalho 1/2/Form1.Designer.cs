namespace _2
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
            this.lblValorG = new System.Windows.Forms.Label();
            this.lblGasto = new System.Windows.Forms.Label();
            this.lblPreco = new System.Windows.Forms.Label();
            this.lblKms = new System.Windows.Forms.Label();
            this.lblRegistado = new System.Windows.Forms.Label();
            this.lblConsumo = new System.Windows.Forms.Label();
            this.lblRegisto = new System.Windows.Forms.Label();
            this.txtKms = new System.Windows.Forms.TextBox();
            this.txtPreco = new System.Windows.Forms.TextBox();
            this.txtConsumo = new System.Windows.Forms.TextBox();
            this.btnCalcula = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblValorG
            // 
            this.lblValorG.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblValorG.Location = new System.Drawing.Point(227, 289);
            this.lblValorG.Name = "lblValorG";
            this.lblValorG.Size = new System.Drawing.Size(86, 20);
            this.lblValorG.TabIndex = 0;
            // 
            // lblGasto
            // 
            this.lblGasto.AutoSize = true;
            this.lblGasto.Location = new System.Drawing.Point(43, 289);
            this.lblGasto.Name = "lblGasto";
            this.lblGasto.Size = new System.Drawing.Size(60, 13);
            this.lblGasto.TabIndex = 1;
            this.lblGasto.Text = "Valor gasto";
            // 
            // lblPreco
            // 
            this.lblPreco.AutoSize = true;
            this.lblPreco.Location = new System.Drawing.Point(43, 161);
            this.lblPreco.Name = "lblPreco";
            this.lblPreco.Size = new System.Drawing.Size(110, 13);
            this.lblPreco.TabIndex = 2;
            this.lblPreco.Text = "Preço do Combustivel";
            // 
            // lblKms
            // 
            this.lblKms.AutoSize = true;
            this.lblKms.Location = new System.Drawing.Point(43, 39);
            this.lblKms.Name = "lblKms";
            this.lblKms.Size = new System.Drawing.Size(83, 13);
            this.lblKms.TabIndex = 3;
            this.lblKms.Text = "Kms Percurridos";
            // 
            // lblRegistado
            // 
            this.lblRegistado.AutoSize = true;
            this.lblRegistado.Location = new System.Drawing.Point(43, 249);
            this.lblRegistado.Name = "lblRegistado";
            this.lblRegistado.Size = new System.Drawing.Size(102, 13);
            this.lblRegistado.TabIndex = 4;
            this.lblRegistado.Text = "Consumo Registado";
            // 
            // lblConsumo
            // 
            this.lblConsumo.AutoSize = true;
            this.lblConsumo.Location = new System.Drawing.Point(43, 100);
            this.lblConsumo.Name = "lblConsumo";
            this.lblConsumo.Size = new System.Drawing.Size(102, 13);
            this.lblConsumo.TabIndex = 5;
            this.lblConsumo.Text = "Consumo Registado";
            // 
            // lblRegisto
            // 
            this.lblRegisto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblRegisto.Location = new System.Drawing.Point(227, 248);
            this.lblRegisto.Name = "lblRegisto";
            this.lblRegisto.Size = new System.Drawing.Size(86, 20);
            this.lblRegisto.TabIndex = 6;
            // 
            // txtKms
            // 
            this.txtKms.Location = new System.Drawing.Point(227, 39);
            this.txtKms.Name = "txtKms";
            this.txtKms.Size = new System.Drawing.Size(100, 20);
            this.txtKms.TabIndex = 7;
            // 
            // txtPreco
            // 
            this.txtPreco.Location = new System.Drawing.Point(227, 158);
            this.txtPreco.Name = "txtPreco";
            this.txtPreco.Size = new System.Drawing.Size(100, 20);
            this.txtPreco.TabIndex = 8;
            // 
            // txtConsumo
            // 
            this.txtConsumo.Location = new System.Drawing.Point(227, 97);
            this.txtConsumo.Name = "txtConsumo";
            this.txtConsumo.Size = new System.Drawing.Size(100, 20);
            this.txtConsumo.TabIndex = 9;
            // 
            // btnCalcula
            // 
            this.btnCalcula.Location = new System.Drawing.Point(213, 201);
            this.btnCalcula.Name = "btnCalcula";
            this.btnCalcula.Size = new System.Drawing.Size(100, 26);
            this.btnCalcula.TabIndex = 10;
            this.btnCalcula.Text = "Calcular";
            this.btnCalcula.UseVisualStyleBackColor = true;
            this.btnCalcula.Click += new System.EventHandler(this.BtnCalcula_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(343, 332);
            this.Controls.Add(this.btnCalcula);
            this.Controls.Add(this.txtConsumo);
            this.Controls.Add(this.txtPreco);
            this.Controls.Add(this.txtKms);
            this.Controls.Add(this.lblRegisto);
            this.Controls.Add(this.lblConsumo);
            this.Controls.Add(this.lblRegistado);
            this.Controls.Add(this.lblKms);
            this.Controls.Add(this.lblPreco);
            this.Controls.Add(this.lblGasto);
            this.Controls.Add(this.lblValorG);
            this.Name = "Form1";
            this.Text = "Consumo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblValorG;
        private System.Windows.Forms.Label lblGasto;
        private System.Windows.Forms.Label lblPreco;
        private System.Windows.Forms.Label lblKms;
        private System.Windows.Forms.Label lblRegistado;
        private System.Windows.Forms.Label lblConsumo;
        private System.Windows.Forms.Label lblRegisto;
        private System.Windows.Forms.TextBox txtKms;
        private System.Windows.Forms.TextBox txtPreco;
        private System.Windows.Forms.TextBox txtConsumo;
        private System.Windows.Forms.Button btnCalcula;
    }
}

