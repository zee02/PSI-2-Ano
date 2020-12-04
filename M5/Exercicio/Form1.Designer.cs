namespace Exercicio
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
            this.dgvMostra = new System.Windows.Forms.DataGridView();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnVisualiza = new System.Windows.Forms.Button();
            this.btnElimina = new System.Windows.Forms.Button();
            this.btnAltera = new System.Windows.Forms.Button();
            this.dgvMostraa = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMostra)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMostraa)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvMostra
            // 
            this.dgvMostra.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMostra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMostra.Location = new System.Drawing.Point(-85, -107);
            this.dgvMostra.Name = "dgvMostra";
            this.dgvMostra.Size = new System.Drawing.Size(605, 92);
            this.dgvMostra.TabIndex = 18;
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnGuardar.Enabled = false;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGuardar.Location = new System.Drawing.Point(671, 488);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 19;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // btnVisualiza
            // 
            this.btnVisualiza.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnVisualiza.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnVisualiza.Location = new System.Drawing.Point(671, 427);
            this.btnVisualiza.Name = "btnVisualiza";
            this.btnVisualiza.Size = new System.Drawing.Size(75, 23);
            this.btnVisualiza.TabIndex = 20;
            this.btnVisualiza.Text = "Visualizar";
            this.btnVisualiza.UseVisualStyleBackColor = true;
            this.btnVisualiza.Click += new System.EventHandler(this.BtnVisualiza_Click);
            // 
            // btnElimina
            // 
            this.btnElimina.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnElimina.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnElimina.Enabled = false;
            this.btnElimina.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnElimina.Location = new System.Drawing.Point(546, 427);
            this.btnElimina.Name = "btnElimina";
            this.btnElimina.Size = new System.Drawing.Size(75, 20);
            this.btnElimina.TabIndex = 21;
            this.btnElimina.Text = "Eliminar";
            this.btnElimina.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnElimina.UseVisualStyleBackColor = true;
            this.btnElimina.Click += new System.EventHandler(this.BtnElimina_Click);
            // 
            // btnAltera
            // 
            this.btnAltera.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAltera.Enabled = false;
            this.btnAltera.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAltera.Location = new System.Drawing.Point(546, 488);
            this.btnAltera.Name = "btnAltera";
            this.btnAltera.Size = new System.Drawing.Size(75, 23);
            this.btnAltera.TabIndex = 22;
            this.btnAltera.Text = "Alterar";
            this.btnAltera.UseVisualStyleBackColor = true;
            this.btnAltera.Click += new System.EventHandler(this.BtnAltera_Click);
            // 
            // dgvMostraa
            // 
            this.dgvMostraa.AllowUserToAddRows = false;
            this.dgvMostraa.AllowUserToDeleteRows = false;
            this.dgvMostraa.AllowUserToResizeColumns = false;
            this.dgvMostraa.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvMostraa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMostraa.Location = new System.Drawing.Point(12, 26);
            this.dgvMostraa.Name = "dgvMostraa";
            this.dgvMostraa.Size = new System.Drawing.Size(878, 121);
            this.dgvMostraa.TabIndex = 23;
            this.dgvMostraa.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMostraa_CellClick);
            this.dgvMostraa.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMostraa_CellContentClick_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(902, 570);
            this.Controls.Add(this.dgvMostraa);
            this.Controls.Add(this.btnAltera);
            this.Controls.Add(this.btnElimina);
            this.Controls.Add(this.btnVisualiza);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.dgvMostra);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Caracteristica de carros";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMostra)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMostraa)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.DataGridView dgvMostra;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnVisualiza;
        private System.Windows.Forms.Button btnElimina;
        private System.Windows.Forms.Button btnAltera;
        private System.Windows.Forms.DataGridView dgvMostraa;
    }
}

