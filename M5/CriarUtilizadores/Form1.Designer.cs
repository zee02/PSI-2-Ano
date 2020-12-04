namespace CriarUtilizadores
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtUti = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.btnCria = new System.Windows.Forms.Button();
            this.btnFecha = new System.Windows.Forms.Button();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(95, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Utilizador";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(95, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password";
            // 
            // txtUti
            // 
            this.txtUti.Location = new System.Drawing.Point(168, 65);
            this.txtUti.Name = "txtUti";
            this.txtUti.Size = new System.Drawing.Size(174, 20);
            this.txtUti.TabIndex = 2;
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(168, 112);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(174, 20);
            this.txtPass.TabIndex = 3;
            // 
            // btnCria
            // 
            this.btnCria.Location = new System.Drawing.Point(127, 214);
            this.btnCria.Name = "btnCria";
            this.btnCria.Size = new System.Drawing.Size(100, 23);
            this.btnCria.TabIndex = 4;
            this.btnCria.Text = "Cria Utilizador";
            this.btnCria.UseVisualStyleBackColor = true;
            this.btnCria.Click += new System.EventHandler(this.BtnCria_Click);
            // 
            // btnFecha
            // 
            this.btnFecha.Location = new System.Drawing.Point(283, 214);
            this.btnFecha.Name = "btnFecha";
            this.btnFecha.Size = new System.Drawing.Size(100, 23);
            this.btnFecha.TabIndex = 5;
            this.btnFecha.Text = "Fechar";
            this.btnFecha.UseVisualStyleBackColor = true;
            this.btnFecha.Click += new System.EventHandler(this.BtnFecha_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(168, 155);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(174, 20);
            this.txtEmail.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(95, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Email";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 272);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.btnFecha);
            this.Controls.Add(this.btnCria);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.txtUti);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUti;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Button btnCria;
        private System.Windows.Forms.Button btnFecha;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label3;
    }
}

