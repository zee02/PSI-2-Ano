namespace _4
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
            this.txtLado1 = new System.Windows.Forms.TextBox();
            this.txtLado2 = new System.Windows.Forms.TextBox();
            this.txtLado3 = new System.Windows.Forms.TextBox();
            this.btnVerifica = new System.Windows.Forms.Button();
            this.lblResultado = new System.Windows.Forms.Label();
            this.lblLado1 = new System.Windows.Forms.Label();
            this.lblLado3 = new System.Windows.Forms.Label();
            this.lblLado2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtLado1
            // 
            this.txtLado1.Location = new System.Drawing.Point(120, 33);
            this.txtLado1.Name = "txtLado1";
            this.txtLado1.Size = new System.Drawing.Size(88, 20);
            this.txtLado1.TabIndex = 0;
            // 
            // txtLado2
            // 
            this.txtLado2.Location = new System.Drawing.Point(120, 76);
            this.txtLado2.Name = "txtLado2";
            this.txtLado2.Size = new System.Drawing.Size(88, 20);
            this.txtLado2.TabIndex = 1;
            // 
            // txtLado3
            // 
            this.txtLado3.Location = new System.Drawing.Point(120, 120);
            this.txtLado3.Name = "txtLado3";
            this.txtLado3.Size = new System.Drawing.Size(88, 20);
            this.txtLado3.TabIndex = 2;
            // 
            // btnVerifica
            // 
            this.btnVerifica.Location = new System.Drawing.Point(290, 173);
            this.btnVerifica.Name = "btnVerifica";
            this.btnVerifica.Size = new System.Drawing.Size(107, 23);
            this.btnVerifica.TabIndex = 3;
            this.btnVerifica.Text = "Verificar";
            this.btnVerifica.UseVisualStyleBackColor = true;
            this.btnVerifica.Click += new System.EventHandler(this.BtnVerifica_Click);
            // 
            // lblResultado
            // 
            this.lblResultado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblResultado.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblResultado.Location = new System.Drawing.Point(47, 219);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(217, 31);
            this.lblResultado.TabIndex = 4;
            // 
            // lblLado1
            // 
            this.lblLado1.AutoSize = true;
            this.lblLado1.Location = new System.Drawing.Point(44, 36);
            this.lblLado1.Name = "lblLado1";
            this.lblLado1.Size = new System.Drawing.Size(40, 13);
            this.lblLado1.TabIndex = 5;
            this.lblLado1.Text = "Lado 1";
            // 
            // lblLado3
            // 
            this.lblLado3.AutoSize = true;
            this.lblLado3.Location = new System.Drawing.Point(44, 123);
            this.lblLado3.Name = "lblLado3";
            this.lblLado3.Size = new System.Drawing.Size(40, 13);
            this.lblLado3.TabIndex = 6;
            this.lblLado3.Text = "Lado 3";
            // 
            // lblLado2
            // 
            this.lblLado2.AutoSize = true;
            this.lblLado2.Location = new System.Drawing.Point(44, 79);
            this.lblLado2.Name = "lblLado2";
            this.lblLado2.Size = new System.Drawing.Size(40, 13);
            this.lblLado2.TabIndex = 7;
            this.lblLado2.Text = "Lado 2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 277);
            this.Controls.Add(this.lblLado2);
            this.Controls.Add(this.lblLado3);
            this.Controls.Add(this.lblLado1);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.btnVerifica);
            this.Controls.Add(this.txtLado3);
            this.Controls.Add(this.txtLado2);
            this.Controls.Add(this.txtLado1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtLado1;
        private System.Windows.Forms.TextBox txtLado2;
        private System.Windows.Forms.TextBox txtLado3;
        private System.Windows.Forms.Button btnVerifica;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Label lblLado1;
        private System.Windows.Forms.Label lblLado3;
        private System.Windows.Forms.Label lblLado2;
    }
}

