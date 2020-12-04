namespace Jogo_do_Galo
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
            this.pnlTop = new System.Windows.Forms.Panel();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnReiniciar = new System.Windows.Forms.Button();
            this.btnIniciar = new System.Windows.Forms.Button();
            this.grbOpcoes = new System.Windows.Forms.GroupBox();
            this.rbtO = new System.Windows.Forms.RadioButton();
            this.rbtX = new System.Windows.Forms.RadioButton();
            this.grbEmpate = new System.Windows.Forms.GroupBox();
            this.lblEmpate = new System.Windows.Forms.Label();
            this.grbPlacar = new System.Windows.Forms.GroupBox();
            this.lblVitoria1 = new System.Windows.Forms.Label();
            this.lblVitoria2 = new System.Windows.Forms.Label();
            this.grbJogadores = new System.Windows.Forms.GroupBox();
            this.txtPlayer2 = new System.Windows.Forms.TextBox();
            this.txtPlayer1 = new System.Windows.Forms.TextBox();
            this.lblJogador1 = new System.Windows.Forms.Label();
            this.lblJogador2 = new System.Windows.Forms.Label();
            this.pnlBaixo = new System.Windows.Forms.Panel();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.pnlTop.SuspendLayout();
            this.grbOpcoes.SuspendLayout();
            this.grbEmpate.SuspendLayout();
            this.grbPlacar.SuspendLayout();
            this.grbJogadores.SuspendLayout();
            this.pnlBaixo.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.Fuchsia;
            this.pnlTop.Controls.Add(this.btnSair);
            this.pnlTop.Controls.Add(this.btnReiniciar);
            this.pnlTop.Controls.Add(this.btnIniciar);
            this.pnlTop.Controls.Add(this.grbOpcoes);
            this.pnlTop.Controls.Add(this.grbEmpate);
            this.pnlTop.Controls.Add(this.grbPlacar);
            this.pnlTop.Controls.Add(this.grbJogadores);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(828, 247);
            this.pnlTop.TabIndex = 0;
            // 
            // btnSair
            // 
            this.btnSair.Font = new System.Drawing.Font("MV Boli", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Location = new System.Drawing.Point(646, 192);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(151, 43);
            this.btnSair.TabIndex = 9;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.Button1_Click);
            // 
            // btnReiniciar
            // 
            this.btnReiniciar.Font = new System.Drawing.Font("MV Boli", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReiniciar.Location = new System.Drawing.Point(470, 192);
            this.btnReiniciar.Name = "btnReiniciar";
            this.btnReiniciar.Size = new System.Drawing.Size(148, 43);
            this.btnReiniciar.TabIndex = 10;
            this.btnReiniciar.Text = "Reiniciar";
            this.btnReiniciar.UseVisualStyleBackColor = true;
            this.btnReiniciar.Click += new System.EventHandler(this.BtnReiniciar_Click);
            // 
            // btnIniciar
            // 
            this.btnIniciar.Font = new System.Drawing.Font("MV Boli", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIniciar.Location = new System.Drawing.Point(290, 192);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(148, 43);
            this.btnIniciar.TabIndex = 11;
            this.btnIniciar.Text = "Iniciar";
            this.btnIniciar.UseVisualStyleBackColor = true;
            this.btnIniciar.Click += new System.EventHandler(this.BtnIniciar_Click);
            // 
            // grbOpcoes
            // 
            this.grbOpcoes.Controls.Add(this.rbtO);
            this.grbOpcoes.Controls.Add(this.rbtX);
            this.grbOpcoes.Font = new System.Drawing.Font("MV Boli", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbOpcoes.Location = new System.Drawing.Point(0, 172);
            this.grbOpcoes.Name = "grbOpcoes";
            this.grbOpcoes.Size = new System.Drawing.Size(186, 75);
            this.grbOpcoes.TabIndex = 7;
            this.grbOpcoes.TabStop = false;
            this.grbOpcoes.Text = "Opções";
            // 
            // rbtO
            // 
            this.rbtO.AutoSize = true;
            this.rbtO.Location = new System.Drawing.Point(107, 37);
            this.rbtO.Name = "rbtO";
            this.rbtO.Size = new System.Drawing.Size(46, 32);
            this.rbtO.TabIndex = 1;
            this.rbtO.Text = "O";
            this.rbtO.UseVisualStyleBackColor = true;
            // 
            // rbtX
            // 
            this.rbtX.AutoSize = true;
            this.rbtX.Checked = true;
            this.rbtX.Location = new System.Drawing.Point(18, 37);
            this.rbtX.Name = "rbtX";
            this.rbtX.Size = new System.Drawing.Size(46, 32);
            this.rbtX.TabIndex = 0;
            this.rbtX.TabStop = true;
            this.rbtX.Text = "X";
            this.rbtX.UseVisualStyleBackColor = true;
            // 
            // grbEmpate
            // 
            this.grbEmpate.Controls.Add(this.lblEmpate);
            this.grbEmpate.Font = new System.Drawing.Font("MV Boli", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbEmpate.Location = new System.Drawing.Point(608, 0);
            this.grbEmpate.Name = "grbEmpate";
            this.grbEmpate.Size = new System.Drawing.Size(214, 132);
            this.grbEmpate.TabIndex = 6;
            this.grbEmpate.TabStop = false;
            this.grbEmpate.Text = "Empate";
            // 
            // lblEmpate
            // 
            this.lblEmpate.AutoSize = true;
            this.lblEmpate.Location = new System.Drawing.Point(33, 42);
            this.lblEmpate.Name = "lblEmpate";
            this.lblEmpate.Size = new System.Drawing.Size(0, 28);
            this.lblEmpate.TabIndex = 7;
            // 
            // grbPlacar
            // 
            this.grbPlacar.Controls.Add(this.lblVitoria1);
            this.grbPlacar.Controls.Add(this.lblVitoria2);
            this.grbPlacar.Font = new System.Drawing.Font("MV Boli", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbPlacar.Location = new System.Drawing.Point(316, 0);
            this.grbPlacar.Name = "grbPlacar";
            this.grbPlacar.Size = new System.Drawing.Size(229, 132);
            this.grbPlacar.TabIndex = 6;
            this.grbPlacar.TabStop = false;
            this.grbPlacar.Text = "Placar";
            // 
            // lblVitoria1
            // 
            this.lblVitoria1.AutoSize = true;
            this.lblVitoria1.Location = new System.Drawing.Point(31, 38);
            this.lblVitoria1.Name = "lblVitoria1";
            this.lblVitoria1.Size = new System.Drawing.Size(0, 28);
            this.lblVitoria1.TabIndex = 4;
            // 
            // lblVitoria2
            // 
            this.lblVitoria2.AutoSize = true;
            this.lblVitoria2.Location = new System.Drawing.Point(31, 84);
            this.lblVitoria2.Name = "lblVitoria2";
            this.lblVitoria2.Size = new System.Drawing.Size(0, 28);
            this.lblVitoria2.TabIndex = 5;
            // 
            // grbJogadores
            // 
            this.grbJogadores.Controls.Add(this.txtPlayer2);
            this.grbJogadores.Controls.Add(this.txtPlayer1);
            this.grbJogadores.Controls.Add(this.lblJogador1);
            this.grbJogadores.Controls.Add(this.lblJogador2);
            this.grbJogadores.Font = new System.Drawing.Font("MV Boli", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbJogadores.Location = new System.Drawing.Point(0, 0);
            this.grbJogadores.Name = "grbJogadores";
            this.grbJogadores.Size = new System.Drawing.Size(238, 132);
            this.grbJogadores.TabIndex = 2;
            this.grbJogadores.TabStop = false;
            this.grbJogadores.Text = "Jogadores";
            // 
            // txtPlayer2
            // 
            this.txtPlayer2.Location = new System.Drawing.Point(12, 84);
            this.txtPlayer2.Multiline = true;
            this.txtPlayer2.Name = "txtPlayer2";
            this.txtPlayer2.Size = new System.Drawing.Size(168, 29);
            this.txtPlayer2.TabIndex = 3;
            this.txtPlayer2.TextChanged += new System.EventHandler(this.TextBox2_TextChanged);
            // 
            // txtPlayer1
            // 
            this.txtPlayer1.Location = new System.Drawing.Point(12, 36);
            this.txtPlayer1.Multiline = true;
            this.txtPlayer1.Name = "txtPlayer1";
            this.txtPlayer1.Size = new System.Drawing.Size(168, 30);
            this.txtPlayer1.TabIndex = 2;
            // 
            // lblJogador1
            // 
            this.lblJogador1.AutoSize = true;
            this.lblJogador1.Location = new System.Drawing.Point(24, 39);
            this.lblJogador1.Name = "lblJogador1";
            this.lblJogador1.Size = new System.Drawing.Size(0, 28);
            this.lblJogador1.TabIndex = 0;
            // 
            // lblJogador2
            // 
            this.lblJogador2.AutoSize = true;
            this.lblJogador2.Location = new System.Drawing.Point(24, 85);
            this.lblJogador2.Name = "lblJogador2";
            this.lblJogador2.Size = new System.Drawing.Size(0, 28);
            this.lblJogador2.TabIndex = 1;
            // 
            // pnlBaixo
            // 
            this.pnlBaixo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.pnlBaixo.Controls.Add(this.btn5);
            this.pnlBaixo.Controls.Add(this.btn3);
            this.pnlBaixo.Controls.Add(this.btn6);
            this.pnlBaixo.Controls.Add(this.btn4);
            this.pnlBaixo.Controls.Add(this.btn7);
            this.pnlBaixo.Controls.Add(this.btn8);
            this.pnlBaixo.Controls.Add(this.btn2);
            this.pnlBaixo.Controls.Add(this.btn9);
            this.pnlBaixo.Controls.Add(this.btn1);
            this.pnlBaixo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBaixo.Location = new System.Drawing.Point(0, 247);
            this.pnlBaixo.Name = "pnlBaixo";
            this.pnlBaixo.Size = new System.Drawing.Size(828, 257);
            this.pnlBaixo.TabIndex = 1;
            this.pnlBaixo.Paint += new System.Windows.Forms.PaintEventHandler(this.PnlBaixo_Paint);
            // 
            // btn5
            // 
            this.btn5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn5.Font = new System.Drawing.Font("MV Boli", 20.75F, System.Drawing.FontStyle.Bold);
            this.btn5.ForeColor = System.Drawing.Color.White;
            this.btn5.Image = ((System.Drawing.Image)(resources.GetObject("btn5.Image")));
            this.btn5.Location = new System.Drawing.Point(372, 97);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(76, 69);
            this.btn5.TabIndex = 8;
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.Btn5_Click);
            // 
            // btn3
            // 
            this.btn3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn3.Font = new System.Drawing.Font("MV Boli", 20.75F, System.Drawing.FontStyle.Bold);
            this.btn3.ForeColor = System.Drawing.Color.White;
            this.btn3.Image = ((System.Drawing.Image)(resources.GetObject("btn3.Image")));
            this.btn3.Location = new System.Drawing.Point(454, 22);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(76, 69);
            this.btn3.TabIndex = 7;
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.Btn3_Click);
            // 
            // btn6
            // 
            this.btn6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn6.Font = new System.Drawing.Font("MV Boli", 20.75F, System.Drawing.FontStyle.Bold);
            this.btn6.ForeColor = System.Drawing.Color.White;
            this.btn6.Image = ((System.Drawing.Image)(resources.GetObject("btn6.Image")));
            this.btn6.Location = new System.Drawing.Point(454, 97);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(76, 69);
            this.btn6.TabIndex = 6;
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.Btn6_Click);
            // 
            // btn4
            // 
            this.btn4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn4.Font = new System.Drawing.Font("MV Boli", 20.75F, System.Drawing.FontStyle.Bold);
            this.btn4.ForeColor = System.Drawing.Color.White;
            this.btn4.Image = ((System.Drawing.Image)(resources.GetObject("btn4.Image")));
            this.btn4.Location = new System.Drawing.Point(290, 97);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(76, 69);
            this.btn4.TabIndex = 5;
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.Btn4_Click);
            // 
            // btn7
            // 
            this.btn7.Font = new System.Drawing.Font("MV Boli", 20.75F, System.Drawing.FontStyle.Bold);
            this.btn7.ForeColor = System.Drawing.Color.White;
            this.btn7.Image = ((System.Drawing.Image)(resources.GetObject("btn7.Image")));
            this.btn7.Location = new System.Drawing.Point(290, 172);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(76, 69);
            this.btn7.TabIndex = 4;
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.Btn7_Click);
            // 
            // btn8
            // 
            this.btn8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn8.Font = new System.Drawing.Font("MV Boli", 20.75F, System.Drawing.FontStyle.Bold);
            this.btn8.ForeColor = System.Drawing.Color.White;
            this.btn8.Image = ((System.Drawing.Image)(resources.GetObject("btn8.Image")));
            this.btn8.Location = new System.Drawing.Point(372, 172);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(76, 69);
            this.btn8.TabIndex = 3;
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.Btn8_Click);
            // 
            // btn2
            // 
            this.btn2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn2.Font = new System.Drawing.Font("MV Boli", 20.75F, System.Drawing.FontStyle.Bold);
            this.btn2.ForeColor = System.Drawing.Color.White;
            this.btn2.Image = ((System.Drawing.Image)(resources.GetObject("btn2.Image")));
            this.btn2.Location = new System.Drawing.Point(372, 22);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(76, 69);
            this.btn2.TabIndex = 2;
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.Btn2_Click);
            // 
            // btn9
            // 
            this.btn9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn9.Font = new System.Drawing.Font("MV Boli", 20.75F, System.Drawing.FontStyle.Bold);
            this.btn9.ForeColor = System.Drawing.Color.White;
            this.btn9.Image = ((System.Drawing.Image)(resources.GetObject("btn9.Image")));
            this.btn9.Location = new System.Drawing.Point(454, 172);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(76, 69);
            this.btn9.TabIndex = 1;
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.Click += new System.EventHandler(this.Btn9_Click);
            // 
            // btn1
            // 
            this.btn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn1.Font = new System.Drawing.Font("MV Boli", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1.ForeColor = System.Drawing.Color.White;
            this.btn1.Image = ((System.Drawing.Image)(resources.GetObject("btn1.Image")));
            this.btn1.Location = new System.Drawing.Point(290, 22);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(76, 69);
            this.btn1.TabIndex = 0;
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.Btn1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(828, 504);
            this.Controls.Add(this.pnlBaixo);
            this.Controls.Add(this.pnlTop);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Jogo Do Galo";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.pnlTop.ResumeLayout(false);
            this.grbOpcoes.ResumeLayout(false);
            this.grbOpcoes.PerformLayout();
            this.grbEmpate.ResumeLayout(false);
            this.grbEmpate.PerformLayout();
            this.grbPlacar.ResumeLayout(false);
            this.grbPlacar.PerformLayout();
            this.grbJogadores.ResumeLayout(false);
            this.grbJogadores.PerformLayout();
            this.pnlBaixo.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.GroupBox grbOpcoes;
        private System.Windows.Forms.RadioButton rbtO;
        private System.Windows.Forms.RadioButton rbtX;
        private System.Windows.Forms.GroupBox grbEmpate;
        private System.Windows.Forms.Label lblEmpate;
        private System.Windows.Forms.GroupBox grbPlacar;
        private System.Windows.Forms.Label lblVitoria1;
        private System.Windows.Forms.Label lblVitoria2;
        private System.Windows.Forms.GroupBox grbJogadores;
        private System.Windows.Forms.TextBox txtPlayer2;
        private System.Windows.Forms.TextBox txtPlayer1;
        private System.Windows.Forms.Label lblJogador1;
        private System.Windows.Forms.Label lblJogador2;
        private System.Windows.Forms.Panel pnlBaixo;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnReiniciar;
        private System.Windows.Forms.Button btnIniciar;
    }
}

