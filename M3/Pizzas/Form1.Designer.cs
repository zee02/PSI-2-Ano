namespace Pizzas
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
            this.cboTamanho = new System.Windows.Forms.ComboBox();
            this.cboMassa = new System.Windows.Forms.ComboBox();
            this.cboIngredientes = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.dgvIngredientes = new System.Windows.Forms.DataGridView();
            this.hgff = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnRepor = new System.Windows.Forms.Button();
            this.btnFinalizar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIngredientes)).BeginInit();
            this.SuspendLayout();
            // 
            // cboTamanho
            // 
            this.cboTamanho.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTamanho.FormattingEnabled = true;
            this.cboTamanho.Items.AddRange(new object[] {
            "Individual",
            "Media",
            "Familiar"});
            this.cboTamanho.Location = new System.Drawing.Point(101, 29);
            this.cboTamanho.Name = "cboTamanho";
            this.cboTamanho.Size = new System.Drawing.Size(121, 21);
            this.cboTamanho.TabIndex = 0;
            // 
            // cboMassa
            // 
            this.cboMassa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMassa.FormattingEnabled = true;
            this.cboMassa.Items.AddRange(new object[] {
            "Fina",
            "Pan",
            "Rolling"});
            this.cboMassa.Location = new System.Drawing.Point(101, 76);
            this.cboMassa.Name = "cboMassa";
            this.cboMassa.Size = new System.Drawing.Size(121, 21);
            this.cboMassa.TabIndex = 1;
            // 
            // cboIngredientes
            // 
            this.cboIngredientes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboIngredientes.FormattingEnabled = true;
            this.cboIngredientes.Location = new System.Drawing.Point(101, 121);
            this.cboIngredientes.Name = "cboIngredientes";
            this.cboIngredientes.Size = new System.Drawing.Size(121, 21);
            this.cboIngredientes.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Igredientes";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Massa";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Tamanho";
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Image = ((System.Drawing.Image)(resources.GetObject("btnAdicionar.Image")));
            this.btnAdicionar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdicionar.Location = new System.Drawing.Point(295, 121);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(75, 23);
            this.btnAdicionar.TabIndex = 6;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.BtnAdicionar_Click);
            // 
            // dgvIngredientes
            // 
            this.dgvIngredientes.AllowUserToAddRows = false;
            this.dgvIngredientes.AllowUserToDeleteRows = false;
            this.dgvIngredientes.AllowUserToResizeColumns = false;
            this.dgvIngredientes.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvIngredientes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvIngredientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIngredientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.hgff});
            this.dgvIngredientes.Location = new System.Drawing.Point(22, 162);
            this.dgvIngredientes.Name = "dgvIngredientes";
            this.dgvIngredientes.RowHeadersVisible = false;
            this.dgvIngredientes.Size = new System.Drawing.Size(368, 152);
            this.dgvIngredientes.TabIndex = 7;
            this.dgvIngredientes.Tag = "";
            // 
            // hgff
            // 
            this.hgff.HeaderText = "Ingredientes";
            this.hgff.Name = "hgff";
            this.hgff.Width = 360;
            // 
            // btnRepor
            // 
            this.btnRepor.Image = ((System.Drawing.Image)(resources.GetObject("btnRepor.Image")));
            this.btnRepor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRepor.Location = new System.Drawing.Point(129, 342);
            this.btnRepor.Name = "btnRepor";
            this.btnRepor.Size = new System.Drawing.Size(82, 23);
            this.btnRepor.TabIndex = 8;
            this.btnRepor.Text = "Repor";
            this.btnRepor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRepor.UseVisualStyleBackColor = true;
            this.btnRepor.Click += new System.EventHandler(this.BtnRepor_Click_1);
            // 
            // btnFinalizar
            // 
            this.btnFinalizar.Image = ((System.Drawing.Image)(resources.GetObject("btnFinalizar.Image")));
            this.btnFinalizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFinalizar.Location = new System.Drawing.Point(22, 342);
            this.btnFinalizar.Name = "btnFinalizar";
            this.btnFinalizar.Size = new System.Drawing.Size(75, 23);
            this.btnFinalizar.TabIndex = 9;
            this.btnFinalizar.Text = "Finalizar";
            this.btnFinalizar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFinalizar.UseVisualStyleBackColor = true;
            this.btnFinalizar.Click += new System.EventHandler(this.BtnFinalizar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(249, 347);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Total";
            // 
            // lblTotal
            // 
            this.lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ForeColor = System.Drawing.Color.Red;
            this.lblTotal.Location = new System.Drawing.Point(295, 342);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(104, 31);
            this.lblTotal.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 377);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnFinalizar);
            this.Controls.Add(this.btnRepor);
            this.Controls.Add(this.dgvIngredientes);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboIngredientes);
            this.Controls.Add(this.cboMassa);
            this.Controls.Add(this.cboTamanho);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pizza";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvIngredientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboTamanho;
        private System.Windows.Forms.ComboBox cboMassa;
        private System.Windows.Forms.ComboBox cboIngredientes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.DataGridView dgvIngredientes;
        private System.Windows.Forms.Button btnRepor;
        private System.Windows.Forms.Button btnFinalizar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn hgff;
    }
}

