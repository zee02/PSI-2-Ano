namespace _1
{
    partial class lblSeg
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
            this.lblSalario = new System.Windows.Forms.Label();
            this.lblSoc = new System.Windows.Forms.Label();
            this.lblSliq = new System.Windows.Forms.Label();
            this.lblIrs = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.txtSalario = new System.Windows.Forms.TextBox();
            this.lblLiq = new System.Windows.Forms.Label();
            this.lblSeguranca = new System.Windows.Forms.Label();
            this.lblSocial = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblSalario
            // 
            this.lblSalario.AutoSize = true;
            this.lblSalario.Location = new System.Drawing.Point(41, 30);
            this.lblSalario.Name = "lblSalario";
            this.lblSalario.Size = new System.Drawing.Size(39, 13);
            this.lblSalario.TabIndex = 0;
            this.lblSalario.Text = "Salário";
            // 
            // lblSoc
            // 
            this.lblSoc.AutoSize = true;
            this.lblSoc.Location = new System.Drawing.Point(41, 164);
            this.lblSoc.Name = "lblSoc";
            this.lblSoc.Size = new System.Drawing.Size(61, 13);
            this.lblSoc.TabIndex = 1;
            this.lblSoc.Text = "Seg. Social";
            // 
            // lblSliq
            // 
            this.lblSliq.AutoSize = true;
            this.lblSliq.Location = new System.Drawing.Point(41, 207);
            this.lblSliq.Name = "lblSliq";
            this.lblSliq.Size = new System.Drawing.Size(76, 13);
            this.lblSliq.TabIndex = 2;
            this.lblSliq.Text = "Salário Liquido";
            // 
            // lblIrs
            // 
            this.lblIrs.AutoSize = true;
            this.lblIrs.Location = new System.Drawing.Point(41, 124);
            this.lblIrs.Name = "lblIrs";
            this.lblIrs.Size = new System.Drawing.Size(25, 13);
            this.lblIrs.TabIndex = 3;
            this.lblIrs.Text = "IRS";
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(97, 76);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(122, 23);
            this.btnCalcular.TabIndex = 4;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.BtnCalcular_Click);
            // 
            // txtSalario
            // 
            this.txtSalario.Location = new System.Drawing.Point(149, 30);
            this.txtSalario.Name = "txtSalario";
            this.txtSalario.Size = new System.Drawing.Size(100, 20);
            this.txtSalario.TabIndex = 5;
            // 
            // lblLiq
            // 
            this.lblLiq.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblLiq.Location = new System.Drawing.Point(162, 207);
            this.lblLiq.Name = "lblLiq";
            this.lblLiq.Size = new System.Drawing.Size(86, 20);
            this.lblLiq.TabIndex = 6;
            this.lblLiq.Click += new System.EventHandler(this.Label4_Click);
            // 
            // lblSeguranca
            // 
            this.lblSeguranca.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSeguranca.Location = new System.Drawing.Point(162, 164);
            this.lblSeguranca.Name = "lblSeguranca";
            this.lblSeguranca.Size = new System.Drawing.Size(86, 20);
            this.lblSeguranca.TabIndex = 7;
            // 
            // lblSocial
            // 
            this.lblSocial.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSocial.Location = new System.Drawing.Point(162, 124);
            this.lblSocial.Name = "lblSocial";
            this.lblSocial.Size = new System.Drawing.Size(86, 20);
            this.lblSocial.TabIndex = 8;
            this.lblSocial.Click += new System.EventHandler(this.Label6_Click);
            // 
            // lblSeg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(306, 254);
            this.Controls.Add(this.lblSocial);
            this.Controls.Add(this.lblSeguranca);
            this.Controls.Add(this.lblLiq);
            this.Controls.Add(this.txtSalario);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.lblIrs);
            this.Controls.Add(this.lblSliq);
            this.Controls.Add(this.lblSoc);
            this.Controls.Add(this.lblSalario);
            this.Name = "lblSeg";
            this.Text = "Salário";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSalario;
        private System.Windows.Forms.Label lblSoc;
        private System.Windows.Forms.Label lblSliq;
        private System.Windows.Forms.Label lblIrs;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.TextBox txtSalario;
        private System.Windows.Forms.Label lblLiq;
        private System.Windows.Forms.Label lblSeguranca;
        private System.Windows.Forms.Label lblSocial;
    }
}

