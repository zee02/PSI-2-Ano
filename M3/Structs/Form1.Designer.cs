namespace Structs
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.cboClube = new System.Windows.Forms.ComboBox();
            this.cboProva = new System.Windows.Forms.ComboBox();
            this.btnInserir = new System.Windows.Forms.Button();
            this.btnListagem = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblDorsal = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dorsal";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(53, 54);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(245, 20);
            this.txtNome.TabIndex = 1;
            // 
            // cboClube
            // 
            this.cboClube.FormattingEnabled = true;
            this.cboClube.Items.AddRange(new object[] {
            "Sporting Clube de Portugal",
            "Sport Lisboa e Benfica",
            "FC Amadora",
            "Reboleira AC",
            "FC Porto"});
            this.cboClube.Location = new System.Drawing.Point(53, 95);
            this.cboClube.Name = "cboClube";
            this.cboClube.Size = new System.Drawing.Size(245, 21);
            this.cboClube.TabIndex = 2;
            // 
            // cboProva
            // 
            this.cboProva.FormattingEnabled = true;
            this.cboProva.Items.AddRange(new object[] {
            "Futebol",
            "Natação",
            "Basquetball",
            "Triatlo (Fem/Masc)",
            "Volley",
            "Hóquei"});
            this.cboProva.Location = new System.Drawing.Point(53, 131);
            this.cboProva.Name = "cboProva";
            this.cboProva.Size = new System.Drawing.Size(245, 21);
            this.cboProva.TabIndex = 3;
            // 
            // btnInserir
            // 
            this.btnInserir.Location = new System.Drawing.Point(187, 180);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(75, 23);
            this.btnInserir.TabIndex = 4;
            this.btnInserir.Text = "Inserir";
            this.btnInserir.UseVisualStyleBackColor = true;
            this.btnInserir.Click += new System.EventHandler(this.BtnInserir_Click);
            // 
            // btnListagem
            // 
            this.btnListagem.Location = new System.Drawing.Point(300, 180);
            this.btnListagem.Name = "btnListagem";
            this.btnListagem.Size = new System.Drawing.Size(75, 23);
            this.btnListagem.TabIndex = 5;
            this.btnListagem.Text = "Listagem";
            this.btnListagem.UseVisualStyleBackColor = true;
            this.btnListagem.Click += new System.EventHandler(this.BtnListagem_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Clube";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Nome";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Prova";
            // 
            // lblDorsal
            // 
            this.lblDorsal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDorsal.Location = new System.Drawing.Point(55, 9);
            this.lblDorsal.Name = "lblDorsal";
            this.lblDorsal.Size = new System.Drawing.Size(34, 32);
            this.lblDorsal.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 215);
            this.Controls.Add(this.lblDorsal);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnListagem);
            this.Controls.Add(this.btnInserir);
            this.Controls.Add(this.cboProva);
            this.Controls.Add(this.cboClube);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inscrições";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.ComboBox cboClube;
        private System.Windows.Forms.ComboBox cboProva;
        private System.Windows.Forms.Button btnInserir;
        private System.Windows.Forms.Button btnListagem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblDorsal;
    }
}

