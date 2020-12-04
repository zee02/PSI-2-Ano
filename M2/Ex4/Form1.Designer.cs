namespace Ex4
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
            this.lblOperators = new System.Windows.Forms.Label();
            this.lblMais = new System.Windows.Forms.Label();
            this.lblDivide = new System.Windows.Forms.Label();
            this.lblMult = new System.Windows.Forms.Label();
            this.lblSubtrai = new System.Windows.Forms.Label();
            this.lblNumero1 = new System.Windows.Forms.Label();
            this.txtInsere1 = new System.Windows.Forms.TextBox();
            this.txtInsere2 = new System.Windows.Forms.TextBox();
            this.lblNumero2 = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnTerminar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblOperators
            // 
            this.lblOperators.AutoSize = true;
            this.lblOperators.Location = new System.Drawing.Point(335, 31);
            this.lblOperators.Name = "lblOperators";
            this.lblOperators.Size = new System.Drawing.Size(62, 13);
            this.lblOperators.TabIndex = 0;
            this.lblOperators.Text = "Operadores";
            // 
            // lblMais
            // 
            this.lblMais.AutoSize = true;
            this.lblMais.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblMais.Location = new System.Drawing.Point(357, 76);
            this.lblMais.Name = "lblMais";
            this.lblMais.Size = new System.Drawing.Size(15, 15);
            this.lblMais.TabIndex = 1;
            this.lblMais.Text = "+";
            this.lblMais.Click += new System.EventHandler(this.LblMais_Click);
            // 
            // lblDivide
            // 
            this.lblDivide.AutoSize = true;
            this.lblDivide.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDivide.Location = new System.Drawing.Point(356, 121);
            this.lblDivide.Name = "lblDivide";
            this.lblDivide.Size = new System.Drawing.Size(14, 15);
            this.lblDivide.TabIndex = 2;
            this.lblDivide.Text = "/";
            this.lblDivide.Click += new System.EventHandler(this.Label1_Click);
            // 
            // lblMult
            // 
            this.lblMult.AutoSize = true;
            this.lblMult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblMult.Location = new System.Drawing.Point(356, 172);
            this.lblMult.Name = "lblMult";
            this.lblMult.Size = new System.Drawing.Size(13, 15);
            this.lblMult.TabIndex = 3;
            this.lblMult.Text = "*";
            this.lblMult.Click += new System.EventHandler(this.Label2_Click);
            // 
            // lblSubtrai
            // 
            this.lblSubtrai.AutoSize = true;
            this.lblSubtrai.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSubtrai.Location = new System.Drawing.Point(356, 228);
            this.lblSubtrai.Name = "lblSubtrai";
            this.lblSubtrai.Size = new System.Drawing.Size(12, 15);
            this.lblSubtrai.TabIndex = 4;
            this.lblSubtrai.Text = "-";
            this.lblSubtrai.Click += new System.EventHandler(this.Label3_Click);
            // 
            // lblNumero1
            // 
            this.lblNumero1.AutoSize = true;
            this.lblNumero1.Location = new System.Drawing.Point(80, 79);
            this.lblNumero1.Name = "lblNumero1";
            this.lblNumero1.Size = new System.Drawing.Size(47, 13);
            this.lblNumero1.TabIndex = 5;
            this.lblNumero1.Text = "Número:";
            // 
            // txtInsere1
            // 
            this.txtInsere1.Location = new System.Drawing.Point(157, 76);
            this.txtInsere1.Name = "txtInsere1";
            this.txtInsere1.Size = new System.Drawing.Size(75, 20);
            this.txtInsere1.TabIndex = 6;
            this.txtInsere1.TextChanged += new System.EventHandler(this.TxtInsere1_TextChanged);
            // 
            // txtInsere2
            // 
            this.txtInsere2.Location = new System.Drawing.Point(157, 157);
            this.txtInsere2.Name = "txtInsere2";
            this.txtInsere2.Size = new System.Drawing.Size(75, 20);
            this.txtInsere2.TabIndex = 7;
            this.txtInsere2.TextChanged += new System.EventHandler(this.TxtInsere2_TextChanged);
            // 
            // lblNumero2
            // 
            this.lblNumero2.AutoSize = true;
            this.lblNumero2.Location = new System.Drawing.Point(80, 160);
            this.lblNumero2.Name = "lblNumero2";
            this.lblNumero2.Size = new System.Drawing.Size(47, 13);
            this.lblNumero2.TabIndex = 8;
            this.lblNumero2.Text = "Número:";
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(80, 231);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(55, 13);
            this.lblResult.TabIndex = 9;
            this.lblResult.Text = "Resultado";
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(157, 228);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(75, 20);
            this.txtResult.TabIndex = 10;
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(45, 307);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(94, 26);
            this.btnLimpar.TabIndex = 11;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.BtnLimpar_Click);
            // 
            // btnTerminar
            // 
            this.btnTerminar.Location = new System.Drawing.Point(219, 307);
            this.btnTerminar.Name = "btnTerminar";
            this.btnTerminar.Size = new System.Drawing.Size(102, 25);
            this.btnTerminar.TabIndex = 12;
            this.btnTerminar.Text = "Terminar";
            this.btnTerminar.UseVisualStyleBackColor = true;
            this.btnTerminar.Click += new System.EventHandler(this.BtnTerminar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 363);
            this.Controls.Add(this.btnTerminar);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.lblNumero2);
            this.Controls.Add(this.txtInsere2);
            this.Controls.Add(this.txtInsere1);
            this.Controls.Add(this.lblNumero1);
            this.Controls.Add(this.lblSubtrai);
            this.Controls.Add(this.lblMult);
            this.Controls.Add(this.lblDivide);
            this.Controls.Add(this.lblMais);
            this.Controls.Add(this.lblOperators);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblOperators;
        private System.Windows.Forms.Label lblMais;
        private System.Windows.Forms.Label lblDivide;
        private System.Windows.Forms.Label lblMult;
        private System.Windows.Forms.Label lblSubtrai;
        private System.Windows.Forms.Label lblNumero1;
        private System.Windows.Forms.TextBox txtInsere1;
        private System.Windows.Forms.TextBox txtInsere2;
        private System.Windows.Forms.Label lblNumero2;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnTerminar;
    }
}

