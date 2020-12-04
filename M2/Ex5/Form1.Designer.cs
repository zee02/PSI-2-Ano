namespace Ex5
{
    partial class Calculadora
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Calculadora));
            this.lblNumero1 = new System.Windows.Forms.Label();
            this.txtInsere1 = new System.Windows.Forms.TextBox();
            this.lblNumero2 = new System.Windows.Forms.Label();
            this.txtInsere2 = new System.Windows.Forms.TextBox();
            this.lblResult = new System.Windows.Forms.Label();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.rbtSoma = new System.Windows.Forms.RadioButton();
            this.lblOperation = new System.Windows.Forms.Label();
            this.rbtMulti = new System.Windows.Forms.RadioButton();
            this.rbtDivisao = new System.Windows.Forms.RadioButton();
            this.rbtSub = new System.Windows.Forms.RadioButton();
            this.btnCalcula = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.tcrlcalc = new System.Windows.Forms.TabControl();
            this.tabCalc = new System.Windows.Forms.TabPage();
            this.tabTab = new System.Windows.Forms.TabPage();
            this.rtxtAparece = new System.Windows.Forms.RichTextBox();
            this.btnTablimpa = new System.Windows.Forms.Button();
            this.btnTabcalcula = new System.Windows.Forms.Button();
            this.lblNumero = new System.Windows.Forms.Label();
            this.txtTabInsere = new System.Windows.Forms.TextBox();
            this.tabMultiplos = new System.Windows.Forms.TabPage();
            this.btnMultLimpa = new System.Windows.Forms.Button();
            this.btxCalc = new System.Windows.Forms.Button();
            this.rtxtMostra = new System.Windows.Forms.RichTextBox();
            this.lblMultInsere = new System.Windows.Forms.Label();
            this.txtMultInsere = new System.Windows.Forms.TextBox();
            this.tcrlcalc.SuspendLayout();
            this.tabCalc.SuspendLayout();
            this.tabTab.SuspendLayout();
            this.tabMultiplos.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNumero1
            // 
            this.lblNumero1.AutoSize = true;
            this.lblNumero1.Location = new System.Drawing.Point(6, 26);
            this.lblNumero1.Name = "lblNumero1";
            this.lblNumero1.Size = new System.Drawing.Size(44, 13);
            this.lblNumero1.TabIndex = 0;
            this.lblNumero1.Text = "Número";
            // 
            // txtInsere1
            // 
            this.txtInsere1.Location = new System.Drawing.Point(65, 26);
            this.txtInsere1.Name = "txtInsere1";
            this.txtInsere1.Size = new System.Drawing.Size(90, 20);
            this.txtInsere1.TabIndex = 1;
            this.txtInsere1.TextChanged += new System.EventHandler(this.TxtInsere1_TextChanged_1);
            // 
            // lblNumero2
            // 
            this.lblNumero2.AutoSize = true;
            this.lblNumero2.Location = new System.Drawing.Point(8, 89);
            this.lblNumero2.Name = "lblNumero2";
            this.lblNumero2.Size = new System.Drawing.Size(44, 13);
            this.lblNumero2.TabIndex = 2;
            this.lblNumero2.Text = "Número";
            this.lblNumero2.Click += new System.EventHandler(this.LblNumero2_Click);
            // 
            // txtInsere2
            // 
            this.txtInsere2.Location = new System.Drawing.Point(65, 82);
            this.txtInsere2.Name = "txtInsere2";
            this.txtInsere2.Size = new System.Drawing.Size(90, 20);
            this.txtInsere2.TabIndex = 3;
            this.txtInsere2.TextChanged += new System.EventHandler(this.TxtInsere2_TextChanged_1);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(91, 147);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(55, 13);
            this.lblResult.TabIndex = 4;
            this.lblResult.Text = "Resultado";
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(65, 174);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(110, 20);
            this.txtResult.TabIndex = 5;
            this.txtResult.TextChanged += new System.EventHandler(this.TxtResult_TextChanged_1);
            // 
            // rbtSoma
            // 
            this.rbtSoma.AutoSize = true;
            this.rbtSoma.Location = new System.Drawing.Point(318, 48);
            this.rbtSoma.Name = "rbtSoma";
            this.rbtSoma.Size = new System.Drawing.Size(52, 17);
            this.rbtSoma.TabIndex = 6;
            this.rbtSoma.TabStop = true;
            this.rbtSoma.Text = "Soma";
            this.rbtSoma.UseVisualStyleBackColor = true;
            // 
            // lblOperation
            // 
            this.lblOperation.AutoSize = true;
            this.lblOperation.Location = new System.Drawing.Point(319, 16);
            this.lblOperation.Name = "lblOperation";
            this.lblOperation.Size = new System.Drawing.Size(59, 13);
            this.lblOperation.TabIndex = 7;
            this.lblOperation.Text = "Operações";
            // 
            // rbtMulti
            // 
            this.rbtMulti.AutoSize = true;
            this.rbtMulti.Location = new System.Drawing.Point(318, 82);
            this.rbtMulti.Name = "rbtMulti";
            this.rbtMulti.Size = new System.Drawing.Size(87, 17);
            this.rbtMulti.TabIndex = 8;
            this.rbtMulti.TabStop = true;
            this.rbtMulti.Text = "Multiplicação";
            this.rbtMulti.UseVisualStyleBackColor = true;
            this.rbtMulti.CheckedChanged += new System.EventHandler(this.TcrlMulti_CheckedChanged);
            // 
            // rbtDivisao
            // 
            this.rbtDivisao.AutoSize = true;
            this.rbtDivisao.Location = new System.Drawing.Point(318, 113);
            this.rbtDivisao.Name = "rbtDivisao";
            this.rbtDivisao.Size = new System.Drawing.Size(60, 17);
            this.rbtDivisao.TabIndex = 9;
            this.rbtDivisao.TabStop = true;
            this.rbtDivisao.Text = "Divisão";
            this.rbtDivisao.UseVisualStyleBackColor = true;
            this.rbtDivisao.CheckedChanged += new System.EventHandler(this.TcrlDivisao_CheckedChanged);
            // 
            // rbtSub
            // 
            this.rbtSub.AutoSize = true;
            this.rbtSub.Location = new System.Drawing.Point(318, 145);
            this.rbtSub.Name = "rbtSub";
            this.rbtSub.Size = new System.Drawing.Size(74, 17);
            this.rbtSub.TabIndex = 10;
            this.rbtSub.TabStop = true;
            this.rbtSub.Text = "Subtração";
            this.rbtSub.UseVisualStyleBackColor = true;
            this.rbtSub.CheckedChanged += new System.EventHandler(this.TcrlSub_CheckedChanged);
            // 
            // btnCalcula
            // 
            this.btnCalcula.Location = new System.Drawing.Point(308, 188);
            this.btnCalcula.Name = "btnCalcula";
            this.btnCalcula.Size = new System.Drawing.Size(106, 28);
            this.btnCalcula.TabIndex = 11;
            this.btnCalcula.Text = "Calcular";
            this.btnCalcula.UseVisualStyleBackColor = true;
            this.btnCalcula.Click += new System.EventHandler(this.Button1_Click);
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(20, 222);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(70, 24);
            this.btnSair.TabIndex = 12;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.BtnSair_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(308, 222);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(106, 25);
            this.btnLimpar.TabIndex = 13;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.BtnLimpar_Click);
            // 
            // tcrlcalc
            // 
            this.tcrlcalc.Controls.Add(this.tabCalc);
            this.tcrlcalc.Controls.Add(this.tabTab);
            this.tcrlcalc.Controls.Add(this.tabMultiplos);
            this.tcrlcalc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcrlcalc.Location = new System.Drawing.Point(0, 0);
            this.tcrlcalc.Name = "tcrlcalc";
            this.tcrlcalc.SelectedIndex = 0;
            this.tcrlcalc.Size = new System.Drawing.Size(436, 280);
            this.tcrlcalc.TabIndex = 14;
            // 
            // tabCalc
            // 
            this.tabCalc.Controls.Add(this.txtInsere1);
            this.tabCalc.Controls.Add(this.btnLimpar);
            this.tabCalc.Controls.Add(this.lblNumero1);
            this.tabCalc.Controls.Add(this.btnCalcula);
            this.tabCalc.Controls.Add(this.btnSair);
            this.tabCalc.Controls.Add(this.rbtSub);
            this.tabCalc.Controls.Add(this.txtInsere2);
            this.tabCalc.Controls.Add(this.rbtDivisao);
            this.tabCalc.Controls.Add(this.lblNumero2);
            this.tabCalc.Controls.Add(this.rbtMulti);
            this.tabCalc.Controls.Add(this.lblResult);
            this.tabCalc.Controls.Add(this.rbtSoma);
            this.tabCalc.Controls.Add(this.lblOperation);
            this.tabCalc.Controls.Add(this.txtResult);
            this.tabCalc.Location = new System.Drawing.Point(4, 22);
            this.tabCalc.Name = "tabCalc";
            this.tabCalc.Padding = new System.Windows.Forms.Padding(3);
            this.tabCalc.Size = new System.Drawing.Size(428, 254);
            this.tabCalc.TabIndex = 0;
            this.tabCalc.Text = "Calculadora";
            this.tabCalc.UseVisualStyleBackColor = true;
            this.tabCalc.Click += new System.EventHandler(this.TabCalc_Click);
            // 
            // tabTab
            // 
            this.tabTab.Controls.Add(this.rtxtAparece);
            this.tabTab.Controls.Add(this.btnTablimpa);
            this.tabTab.Controls.Add(this.btnTabcalcula);
            this.tabTab.Controls.Add(this.lblNumero);
            this.tabTab.Controls.Add(this.txtTabInsere);
            this.tabTab.Location = new System.Drawing.Point(4, 22);
            this.tabTab.Name = "tabTab";
            this.tabTab.Padding = new System.Windows.Forms.Padding(3);
            this.tabTab.Size = new System.Drawing.Size(428, 254);
            this.tabTab.TabIndex = 1;
            this.tabTab.Text = "Tabuada";
            this.tabTab.UseVisualStyleBackColor = true;
            // 
            // rtxtAparece
            // 
            this.rtxtAparece.Location = new System.Drawing.Point(14, 15);
            this.rtxtAparece.Name = "rtxtAparece";
            this.rtxtAparece.Size = new System.Drawing.Size(125, 220);
            this.rtxtAparece.TabIndex = 4;
            this.rtxtAparece.Text = "";
            this.rtxtAparece.TextChanged += new System.EventHandler(this.RichTextBox1_TextChanged);
            // 
            // btnTablimpa
            // 
            this.btnTablimpa.Location = new System.Drawing.Point(291, 210);
            this.btnTablimpa.Name = "btnTablimpa";
            this.btnTablimpa.Size = new System.Drawing.Size(102, 26);
            this.btnTablimpa.TabIndex = 3;
            this.btnTablimpa.Text = "Limpar";
            this.btnTablimpa.UseVisualStyleBackColor = true;
            this.btnTablimpa.Click += new System.EventHandler(this.BtnTablimpa_Click);
            // 
            // btnTabcalcula
            // 
            this.btnTabcalcula.Location = new System.Drawing.Point(291, 173);
            this.btnTabcalcula.Name = "btnTabcalcula";
            this.btnTabcalcula.Size = new System.Drawing.Size(102, 31);
            this.btnTabcalcula.TabIndex = 2;
            this.btnTabcalcula.Text = "Calcular";
            this.btnTabcalcula.UseVisualStyleBackColor = true;
            this.btnTabcalcula.Click += new System.EventHandler(this.BtnTabcalcula_Click);
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Location = new System.Drawing.Point(250, 32);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(172, 13);
            this.lblNumero.TabIndex = 1;
            this.lblNumero.Text = "Insere o número a saber a tabuada";
            // 
            // txtTabInsere
            // 
            this.txtTabInsere.Location = new System.Drawing.Point(262, 60);
            this.txtTabInsere.Name = "txtTabInsere";
            this.txtTabInsere.Size = new System.Drawing.Size(142, 20);
            this.txtTabInsere.TabIndex = 0;
            this.txtTabInsere.TextChanged += new System.EventHandler(this.TxtTabInsere_TextChanged);
            // 
            // tabMultiplos
            // 
            this.tabMultiplos.Controls.Add(this.btnMultLimpa);
            this.tabMultiplos.Controls.Add(this.btxCalc);
            this.tabMultiplos.Controls.Add(this.rtxtMostra);
            this.tabMultiplos.Controls.Add(this.lblMultInsere);
            this.tabMultiplos.Controls.Add(this.txtMultInsere);
            this.tabMultiplos.Location = new System.Drawing.Point(4, 22);
            this.tabMultiplos.Name = "tabMultiplos";
            this.tabMultiplos.Size = new System.Drawing.Size(428, 254);
            this.tabMultiplos.TabIndex = 2;
            this.tabMultiplos.Text = "Multiplos";
            this.tabMultiplos.UseVisualStyleBackColor = true;
            // 
            // btnMultLimpa
            // 
            this.btnMultLimpa.Location = new System.Drawing.Point(303, 55);
            this.btnMultLimpa.Name = "btnMultLimpa";
            this.btnMultLimpa.Size = new System.Drawing.Size(105, 34);
            this.btnMultLimpa.TabIndex = 4;
            this.btnMultLimpa.Text = "Limpar";
            this.btnMultLimpa.UseVisualStyleBackColor = true;
            this.btnMultLimpa.Click += new System.EventHandler(this.BtnMultLimpa_Click_1);
            // 
            // btxCalc
            // 
            this.btxCalc.Location = new System.Drawing.Point(8, 51);
            this.btxCalc.Name = "btxCalc";
            this.btxCalc.Size = new System.Drawing.Size(105, 38);
            this.btxCalc.TabIndex = 3;
            this.btxCalc.Text = "Calcular";
            this.btxCalc.UseVisualStyleBackColor = true;
            this.btxCalc.Click += new System.EventHandler(this.BtxCalc_Click);
            // 
            // rtxtMostra
            // 
            this.rtxtMostra.Location = new System.Drawing.Point(156, 18);
            this.rtxtMostra.Name = "rtxtMostra";
            this.rtxtMostra.Size = new System.Drawing.Size(99, 166);
            this.rtxtMostra.TabIndex = 2;
            this.rtxtMostra.Text = "";
            // 
            // lblMultInsere
            // 
            this.lblMultInsere.AutoSize = true;
            this.lblMultInsere.Location = new System.Drawing.Point(168, 197);
            this.lblMultInsere.Name = "lblMultInsere";
            this.lblMultInsere.Size = new System.Drawing.Size(74, 13);
            this.lblMultInsere.TabIndex = 1;
            this.lblMultInsere.Text = "Insere número";
            // 
            // txtMultInsere
            // 
            this.txtMultInsere.Location = new System.Drawing.Point(129, 226);
            this.txtMultInsere.Name = "txtMultInsere";
            this.txtMultInsere.Size = new System.Drawing.Size(164, 20);
            this.txtMultInsere.TabIndex = 0;
            // 
            // Calculadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 280);
            this.Controls.Add(this.tcrlcalc);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Calculadora";
            this.Text = "Calculadora";
            this.Load += new System.EventHandler(this.Calculadora_Load);
            this.tcrlcalc.ResumeLayout(false);
            this.tabCalc.ResumeLayout(false);
            this.tabCalc.PerformLayout();
            this.tabTab.ResumeLayout(false);
            this.tabTab.PerformLayout();
            this.tabMultiplos.ResumeLayout(false);
            this.tabMultiplos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblNumero1;
        private System.Windows.Forms.TextBox txtInsere1;
        private System.Windows.Forms.Label lblNumero2;
        private System.Windows.Forms.TextBox txtInsere2;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.RadioButton rbtSoma;
        private System.Windows.Forms.Label lblOperation;
        private System.Windows.Forms.RadioButton rbtMulti;
        private System.Windows.Forms.RadioButton rbtDivisao;
        private System.Windows.Forms.RadioButton rbtSub;
        private System.Windows.Forms.Button btnCalcula;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.TabControl tcrlcalc;
        private System.Windows.Forms.TabPage tabTab;
        private System.Windows.Forms.TabPage tabMultiplos;
        private System.Windows.Forms.TabPage tabCalc;
        private System.Windows.Forms.RichTextBox rtxtAparece;
        private System.Windows.Forms.Button btnTablimpa;
        private System.Windows.Forms.Button btnTabcalcula;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.TextBox txtTabInsere;
        private System.Windows.Forms.Button btnMultLimpa;
        private System.Windows.Forms.Button btxCalc;
        private System.Windows.Forms.RichTextBox rtxtMostra;
        private System.Windows.Forms.Label lblMultInsere;
        private System.Windows.Forms.TextBox txtMultInsere;
    }
}

