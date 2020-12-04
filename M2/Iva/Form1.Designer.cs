namespace Iva
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblNome = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.lblValor = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbRegiao = new System.Windows.Forms.ComboBox();
            this.btnLimpa = new System.Windows.Forms.Button();
            this.btnCalcula = new System.Windows.Forms.Button();
            this.lblValorCompra = new System.Windows.Forms.Label();
            this.lblImposto = new System.Windows.Forms.Label();
            this.lblTotal2 = new System.Windows.Forms.Label();
            this.lblImposto2 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblValorC = new System.Windows.Forms.Label();
            this.lblNome1 = new System.Windows.Forms.Label();
            this.lblNome2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.BackColor = System.Drawing.Color.Transparent;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Uighur", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.ForeColor = System.Drawing.Color.White;
            this.lblNome.Location = new System.Drawing.Point(29, 12);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(69, 34);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(97, 18);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(100, 20);
            this.txtNome.TabIndex = 1;
            this.txtNome.TextChanged += new System.EventHandler(this.TxtNome_TextChanged);
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(354, 18);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(100, 20);
            this.txtValor.TabIndex = 2;
            this.txtValor.TextChanged += new System.EventHandler(this.TxtValor_TextChanged);
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.BackColor = System.Drawing.Color.Transparent;
            this.lblValor.Font = new System.Drawing.Font("Microsoft Uighur", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValor.ForeColor = System.Drawing.Color.White;
            this.lblValor.Location = new System.Drawing.Point(270, 12);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(67, 34);
            this.lblValor.TabIndex = 3;
            this.lblValor.Text = "Valor:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Uighur", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(146, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 34);
            this.label2.TabIndex = 4;
            this.label2.Text = "Região";
            // 
            // cmbRegiao
            // 
            this.cmbRegiao.AutoCompleteCustomSource.AddRange(new string[] {
            "Leiria",
            "Lisboa",
            "Setúbal",
            "Porto"});
            this.cmbRegiao.FormattingEnabled = true;
            this.cmbRegiao.Items.AddRange(new object[] {
            "Norte",
            "Sul",
            "Centro"});
            this.cmbRegiao.Location = new System.Drawing.Point(223, 77);
            this.cmbRegiao.Name = "cmbRegiao";
            this.cmbRegiao.Size = new System.Drawing.Size(112, 21);
            this.cmbRegiao.TabIndex = 5;
            // 
            // btnLimpa
            // 
            this.btnLimpa.BackColor = System.Drawing.Color.Black;
            this.btnLimpa.Font = new System.Drawing.Font("Microsoft Uighur", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpa.ForeColor = System.Drawing.Color.White;
            this.btnLimpa.Location = new System.Drawing.Point(354, 131);
            this.btnLimpa.Name = "btnLimpa";
            this.btnLimpa.Size = new System.Drawing.Size(86, 34);
            this.btnLimpa.TabIndex = 6;
            this.btnLimpa.Text = "Limpar";
            this.btnLimpa.UseVisualStyleBackColor = false;
            this.btnLimpa.Click += new System.EventHandler(this.BtnLimpa_Click_1);
            // 
            // btnCalcula
            // 
            this.btnCalcula.BackColor = System.Drawing.Color.Black;
            this.btnCalcula.Enabled = false;
            this.btnCalcula.Font = new System.Drawing.Font("Microsoft Uighur", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcula.ForeColor = System.Drawing.Color.White;
            this.btnCalcula.Location = new System.Drawing.Point(35, 131);
            this.btnCalcula.Name = "btnCalcula";
            this.btnCalcula.Size = new System.Drawing.Size(86, 34);
            this.btnCalcula.TabIndex = 7;
            this.btnCalcula.Text = "Calcula";
            this.btnCalcula.UseVisualStyleBackColor = false;
            this.btnCalcula.Click += new System.EventHandler(this.BtnCalcula_Click);
            // 
            // lblValorCompra
            // 
            this.lblValorCompra.AutoSize = true;
            this.lblValorCompra.BackColor = System.Drawing.Color.Transparent;
            this.lblValorCompra.Font = new System.Drawing.Font("Microsoft Uighur", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorCompra.ForeColor = System.Drawing.Color.White;
            this.lblValorCompra.Location = new System.Drawing.Point(-3, 194);
            this.lblValorCompra.Name = "lblValorCompra";
            this.lblValorCompra.Size = new System.Drawing.Size(144, 34);
            this.lblValorCompra.TabIndex = 8;
            this.lblValorCompra.Text = "Valor da Fatura";
            // 
            // lblImposto
            // 
            this.lblImposto.AutoSize = true;
            this.lblImposto.BackColor = System.Drawing.Color.Transparent;
            this.lblImposto.Font = new System.Drawing.Font("Microsoft Uighur", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImposto.ForeColor = System.Drawing.Color.White;
            this.lblImposto.Location = new System.Drawing.Point(264, 195);
            this.lblImposto.Name = "lblImposto";
            this.lblImposto.Size = new System.Drawing.Size(153, 34);
            this.lblImposto.TabIndex = 9;
            this.lblImposto.Text = "Imposto da Água";
            // 
            // lblTotal2
            // 
            this.lblTotal2.AutoSize = true;
            this.lblTotal2.BackColor = System.Drawing.Color.Transparent;
            this.lblTotal2.Font = new System.Drawing.Font("Microsoft Uighur", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal2.ForeColor = System.Drawing.Color.White;
            this.lblTotal2.Location = new System.Drawing.Point(378, 243);
            this.lblTotal2.Name = "lblTotal2";
            this.lblTotal2.Size = new System.Drawing.Size(0, 34);
            this.lblTotal2.TabIndex = 10;
            // 
            // lblImposto2
            // 
            this.lblImposto2.AutoSize = true;
            this.lblImposto2.BackColor = System.Drawing.Color.Transparent;
            this.lblImposto2.Font = new System.Drawing.Font("Microsoft Uighur", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImposto2.ForeColor = System.Drawing.Color.White;
            this.lblImposto2.Location = new System.Drawing.Point(423, 197);
            this.lblImposto2.Name = "lblImposto2";
            this.lblImposto2.Size = new System.Drawing.Size(0, 31);
            this.lblImposto2.TabIndex = 11;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.BackColor = System.Drawing.Color.Transparent;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Uighur", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ForeColor = System.Drawing.Color.White;
            this.lblTotal.Location = new System.Drawing.Point(294, 247);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(59, 34);
            this.lblTotal.TabIndex = 12;
            this.lblTotal.Text = "Total";
            // 
            // lblValorC
            // 
            this.lblValorC.AutoSize = true;
            this.lblValorC.BackColor = System.Drawing.Color.Transparent;
            this.lblValorC.Font = new System.Drawing.Font("Microsoft Uighur", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorC.ForeColor = System.Drawing.Color.White;
            this.lblValorC.Location = new System.Drawing.Point(157, 197);
            this.lblValorC.Name = "lblValorC";
            this.lblValorC.Size = new System.Drawing.Size(0, 31);
            this.lblValorC.TabIndex = 13;
            // 
            // lblNome1
            // 
            this.lblNome1.AutoSize = true;
            this.lblNome1.BackColor = System.Drawing.Color.Transparent;
            this.lblNome1.Font = new System.Drawing.Font("Microsoft Uighur", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome1.ForeColor = System.Drawing.Color.White;
            this.lblNome1.Location = new System.Drawing.Point(-3, 243);
            this.lblNome1.Name = "lblNome1";
            this.lblNome1.Size = new System.Drawing.Size(146, 34);
            this.lblNome1.TabIndex = 14;
            this.lblNome1.Text = "Nome na Fatura";
            // 
            // lblNome2
            // 
            this.lblNome2.AutoSize = true;
            this.lblNome2.BackColor = System.Drawing.Color.Transparent;
            this.lblNome2.Font = new System.Drawing.Font("Microsoft Uighur", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome2.ForeColor = System.Drawing.Color.White;
            this.lblNome2.Location = new System.Drawing.Point(157, 243);
            this.lblNome2.Name = "lblNome2";
            this.lblNome2.Size = new System.Drawing.Size(0, 34);
            this.lblNome2.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(493, 308);
            this.Controls.Add(this.lblNome2);
            this.Controls.Add(this.lblNome1);
            this.Controls.Add(this.lblValorC);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblImposto2);
            this.Controls.Add(this.lblTotal2);
            this.Controls.Add(this.lblImposto);
            this.Controls.Add(this.lblValorCompra);
            this.Controls.Add(this.btnCalcula);
            this.Controls.Add(this.btnLimpa);
            this.Controls.Add(this.cmbRegiao);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblValor);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblNome);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Imposto da Água";
            this.Load += new System.EventHandler(this.Form1_Load_2);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbRegiao;
        private System.Windows.Forms.Button btnLimpa;
        private System.Windows.Forms.Button btnCalcula;
        private System.Windows.Forms.Label lblValorCompra;
        private System.Windows.Forms.Label lblImposto;
        private System.Windows.Forms.Label lblTotal2;
        private System.Windows.Forms.Label lblImposto2;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblValorC;
        private System.Windows.Forms.Label lblNome1;
        private System.Windows.Forms.Label lblNome2;
    }
}

