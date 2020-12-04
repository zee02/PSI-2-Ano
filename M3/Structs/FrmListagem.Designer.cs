namespace Structs
{
    partial class FrmListagem
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        public System.ComponentModel.IContainer components = null;

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
        public void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvGrelha = new System.Windows.Forms.DataGridView();
            this.gDorsal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Clube = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prova = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrelha)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvGrelha
            // 
            this.dgvGrelha.AllowUserToAddRows = false;
            this.dgvGrelha.AllowUserToDeleteRows = false;
            this.dgvGrelha.AllowUserToResizeColumns = false;
            this.dgvGrelha.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.dgvGrelha.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvGrelha.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvGrelha.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvGrelha.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGrelha.ColumnHeadersVisible = false;
            this.dgvGrelha.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.gDorsal,
            this.Nome,
            this.Clube,
            this.Prova});
            this.dgvGrelha.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvGrelha.GridColor = System.Drawing.Color.Black;
            this.dgvGrelha.Location = new System.Drawing.Point(0, 0);
            this.dgvGrelha.Name = "dgvGrelha";
            this.dgvGrelha.RowHeadersVisible = false;
            this.dgvGrelha.Size = new System.Drawing.Size(800, 450);
            this.dgvGrelha.TabIndex = 0;
            this.dgvGrelha.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvGrelha_CellContentClick);
            // 
            // gDorsal
            // 
            this.gDorsal.HeaderText = "gDorsal";
            this.gDorsal.Name = "gDorsal";
            this.gDorsal.Width = 50;
            // 
            // Nome
            // 
            this.Nome.HeaderText = "gNome";
            this.Nome.Name = "Nome";
            this.Nome.Width = 200;
            // 
            // Clube
            // 
            this.Clube.HeaderText = "gClube";
            this.Clube.Name = "Clube";
            this.Clube.Width = 200;
            // 
            // Prova
            // 
            this.Prova.HeaderText = "gProva";
            this.Prova.Name = "Prova";
            this.Prova.Width = 150;
            // 
            // FrmListagem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvGrelha);
            this.Name = "FrmListagem";
            this.Text = "FrmListagem";
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrelha)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView dgvGrelha;
        private System.Windows.Forms.DataGridViewTextBoxColumn gDorsal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Clube;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prova;
    }
}