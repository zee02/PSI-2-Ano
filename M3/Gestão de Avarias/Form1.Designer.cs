namespace Gestão_de_Avarias
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblAvaria = new System.Windows.Forms.Label();
            this.lblModelo = new System.Windows.Forms.Label();
            this.lblData = new System.Windows.Forms.Label();
            this.dtpData = new System.Windows.Forms.DateTimePicker();
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.lstbAvaria = new System.Windows.Forms.ListBox();
            this.btnInserir = new System.Windows.Forms.Button();
            this.btnReparado = new System.Windows.Forms.Button();
            this.dgvDados = new System.Windows.Forms.DataGridView();
            this.Data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Modelo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Avaria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDados)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAvaria
            // 
            this.lblAvaria.AutoSize = true;
            this.lblAvaria.Location = new System.Drawing.Point(34, 125);
            this.lblAvaria.Name = "lblAvaria";
            this.lblAvaria.Size = new System.Drawing.Size(37, 13);
            this.lblAvaria.TabIndex = 0;
            this.lblAvaria.Text = "Avaria";
            // 
            // lblModelo
            // 
            this.lblModelo.AutoSize = true;
            this.lblModelo.Location = new System.Drawing.Point(34, 81);
            this.lblModelo.Name = "lblModelo";
            this.lblModelo.Size = new System.Drawing.Size(42, 13);
            this.lblModelo.TabIndex = 1;
            this.lblModelo.Text = "Modelo";
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Location = new System.Drawing.Point(34, 43);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(30, 13);
            this.lblData.TabIndex = 2;
            this.lblData.Text = "Data";
            // 
            // dtpData
            // 
            this.dtpData.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpData.Location = new System.Drawing.Point(90, 37);
            this.dtpData.Name = "dtpData";
            this.dtpData.Size = new System.Drawing.Size(93, 20);
            this.dtpData.TabIndex = 3;
            // 
            // txtModelo
            // 
            this.txtModelo.Location = new System.Drawing.Point(90, 78);
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(331, 20);
            this.txtModelo.TabIndex = 4;
            // 
            // lstbAvaria
            // 
            this.lstbAvaria.FormattingEnabled = true;
            this.lstbAvaria.Items.AddRange(new object[] {
            "Placa Gráfica Danificada",
            "Processador Estragado",
            "Não liga",
            "Não dá imagem"});
            this.lstbAvaria.Location = new System.Drawing.Point(90, 122);
            this.lstbAvaria.Name = "lstbAvaria";
            this.lstbAvaria.Size = new System.Drawing.Size(331, 82);
            this.lstbAvaria.TabIndex = 5;
            this.lstbAvaria.SelectedIndexChanged += new System.EventHandler(this.LstbAvaria_SelectedIndexChanged);
            // 
            // btnInserir
            // 
            this.btnInserir.Location = new System.Drawing.Point(250, 228);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(75, 23);
            this.btnInserir.TabIndex = 6;
            this.btnInserir.Text = "Inserir";
            this.btnInserir.UseVisualStyleBackColor = true;
            this.btnInserir.Click += new System.EventHandler(this.BtnInserir_Click);
            // 
            // btnReparado
            // 
            this.btnReparado.Location = new System.Drawing.Point(346, 228);
            this.btnReparado.Name = "btnReparado";
            this.btnReparado.Size = new System.Drawing.Size(75, 23);
            this.btnReparado.TabIndex = 7;
            this.btnReparado.Text = "Reparado";
            this.btnReparado.UseVisualStyleBackColor = true;
            this.btnReparado.Click += new System.EventHandler(this.BtnReparado_Click);
            // 
            // dgvDados
            // 
            this.dgvDados.AllowUserToAddRows = false;
            this.dgvDados.AllowUserToDeleteRows = false;
            this.dgvDados.AllowUserToResizeColumns = false;
            this.dgvDados.AllowUserToResizeRows = false;
            this.dgvDados.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Data,
            this.Modelo,
            this.Avaria});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDados.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDados.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvDados.Location = new System.Drawing.Point(0, 271);
            this.dgvDados.Name = "dgvDados";
            this.dgvDados.RowHeadersVisible = false;
            this.dgvDados.Size = new System.Drawing.Size(479, 150);
            this.dgvDados.TabIndex = 8;
            this.dgvDados.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvDados_CellContentClick);
            // 
            // Data
            // 
            this.Data.HeaderText = "Data";
            this.Data.Name = "Data";
            this.Data.Width = 160;
            // 
            // Modelo
            // 
            this.Modelo.HeaderText = "Modelo";
            this.Modelo.Name = "Modelo";
            this.Modelo.Width = 160;
            // 
            // Avaria
            // 
            this.Avaria.HeaderText = "Avaria";
            this.Avaria.Name = "Avaria";
            this.Avaria.Width = 160;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 421);
            this.Controls.Add(this.dgvDados);
            this.Controls.Add(this.btnReparado);
            this.Controls.Add(this.btnInserir);
            this.Controls.Add(this.lstbAvaria);
            this.Controls.Add(this.txtModelo);
            this.Controls.Add(this.dtpData);
            this.Controls.Add(this.lblData);
            this.Controls.Add(this.lblModelo);
            this.Controls.Add(this.lblAvaria);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAvaria;
        private System.Windows.Forms.Label lblModelo;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.DateTimePicker dtpData;
        private System.Windows.Forms.TextBox txtModelo;
        private System.Windows.Forms.ListBox lstbAvaria;
        private System.Windows.Forms.Button btnInserir;
        private System.Windows.Forms.Button btnReparado;
        private System.Windows.Forms.DataGridView dgvDados;
        private System.Windows.Forms.DataGridViewTextBoxColumn Data;
        private System.Windows.Forms.DataGridViewTextBoxColumn Modelo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Avaria;
    }
}

