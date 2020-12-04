namespace Exercicio
{
    partial class InsereValores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InsereValores));
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.txtMarcas = new System.Windows.Forms.TextBox();
            this.txtRegisto = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cmbTipo = new System.Windows.Forms.ComboBox();
            this.mtbCili = new System.Windows.Forms.MaskedTextBox();
            this.mtbPreco = new System.Windows.Forms.MaskedTextBox();
            this.mtbAno = new System.Windows.Forms.MaskedTextBox();
            this.cmbCateg = new System.Windows.Forms.ComboBox();
            this.cmbComb = new System.Windows.Forms.ComboBox();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(334, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Marca";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(336, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Categoria";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(336, 215);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Cilindrada";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(497, 216);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Preço";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(497, 152);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Modelo";
            this.label6.Click += new System.EventHandler(this.Label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(497, 187);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Combustível";
            // 
            // txtModelo
            // 
            this.txtModelo.Enabled = false;
            this.txtModelo.Location = new System.Drawing.Point(569, 148);
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(54, 20);
            this.txtModelo.TabIndex = 7;
            this.txtModelo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtModelo_KeyPress);
            // 
            // txtMarcas
            // 
            this.txtMarcas.Enabled = false;
            this.txtMarcas.Location = new System.Drawing.Point(395, 152);
            this.txtMarcas.Name = "txtMarcas";
            this.txtMarcas.Size = new System.Drawing.Size(84, 20);
            this.txtMarcas.TabIndex = 8;
            this.txtMarcas.TextChanged += new System.EventHandler(this.TxtMarcas_TextChanged);
            this.txtMarcas.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtMarcas_KeyPress);
            // 
            // txtRegisto
            // 
            this.txtRegisto.Enabled = false;
            this.txtRegisto.Location = new System.Drawing.Point(259, 152);
            this.txtRegisto.Name = "txtRegisto";
            this.txtRegisto.Size = new System.Drawing.Size(69, 20);
            this.txtRegisto.TabIndex = 11;
            this.txtRegisto.TextChanged += new System.EventHandler(this.TxtRegisto_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(210, 184);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Tipo";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(212, 212);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(26, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Ano";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(210, 155);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "Registo";
            // 
            // cmbTipo
            // 
            this.cmbTipo.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.cmbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipo.Enabled = false;
            this.cmbTipo.FormattingEnabled = true;
            this.cmbTipo.Items.AddRange(new object[] {
            "Familiar",
            "Desportivo",
            "Drift",
            "DragRace",
            "Classico"});
            this.cmbTipo.Location = new System.Drawing.Point(259, 179);
            this.cmbTipo.Name = "cmbTipo";
            this.cmbTipo.Size = new System.Drawing.Size(69, 21);
            this.cmbTipo.TabIndex = 19;
            this.cmbTipo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CmbTipo_KeyPress);
            this.cmbTipo.MouseLeave += new System.EventHandler(this.cmbTipo_MouseLeave);
            this.cmbTipo.MouseHover += new System.EventHandler(this.cmbTipo_MouseHover);
            // 
            // mtbCili
            // 
            this.mtbCili.Enabled = false;
            this.mtbCili.Location = new System.Drawing.Point(395, 209);
            this.mtbCili.Mask = "00000";
            this.mtbCili.Name = "mtbCili";
            this.mtbCili.Size = new System.Drawing.Size(31, 20);
            this.mtbCili.TabIndex = 20;
            this.mtbCili.ValidatingType = typeof(int);
            // 
            // mtbPreco
            // 
            this.mtbPreco.Enabled = false;
            this.mtbPreco.Location = new System.Drawing.Point(569, 213);
            this.mtbPreco.Mask = "0000000";
            this.mtbPreco.Name = "mtbPreco";
            this.mtbPreco.Size = new System.Drawing.Size(43, 20);
            this.mtbPreco.TabIndex = 21;
            this.mtbPreco.ValidatingType = typeof(int);
            // 
            // mtbAno
            // 
            this.mtbAno.Enabled = false;
            this.mtbAno.Location = new System.Drawing.Point(259, 205);
            this.mtbAno.Mask = "0000";
            this.mtbAno.Name = "mtbAno";
            this.mtbAno.Size = new System.Drawing.Size(36, 20);
            this.mtbAno.TabIndex = 22;
            this.mtbAno.ValidatingType = typeof(int);
            this.mtbAno.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MtbAno_KeyPress);
            // 
            // cmbCateg
            // 
            this.cmbCateg.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCateg.FormattingEnabled = true;
            this.cmbCateg.Items.AddRange(new object[] {
            "Am",
            "A1",
            "A2",
            "B",
            "B1",
            "C",
            "C1",
            "D",
            "DE"});
            this.cmbCateg.Location = new System.Drawing.Point(394, 181);
            this.cmbCateg.Name = "cmbCateg";
            this.cmbCateg.Size = new System.Drawing.Size(85, 21);
            this.cmbCateg.TabIndex = 23;
            // 
            // cmbComb
            // 
            this.cmbComb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbComb.FormattingEnabled = true;
            this.cmbComb.Items.AddRange(new object[] {
            "Gasolina",
            "Gasóleo",
            "Eletricididade"});
            this.cmbComb.Location = new System.Drawing.Point(569, 181);
            this.cmbComb.Name = "cmbComb";
            this.cmbComb.Size = new System.Drawing.Size(54, 21);
            this.cmbComb.TabIndex = 24;
            // 
            // btnLimpar
            // 
            this.btnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Location = new System.Drawing.Point(282, 41);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(257, 69);
            this.btnLimpar.TabIndex = 25;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // InsereValores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(786, 282);
            this.ControlBox = false;
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.cmbComb);
            this.Controls.Add(this.cmbCateg);
            this.Controls.Add(this.mtbAno);
            this.Controls.Add(this.mtbPreco);
            this.Controls.Add(this.mtbCili);
            this.Controls.Add(this.cmbTipo);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtRegisto);
            this.Controls.Add(this.txtMarcas);
            this.Controls.Add(this.txtModelo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "InsereValores";
            this.Text = "Insere Valores";
            this.Load += new System.EventHandler(this.InsereValores_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion


        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.TextBox txtModelo;
        public System.Windows.Forms.TextBox txtMarcas;
        public System.Windows.Forms.TextBox txtRegisto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        public System.Windows.Forms.ComboBox cmbTipo;
        public System.Windows.Forms.MaskedTextBox mtbCili;
        public System.Windows.Forms.MaskedTextBox mtbPreco;
        public System.Windows.Forms.MaskedTextBox mtbAno;
        public System.Windows.Forms.ComboBox cmbCateg;
        public System.Windows.Forms.ComboBox cmbComb;
        private System.Windows.Forms.Button btnLimpar;
    }
}