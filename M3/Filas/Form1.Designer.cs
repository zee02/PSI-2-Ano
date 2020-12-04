namespace Filas
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
            this.txtNomes = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.lstNomes = new System.Windows.Forms.ListBox();
            this.btnInserir = new System.Windows.Forms.Button();
            this.btnAtendido = new System.Windows.Forms.Button();
            this.btnActualiza = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtNomes
            // 
            this.txtNomes.Location = new System.Drawing.Point(100, 42);
            this.txtNomes.Name = "txtNomes";
            this.txtNomes.Size = new System.Drawing.Size(237, 20);
            this.txtNomes.TabIndex = 0;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(25, 45);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(38, 13);
            this.lblNome.TabIndex = 1;
            this.lblNome.Text = "Nome:";
            // 
            // lstNomes
            // 
            this.lstNomes.FormattingEnabled = true;
            this.lstNomes.Location = new System.Drawing.Point(41, 158);
            this.lstNomes.Name = "lstNomes";
            this.lstNomes.Size = new System.Drawing.Size(296, 225);
            this.lstNomes.TabIndex = 2;
            // 
            // btnInserir
            // 
            this.btnInserir.Location = new System.Drawing.Point(41, 103);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(75, 23);
            this.btnInserir.TabIndex = 3;
            this.btnInserir.Text = "Inserir";
            this.btnInserir.UseVisualStyleBackColor = true;
            this.btnInserir.Click += new System.EventHandler(this.BtnInserir_Click);
            // 
            // btnAtendido
            // 
            this.btnAtendido.Location = new System.Drawing.Point(150, 103);
            this.btnAtendido.Name = "btnAtendido";
            this.btnAtendido.Size = new System.Drawing.Size(81, 23);
            this.btnAtendido.TabIndex = 4;
            this.btnAtendido.Text = "Atendido";
            this.btnAtendido.UseVisualStyleBackColor = true;
            this.btnAtendido.Click += new System.EventHandler(this.BtnAtendido_Click);
            // 
            // btnActualiza
            // 
            this.btnActualiza.Location = new System.Drawing.Point(262, 103);
            this.btnActualiza.Name = "btnActualiza";
            this.btnActualiza.Size = new System.Drawing.Size(75, 23);
            this.btnActualiza.TabIndex = 5;
            this.btnActualiza.Text = "Actualizar";
            this.btnActualiza.UseVisualStyleBackColor = true;
            this.btnActualiza.Click += new System.EventHandler(this.BtnActualiza_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.btnInserir;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 405);
            this.Controls.Add(this.btnActualiza);
            this.Controls.Add(this.btnAtendido);
            this.Controls.Add(this.btnInserir);
            this.Controls.Add(this.lstNomes);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.txtNomes);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Atendimento";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNomes;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.ListBox lstNomes;
        private System.Windows.Forms.Button btnInserir;
        private System.Windows.Forms.Button btnAtendido;
        private System.Windows.Forms.Button btnActualiza;
    }
}

