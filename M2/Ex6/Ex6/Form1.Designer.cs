namespace Ex6
{
    partial class TryParse
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TryParse));
            this.btnFechar = new System.Windows.Forms.Button();
            this.btnConvert = new System.Windows.Forms.Button();
            this.txtParse = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtInsere = new System.Windows.Forms.TextBox();
            this.lblInserir = new System.Windows.Forms.Label();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnFechar
            // 
            this.btnFechar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFechar.ForeColor = System.Drawing.Color.Black;
            this.btnFechar.Location = new System.Drawing.Point(12, 214);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(77, 24);
            this.btnFechar.TabIndex = 0;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.BtnFechar_Click_1);
            // 
            // btnConvert
            // 
            this.btnConvert.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConvert.ForeColor = System.Drawing.Color.Black;
            this.btnConvert.Location = new System.Drawing.Point(156, 123);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(93, 24);
            this.btnConvert.TabIndex = 1;
            this.btnConvert.Text = "Converter";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.BtnConvert_Click);
            // 
            // txtParse
            // 
            this.txtParse.Enabled = false;
            this.txtParse.ForeColor = System.Drawing.Color.Black;
            this.txtParse.Location = new System.Drawing.Point(276, 79);
            this.txtParse.Name = "txtParse";
            this.txtParse.Size = new System.Drawing.Size(73, 20);
            this.txtParse.TabIndex = 2;
            this.txtParse.TextChanged += new System.EventHandler(this.TxtParse_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Perpetua Titling MT", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(262, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Conversível?";
            this.label1.Click += new System.EventHandler(this.Label1_Click_1);
            // 
            // txtInsere
            // 
            this.txtInsere.Location = new System.Drawing.Point(35, 79);
            this.txtInsere.Name = "txtInsere";
            this.txtInsere.Size = new System.Drawing.Size(69, 20);
            this.txtInsere.TabIndex = 4;
            this.txtInsere.TextChanged += new System.EventHandler(this.TxtInsere_TextChanged_1);
            // 
            // lblInserir
            // 
            this.lblInserir.AutoSize = true;
            this.lblInserir.BackColor = System.Drawing.Color.Transparent;
            this.lblInserir.Font = new System.Drawing.Font("Perpetua Titling MT", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInserir.ForeColor = System.Drawing.Color.White;
            this.lblInserir.Location = new System.Drawing.Point(9, 38);
            this.lblInserir.Name = "lblInserir";
            this.lblInserir.Size = new System.Drawing.Size(140, 15);
            this.lblInserir.TabIndex = 5;
            this.lblInserir.Text = "Insira um número";
            // 
            // btnLimpar
            // 
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.ForeColor = System.Drawing.Color.Black;
            this.btnLimpar.Location = new System.Drawing.Point(310, 214);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(79, 24);
            this.btnLimpar.TabIndex = 6;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.BtnLimpar_Click_1);
            // 
            // TryParse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(401, 239);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.lblInserir);
            this.Controls.Add(this.txtInsere);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtParse);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.btnFechar);
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TryParse";
            this.Text = "TryParse";
            this.TransparencyKey = System.Drawing.Color.Black;
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.TextBox txtParse;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtInsere;
        private System.Windows.Forms.Label lblInserir;
        private System.Windows.Forms.Button btnLimpar;
    }
}

