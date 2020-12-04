namespace Ex1
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
            this.txtIdade = new System.Windows.Forms.TextBox();
            this.lblIdade = new System.Windows.Forms.Label();
            this.grbEstatistica = new System.Windows.Forms.GroupBox();
            this.lblPessoa2 = new System.Windows.Forms.Label();
            this.lblIdades2 = new System.Windows.Forms.Label();
            this.lblVelha2 = new System.Windows.Forms.Label();
            this.lblNova2 = new System.Windows.Forms.Label();
            this.lblNova = new System.Windows.Forms.Label();
            this.lblVelha = new System.Windows.Forms.Label();
            this.lblMedia = new System.Windows.Forms.Label();
            this.lblPessoas = new System.Windows.Forms.Label();
            this.btnOk = new System.Windows.Forms.Button();
            this.grbEstatistica.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtIdade
            // 
            this.txtIdade.Location = new System.Drawing.Point(82, 43);
            this.txtIdade.Name = "txtIdade";
            this.txtIdade.Size = new System.Drawing.Size(70, 20);
            this.txtIdade.TabIndex = 0;
            this.txtIdade.TextChanged += new System.EventHandler(this.TxtIdade_TextChanged);
            // 
            // lblIdade
            // 
            this.lblIdade.AutoSize = true;
            this.lblIdade.Location = new System.Drawing.Point(32, 46);
            this.lblIdade.Name = "lblIdade";
            this.lblIdade.Size = new System.Drawing.Size(34, 13);
            this.lblIdade.TabIndex = 1;
            this.lblIdade.Text = "Idade";
            // 
            // grbEstatistica
            // 
            this.grbEstatistica.Controls.Add(this.lblPessoa2);
            this.grbEstatistica.Controls.Add(this.lblIdades2);
            this.grbEstatistica.Controls.Add(this.lblVelha2);
            this.grbEstatistica.Controls.Add(this.lblNova2);
            this.grbEstatistica.Controls.Add(this.lblNova);
            this.grbEstatistica.Controls.Add(this.lblVelha);
            this.grbEstatistica.Controls.Add(this.lblMedia);
            this.grbEstatistica.Controls.Add(this.lblPessoas);
            this.grbEstatistica.Location = new System.Drawing.Point(35, 96);
            this.grbEstatistica.Name = "grbEstatistica";
            this.grbEstatistica.Size = new System.Drawing.Size(255, 166);
            this.grbEstatistica.TabIndex = 3;
            this.grbEstatistica.TabStop = false;
            this.grbEstatistica.Text = "Estatística";
            // 
            // lblPessoa2
            // 
            this.lblPessoa2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPessoa2.Location = new System.Drawing.Point(149, 33);
            this.lblPessoa2.Name = "lblPessoa2";
            this.lblPessoa2.Size = new System.Drawing.Size(100, 23);
            this.lblPessoa2.TabIndex = 11;
            // 
            // lblIdades2
            // 
            this.lblIdades2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblIdades2.Location = new System.Drawing.Point(149, 67);
            this.lblIdades2.Name = "lblIdades2";
            this.lblIdades2.Size = new System.Drawing.Size(100, 23);
            this.lblIdades2.TabIndex = 10;
            // 
            // lblVelha2
            // 
            this.lblVelha2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblVelha2.Location = new System.Drawing.Point(149, 101);
            this.lblVelha2.Name = "lblVelha2";
            this.lblVelha2.Size = new System.Drawing.Size(100, 23);
            this.lblVelha2.TabIndex = 9;
            // 
            // lblNova2
            // 
            this.lblNova2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblNova2.Location = new System.Drawing.Point(149, 134);
            this.lblNova2.Name = "lblNova2";
            this.lblNova2.Size = new System.Drawing.Size(100, 23);
            this.lblNova2.TabIndex = 8;
            // 
            // lblNova
            // 
            this.lblNova.AutoSize = true;
            this.lblNova.Location = new System.Drawing.Point(28, 135);
            this.lblNova.Name = "lblNova";
            this.lblNova.Size = new System.Drawing.Size(93, 13);
            this.lblNova.TabIndex = 4;
            this.lblNova.Text = "Pessoa mais nova";
            // 
            // lblVelha
            // 
            this.lblVelha.AutoSize = true;
            this.lblVelha.Location = new System.Drawing.Point(28, 101);
            this.lblVelha.Name = "lblVelha";
            this.lblVelha.Size = new System.Drawing.Size(95, 13);
            this.lblVelha.TabIndex = 5;
            this.lblVelha.Text = "Pessoa mais velha";
            // 
            // lblMedia
            // 
            this.lblMedia.AutoSize = true;
            this.lblMedia.Location = new System.Drawing.Point(28, 67);
            this.lblMedia.Name = "lblMedia";
            this.lblMedia.Size = new System.Drawing.Size(90, 13);
            this.lblMedia.TabIndex = 6;
            this.lblMedia.Text = "Médias de idades";
            // 
            // lblPessoas
            // 
            this.lblPessoas.AutoSize = true;
            this.lblPessoas.Location = new System.Drawing.Point(28, 33);
            this.lblPessoas.Name = "lblPessoas";
            this.lblPessoas.Size = new System.Drawing.Size(101, 13);
            this.lblPessoas.TabIndex = 7;
            this.lblPessoas.Text = "Número de pessoas";
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(197, 41);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 12;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.BtnOk_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 325);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.grbEstatistica);
            this.Controls.Add(this.lblIdade);
            this.Controls.Add(this.txtIdade);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Idades";
            this.grbEstatistica.ResumeLayout(false);
            this.grbEstatistica.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtIdade;
        private System.Windows.Forms.Label lblIdade;
        private System.Windows.Forms.GroupBox grbEstatistica;
        private System.Windows.Forms.Label lblPessoa2;
        private System.Windows.Forms.Label lblIdades2;
        private System.Windows.Forms.Label lblVelha2;
        private System.Windows.Forms.Label lblNova2;
        private System.Windows.Forms.Label lblNova;
        private System.Windows.Forms.Label lblVelha;
        private System.Windows.Forms.Label lblMedia;
        private System.Windows.Forms.Label lblPessoas;
        private System.Windows.Forms.Button btnOk;
    }
}

