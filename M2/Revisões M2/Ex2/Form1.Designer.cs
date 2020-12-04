namespace Ex2
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.grbAvaliacao = new System.Windows.Forms.GroupBox();
            this.cboPreco = new System.Windows.Forms.ComboBox();
            this.cboExtras = new System.Windows.Forms.ComboBox();
            this.cboConsumo = new System.Windows.Forms.ComboBox();
            this.cboMotorizacao = new System.Windows.Forms.ComboBox();
            this.cboConforto = new System.Windows.Forms.ComboBox();
            this.cboDesign = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnPontuar = new System.Windows.Forms.Button();
            this.lstVeiculos = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.grbAvaliacao.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Modelo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Marca";
            // 
            // txtModelo
            // 
            this.txtModelo.Location = new System.Drawing.Point(92, 85);
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(100, 20);
            this.txtModelo.TabIndex = 2;
            // 
            // txtMarca
            // 
            this.txtMarca.Location = new System.Drawing.Point(92, 27);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(100, 20);
            this.txtMarca.TabIndex = 3;
            // 
            // grbAvaliacao
            // 
            this.grbAvaliacao.Controls.Add(this.cboPreco);
            this.grbAvaliacao.Controls.Add(this.cboExtras);
            this.grbAvaliacao.Controls.Add(this.cboConsumo);
            this.grbAvaliacao.Controls.Add(this.cboMotorizacao);
            this.grbAvaliacao.Controls.Add(this.cboConforto);
            this.grbAvaliacao.Controls.Add(this.cboDesign);
            this.grbAvaliacao.Controls.Add(this.label8);
            this.grbAvaliacao.Controls.Add(this.label7);
            this.grbAvaliacao.Controls.Add(this.label6);
            this.grbAvaliacao.Controls.Add(this.label5);
            this.grbAvaliacao.Controls.Add(this.label4);
            this.grbAvaliacao.Controls.Add(this.label3);
            this.grbAvaliacao.Location = new System.Drawing.Point(31, 129);
            this.grbAvaliacao.Name = "grbAvaliacao";
            this.grbAvaliacao.Size = new System.Drawing.Size(174, 279);
            this.grbAvaliacao.TabIndex = 4;
            this.grbAvaliacao.TabStop = false;
            this.grbAvaliacao.Text = "Avaliação";
            // 
            // cboPreco
            // 
            this.cboPreco.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPreco.FormattingEnabled = true;
            this.cboPreco.Location = new System.Drawing.Point(90, 236);
            this.cboPreco.Name = "cboPreco";
            this.cboPreco.Size = new System.Drawing.Size(53, 21);
            this.cboPreco.TabIndex = 11;
            // 
            // cboExtras
            // 
            this.cboExtras.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboExtras.FormattingEnabled = true;
            this.cboExtras.Location = new System.Drawing.Point(90, 195);
            this.cboExtras.Name = "cboExtras";
            this.cboExtras.Size = new System.Drawing.Size(53, 21);
            this.cboExtras.TabIndex = 10;
            // 
            // cboConsumo
            // 
            this.cboConsumo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboConsumo.FormattingEnabled = true;
            this.cboConsumo.Location = new System.Drawing.Point(90, 151);
            this.cboConsumo.Name = "cboConsumo";
            this.cboConsumo.Size = new System.Drawing.Size(53, 21);
            this.cboConsumo.TabIndex = 9;
            // 
            // cboMotorizacao
            // 
            this.cboMotorizacao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMotorizacao.FormattingEnabled = true;
            this.cboMotorizacao.Location = new System.Drawing.Point(90, 108);
            this.cboMotorizacao.Name = "cboMotorizacao";
            this.cboMotorizacao.Size = new System.Drawing.Size(53, 21);
            this.cboMotorizacao.TabIndex = 8;
            // 
            // cboConforto
            // 
            this.cboConforto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboConforto.FormattingEnabled = true;
            this.cboConforto.Location = new System.Drawing.Point(90, 70);
            this.cboConforto.Name = "cboConforto";
            this.cboConforto.Size = new System.Drawing.Size(53, 21);
            this.cboConforto.TabIndex = 7;
            // 
            // cboDesign
            // 
            this.cboDesign.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDesign.FormattingEnabled = true;
            this.cboDesign.Location = new System.Drawing.Point(90, 28);
            this.cboDesign.Name = "cboDesign";
            this.cboDesign.Size = new System.Drawing.Size(53, 21);
            this.cboDesign.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 239);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 5;
            this.label8.Text = "Preço";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 198);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Extras";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 154);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Consumo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 111);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Motorização";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Conforto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Design";
            // 
            // btnPontuar
            // 
            this.btnPontuar.Location = new System.Drawing.Point(40, 414);
            this.btnPontuar.Name = "btnPontuar";
            this.btnPontuar.Size = new System.Drawing.Size(152, 29);
            this.btnPontuar.TabIndex = 12;
            this.btnPontuar.Text = "Pontuar Veiculo";
            this.btnPontuar.UseVisualStyleBackColor = true;
            this.btnPontuar.Click += new System.EventHandler(this.BtnPontuar_Click);
            // 
            // lstVeiculos
            // 
            this.lstVeiculos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.lstVeiculos.HideSelection = false;
            this.lstVeiculos.Location = new System.Drawing.Point(239, 27);
            this.lstVeiculos.Name = "lstVeiculos";
            this.lstVeiculos.Size = new System.Drawing.Size(373, 416);
            this.lstVeiculos.TabIndex = 13;
            this.lstVeiculos.UseCompatibleStateImageBehavior = false;
            this.lstVeiculos.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Marca";
            this.columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Modelo";
            this.columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Avaliação";
            this.columnHeader3.Width = 100;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 455);
            this.Controls.Add(this.lstVeiculos);
            this.Controls.Add(this.btnPontuar);
            this.Controls.Add(this.grbAvaliacao);
            this.Controls.Add(this.txtMarca);
            this.Controls.Add(this.txtModelo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Avaliação de veículos Automáticos";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grbAvaliacao.ResumeLayout(false);
            this.grbAvaliacao.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtModelo;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.GroupBox grbAvaliacao;
        private System.Windows.Forms.ComboBox cboPreco;
        private System.Windows.Forms.ComboBox cboExtras;
        private System.Windows.Forms.ComboBox cboConsumo;
        private System.Windows.Forms.ComboBox cboMotorizacao;
        private System.Windows.Forms.ComboBox cboConforto;
        private System.Windows.Forms.ComboBox cboDesign;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnPontuar;
        private System.Windows.Forms.ListView lstVeiculos;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
    }
}

