namespace Restaurante
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cboEmenta = new System.Windows.Forms.ComboBox();
            this.nudCriancas = new System.Windows.Forms.NumericUpDown();
            this.nudAdultos = new System.Windows.Forms.NumericUpDown();
            this.nudDieta = new System.Windows.Forms.NumericUpDown();
            this.lblDieta = new System.Windows.Forms.Label();
            this.lblCriancas = new System.Windows.Forms.Label();
            this.lblAdultos = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.lblPreco = new System.Windows.Forms.Label();
            this.lblSinal = new System.Windows.Forms.Label();
            this.lblPagamento = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudCriancas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAdultos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDieta)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ementa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Adultos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Crianças";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 228);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Dieta";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(36, 373);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Preço Total";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(36, 478);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Pagamento do Dia";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(36, 423);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Sinal de Reserva";
            // 
            // cboEmenta
            // 
            this.cboEmenta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEmenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboEmenta.FormattingEnabled = true;
            this.cboEmenta.Items.AddRange(new object[] {
            "Deluxe",
            "Portuguesa",
            "Prestígio",
            "Rodízio",
            "Soberba"});
            this.cboEmenta.Location = new System.Drawing.Point(133, 33);
            this.cboEmenta.Name = "cboEmenta";
            this.cboEmenta.Size = new System.Drawing.Size(166, 21);
            this.cboEmenta.TabIndex = 7;
            // 
            // nudCriancas
            // 
            this.nudCriancas.Location = new System.Drawing.Point(112, 181);
            this.nudCriancas.Name = "nudCriancas";
            this.nudCriancas.Size = new System.Drawing.Size(46, 20);
            this.nudCriancas.TabIndex = 8;
            this.nudCriancas.ValueChanged += new System.EventHandler(this.NudCriancas_ValueChanged);
            // 
            // nudAdultos
            // 
            this.nudAdultos.Location = new System.Drawing.Point(112, 134);
            this.nudAdultos.Name = "nudAdultos";
            this.nudAdultos.Size = new System.Drawing.Size(46, 20);
            this.nudAdultos.TabIndex = 9;
            this.nudAdultos.ValueChanged += new System.EventHandler(this.NudAdultos_ValueChanged);
            // 
            // nudDieta
            // 
            this.nudDieta.Location = new System.Drawing.Point(112, 226);
            this.nudDieta.Name = "nudDieta";
            this.nudDieta.Size = new System.Drawing.Size(46, 20);
            this.nudDieta.TabIndex = 10;
            this.nudDieta.ValueChanged += new System.EventHandler(this.NudDieta_ValueChanged);
            // 
            // lblDieta
            // 
            this.lblDieta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDieta.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDieta.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.lblDieta.Location = new System.Drawing.Point(229, 227);
            this.lblDieta.Name = "lblDieta";
            this.lblDieta.Size = new System.Drawing.Size(100, 23);
            this.lblDieta.TabIndex = 11;
            this.lblDieta.Text = "0";
            this.lblDieta.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblCriancas
            // 
            this.lblCriancas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCriancas.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCriancas.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.lblCriancas.Location = new System.Drawing.Point(229, 182);
            this.lblCriancas.Name = "lblCriancas";
            this.lblCriancas.Size = new System.Drawing.Size(100, 23);
            this.lblCriancas.TabIndex = 12;
            this.lblCriancas.Text = "0";
            this.lblCriancas.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblAdultos
            // 
            this.lblAdultos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblAdultos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdultos.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.lblAdultos.Location = new System.Drawing.Point(229, 135);
            this.lblAdultos.Name = "lblAdultos";
            this.lblAdultos.Size = new System.Drawing.Size(100, 23);
            this.lblAdultos.TabIndex = 13;
            this.lblAdultos.Text = "0";
            this.lblAdultos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(48, 298);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(110, 33);
            this.btnCalcular.TabIndex = 14;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.BtnCalcular_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(213, 298);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(116, 33);
            this.btnLimpar.TabIndex = 15;
            this.btnLimpar.Text = "Limpar Valores";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.Button2_Click);
            // 
            // lblPreco
            // 
            this.lblPreco.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPreco.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPreco.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.lblPreco.Location = new System.Drawing.Point(180, 373);
            this.lblPreco.Name = "lblPreco";
            this.lblPreco.Size = new System.Drawing.Size(100, 23);
            this.lblPreco.TabIndex = 16;
            this.lblPreco.Text = "0";
            this.lblPreco.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblPreco.Click += new System.EventHandler(this.LblPreco_Click);
            // 
            // lblSinal
            // 
            this.lblSinal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSinal.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.lblSinal.Location = new System.Drawing.Point(180, 422);
            this.lblSinal.Name = "lblSinal";
            this.lblSinal.Size = new System.Drawing.Size(100, 23);
            this.lblSinal.TabIndex = 17;
            this.lblSinal.Text = "0";
            this.lblSinal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblPagamento
            // 
            this.lblPagamento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPagamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPagamento.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.lblPagamento.Location = new System.Drawing.Point(180, 478);
            this.lblPagamento.Name = "lblPagamento";
            this.lblPagamento.Size = new System.Drawing.Size(100, 23);
            this.lblPagamento.TabIndex = 18;
            this.lblPagamento.Text = "0";
            this.lblPagamento.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(123, 98);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(27, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "Qta.";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(268, 98);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(31, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = "Valor";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 547);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblPagamento);
            this.Controls.Add(this.lblSinal);
            this.Controls.Add(this.lblPreco);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.lblAdultos);
            this.Controls.Add(this.lblCriancas);
            this.Controls.Add(this.lblDieta);
            this.Controls.Add(this.nudDieta);
            this.Controls.Add(this.nudAdultos);
            this.Controls.Add(this.nudCriancas);
            this.Controls.Add(this.cboEmenta);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Eventos Sociais";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudCriancas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAdultos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDieta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cboEmenta;
        private System.Windows.Forms.NumericUpDown nudCriancas;
        private System.Windows.Forms.NumericUpDown nudAdultos;
        private System.Windows.Forms.NumericUpDown nudDieta;
        private System.Windows.Forms.Label lblDieta;
        private System.Windows.Forms.Label lblCriancas;
        private System.Windows.Forms.Label lblAdultos;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Label lblPreco;
        private System.Windows.Forms.Label lblSinal;
        private System.Windows.Forms.Label lblPagamento;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
    }
}

