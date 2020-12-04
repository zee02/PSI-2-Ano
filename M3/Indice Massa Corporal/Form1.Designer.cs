namespace Indice_Massa_Corporal
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
            this.grbGenero = new System.Windows.Forms.GroupBox();
            this.radFeminino = new System.Windows.Forms.RadioButton();
            this.radMasculino = new System.Windows.Forms.RadioButton();
            this.grbUtente = new System.Windows.Forms.GroupBox();
            this.txtIdade = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.nudAltura = new System.Windows.Forms.NumericUpDown();
            this.nudPeso = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRepor = new System.Windows.Forms.Button();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.grbInformacoes = new System.Windows.Forms.GroupBox();
            this.lblIMC = new System.Windows.Forms.Label();
            this.lblClassificacao = new System.Windows.Forms.Label();
            this.lblRisco = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.grbGenero.SuspendLayout();
            this.grbUtente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAltura)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPeso)).BeginInit();
            this.grbInformacoes.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbGenero
            // 
            this.grbGenero.Controls.Add(this.radFeminino);
            this.grbGenero.Controls.Add(this.radMasculino);
            this.grbGenero.Location = new System.Drawing.Point(29, 24);
            this.grbGenero.Name = "grbGenero";
            this.grbGenero.Size = new System.Drawing.Size(251, 52);
            this.grbGenero.TabIndex = 0;
            this.grbGenero.TabStop = false;
            this.grbGenero.Text = "Género";
            // 
            // radFeminino
            // 
            this.radFeminino.AutoSize = true;
            this.radFeminino.Location = new System.Drawing.Point(154, 19);
            this.radFeminino.Name = "radFeminino";
            this.radFeminino.Size = new System.Drawing.Size(67, 17);
            this.radFeminino.TabIndex = 1;
            this.radFeminino.Text = "Feminino";
            this.radFeminino.UseVisualStyleBackColor = true;
            // 
            // radMasculino
            // 
            this.radMasculino.AutoSize = true;
            this.radMasculino.Checked = true;
            this.radMasculino.Location = new System.Drawing.Point(21, 19);
            this.radMasculino.Name = "radMasculino";
            this.radMasculino.Size = new System.Drawing.Size(73, 17);
            this.radMasculino.TabIndex = 0;
            this.radMasculino.TabStop = true;
            this.radMasculino.Text = "Masculino";
            this.radMasculino.UseVisualStyleBackColor = true;
            // 
            // grbUtente
            // 
            this.grbUtente.Controls.Add(this.txtIdade);
            this.grbUtente.Controls.Add(this.label4);
            this.grbUtente.Controls.Add(this.nudAltura);
            this.grbUtente.Controls.Add(this.nudPeso);
            this.grbUtente.Controls.Add(this.label2);
            this.grbUtente.Controls.Add(this.label1);
            this.grbUtente.Location = new System.Drawing.Point(12, 124);
            this.grbUtente.Name = "grbUtente";
            this.grbUtente.Size = new System.Drawing.Size(319, 103);
            this.grbUtente.TabIndex = 2;
            this.grbUtente.TabStop = false;
            this.grbUtente.Text = "Dados do Utente";
            // 
            // txtIdade
            // 
            this.txtIdade.Location = new System.Drawing.Point(78, 25);
            this.txtIdade.Name = "txtIdade";
            this.txtIdade.Size = new System.Drawing.Size(100, 20);
            this.txtIdade.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(144, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Altura";
            // 
            // nudAltura
            // 
            this.nudAltura.DecimalPlaces = 2;
            this.nudAltura.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.nudAltura.Location = new System.Drawing.Point(195, 72);
            this.nudAltura.Maximum = new decimal(new int[] {
            25,
            0,
            0,
            65536});
            this.nudAltura.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudAltura.Name = "nudAltura";
            this.nudAltura.Size = new System.Drawing.Size(67, 20);
            this.nudAltura.TabIndex = 4;
            this.nudAltura.Value = new decimal(new int[] {
            150,
            0,
            0,
            131072});
            // 
            // nudPeso
            // 
            this.nudPeso.Location = new System.Drawing.Point(71, 72);
            this.nudPeso.Maximum = new decimal(new int[] {
            250,
            0,
            0,
            0});
            this.nudPeso.Minimum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.nudPeso.Name = "nudPeso";
            this.nudPeso.Size = new System.Drawing.Size(51, 20);
            this.nudPeso.TabIndex = 3;
            this.nudPeso.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Peso";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Idade";
            // 
            // btnRepor
            // 
            this.btnRepor.Location = new System.Drawing.Point(337, 198);
            this.btnRepor.Name = "btnRepor";
            this.btnRepor.Size = new System.Drawing.Size(75, 29);
            this.btnRepor.TabIndex = 6;
            this.btnRepor.Text = "Repor";
            this.btnRepor.UseVisualStyleBackColor = true;
            this.btnRepor.Click += new System.EventHandler(this.BtnRepor_Click);
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(337, 136);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 29);
            this.btnCalcular.TabIndex = 7;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.BtnCalcular_Click);
            // 
            // grbInformacoes
            // 
            this.grbInformacoes.Controls.Add(this.lblIMC);
            this.grbInformacoes.Controls.Add(this.lblClassificacao);
            this.grbInformacoes.Controls.Add(this.lblRisco);
            this.grbInformacoes.Controls.Add(this.label7);
            this.grbInformacoes.Controls.Add(this.label6);
            this.grbInformacoes.Controls.Add(this.label5);
            this.grbInformacoes.Location = new System.Drawing.Point(12, 252);
            this.grbInformacoes.Name = "grbInformacoes";
            this.grbInformacoes.Size = new System.Drawing.Size(400, 125);
            this.grbInformacoes.TabIndex = 8;
            this.grbInformacoes.TabStop = false;
            this.grbInformacoes.Text = "Informações";
            // 
            // lblIMC
            // 
            this.lblIMC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblIMC.Location = new System.Drawing.Point(171, 15);
            this.lblIMC.Name = "lblIMC";
            this.lblIMC.Size = new System.Drawing.Size(176, 23);
            this.lblIMC.TabIndex = 5;
            // 
            // lblClassificacao
            // 
            this.lblClassificacao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblClassificacao.Location = new System.Drawing.Point(219, 53);
            this.lblClassificacao.Name = "lblClassificacao";
            this.lblClassificacao.Size = new System.Drawing.Size(128, 23);
            this.lblClassificacao.TabIndex = 4;
            // 
            // lblRisco
            // 
            this.lblRisco.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblRisco.Location = new System.Drawing.Point(195, 98);
            this.lblRisco.Name = "lblRisco";
            this.lblRisco.Size = new System.Drawing.Size(152, 23);
            this.lblRisco.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(87, 99);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Risco de Saúde";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(87, 54);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Classificação do Peso";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(87, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Valor IMC";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 398);
            this.Controls.Add(this.grbInformacoes);
            this.Controls.Add(this.btnRepor);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.grbUtente);
            this.Controls.Add(this.grbGenero);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Indice de Massa Corporal";
            this.grbGenero.ResumeLayout(false);
            this.grbGenero.PerformLayout();
            this.grbUtente.ResumeLayout(false);
            this.grbUtente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAltura)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPeso)).EndInit();
            this.grbInformacoes.ResumeLayout(false);
            this.grbInformacoes.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbGenero;
        private System.Windows.Forms.RadioButton radFeminino;
        private System.Windows.Forms.RadioButton radMasculino;
        private System.Windows.Forms.GroupBox grbUtente;
        private System.Windows.Forms.TextBox txtIdade;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nudAltura;
        private System.Windows.Forms.NumericUpDown nudPeso;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRepor;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.GroupBox grbInformacoes;
        private System.Windows.Forms.Label lblIMC;
        private System.Windows.Forms.Label lblClassificacao;
        private System.Windows.Forms.Label lblRisco;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
    }
}

