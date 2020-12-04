namespace Agenda
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
            this.tsMenu = new System.Windows.Forms.ToolStrip();
            this.tsbNovo = new System.Windows.Forms.ToolStripButton();
            this.tsbCancelar = new System.Windows.Forms.ToolStripButton();
            this.tsbGuardar = new System.Windows.Forms.ToolStripButton();
            this.tsbListar = new System.Windows.Forms.ToolStripButton();
            this.grbContactos = new System.Windows.Forms.GroupBox();
            this.radEmpresas = new System.Windows.Forms.RadioButton();
            this.radParticulares = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMorada = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtLocalide = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblCAE = new System.Windows.Forms.Label();
            this.mtxtCP = new System.Windows.Forms.MaskedTextBox();
            this.mtxtTelefone = new System.Windows.Forms.MaskedTextBox();
            this.mtxtContribuinte = new System.Windows.Forms.MaskedTextBox();
            this.mtxtCAE = new System.Windows.Forms.MaskedTextBox();
            this.tsMenu.SuspendLayout();
            this.grbContactos.SuspendLayout();
            this.SuspendLayout();
            // 
            // tsMenu
            // 
            this.tsMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbNovo,
            this.tsbCancelar,
            this.tsbGuardar,
            this.tsbListar});
            this.tsMenu.Location = new System.Drawing.Point(0, 0);
            this.tsMenu.Name = "tsMenu";
            this.tsMenu.Size = new System.Drawing.Size(465, 54);
            this.tsMenu.TabIndex = 0;
            this.tsMenu.Text = "toolStrip1";
            this.tsMenu.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.TsMenu_ItemClicked);
            // 
            // tsbNovo
            // 
            this.tsbNovo.Image = global::Agenda.Properties.Resources.user_friend;
            this.tsbNovo.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbNovo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbNovo.Name = "tsbNovo";
            this.tsbNovo.Size = new System.Drawing.Size(40, 51);
            this.tsbNovo.Text = "Novo";
            this.tsbNovo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbNovo.Click += new System.EventHandler(this.TsbNovo_Click);
            // 
            // tsbCancelar
            // 
            this.tsbCancelar.Image = global::Agenda.Properties.Resources.Counterclockwise_arrow32;
            this.tsbCancelar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbCancelar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbCancelar.Name = "tsbCancelar";
            this.tsbCancelar.Size = new System.Drawing.Size(57, 51);
            this.tsbCancelar.Text = "Cancelar";
            this.tsbCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbCancelar.Click += new System.EventHandler(this.TsbCancelar_Click);
            // 
            // tsbGuardar
            // 
            this.tsbGuardar.Image = global::Agenda.Properties.Resources.save_as;
            this.tsbGuardar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbGuardar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbGuardar.Name = "tsbGuardar";
            this.tsbGuardar.Size = new System.Drawing.Size(53, 51);
            this.tsbGuardar.Text = "Guardar";
            this.tsbGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbGuardar.Click += new System.EventHandler(this.TsbGuardar_Click);
            // 
            // tsbListar
            // 
            this.tsbListar.Image = global::Agenda.Properties.Resources.distributor_report32;
            this.tsbListar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbListar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbListar.Name = "tsbListar";
            this.tsbListar.Size = new System.Drawing.Size(39, 51);
            this.tsbListar.Text = "Listar";
            this.tsbListar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbListar.Click += new System.EventHandler(this.TsbListar_Click);
            // 
            // grbContactos
            // 
            this.grbContactos.Controls.Add(this.radEmpresas);
            this.grbContactos.Controls.Add(this.radParticulares);
            this.grbContactos.Location = new System.Drawing.Point(12, 75);
            this.grbContactos.Name = "grbContactos";
            this.grbContactos.Size = new System.Drawing.Size(417, 52);
            this.grbContactos.TabIndex = 1;
            this.grbContactos.TabStop = false;
            this.grbContactos.Text = " Contactos";
            // 
            // radEmpresas
            // 
            this.radEmpresas.AutoSize = true;
            this.radEmpresas.Location = new System.Drawing.Point(158, 30);
            this.radEmpresas.Name = "radEmpresas";
            this.radEmpresas.Size = new System.Drawing.Size(71, 17);
            this.radEmpresas.TabIndex = 1;
            this.radEmpresas.TabStop = true;
            this.radEmpresas.Text = "Empresas";
            this.radEmpresas.UseVisualStyleBackColor = true;
            // 
            // radParticulares
            // 
            this.radParticulares.AutoSize = true;
            this.radParticulares.Checked = true;
            this.radParticulares.Location = new System.Drawing.Point(31, 30);
            this.radParticulares.Name = "radParticulares";
            this.radParticulares.Size = new System.Drawing.Size(80, 17);
            this.radParticulares.TabIndex = 0;
            this.radParticulares.TabStop = true;
            this.radParticulares.Text = "Particulares";
            this.radParticulares.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 192);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Morada";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nome";
            // 
            // txtMorada
            // 
            this.txtMorada.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMorada.Location = new System.Drawing.Point(100, 189);
            this.txtMorada.Name = "txtMorada";
            this.txtMorada.Size = new System.Drawing.Size(329, 20);
            this.txtMorada.TabIndex = 4;
            // 
            // txtNome
            // 
            this.txtNome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNome.Location = new System.Drawing.Point(100, 154);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(329, 20);
            this.txtNome.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 263);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Telefone";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 228);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Código Postal";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 306);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Contruibuinte";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(223, 266);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Email";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(213, 228);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Localidade";
            // 
            // txtLocalide
            // 
            this.txtLocalide.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLocalide.Location = new System.Drawing.Point(285, 225);
            this.txtLocalide.Name = "txtLocalide";
            this.txtLocalide.Size = new System.Drawing.Size(144, 20);
            this.txtLocalide.TabIndex = 14;
            // 
            // txtEmail
            // 
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmail.Location = new System.Drawing.Point(285, 263);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(144, 20);
            this.txtEmail.TabIndex = 15;
            // 
            // lblCAE
            // 
            this.lblCAE.AutoSize = true;
            this.lblCAE.Location = new System.Drawing.Point(223, 310);
            this.lblCAE.Name = "lblCAE";
            this.lblCAE.Size = new System.Drawing.Size(28, 13);
            this.lblCAE.TabIndex = 16;
            this.lblCAE.Text = "CAE";
            this.lblCAE.Visible = false;
            // 
            // mtxtCP
            // 
            this.mtxtCP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mtxtCP.Location = new System.Drawing.Point(100, 228);
            this.mtxtCP.Mask = "00000-999";
            this.mtxtCP.Name = "mtxtCP";
            this.mtxtCP.Size = new System.Drawing.Size(61, 20);
            this.mtxtCP.TabIndex = 18;
            // 
            // mtxtTelefone
            // 
            this.mtxtTelefone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mtxtTelefone.Location = new System.Drawing.Point(100, 263);
            this.mtxtTelefone.Mask = "000000000";
            this.mtxtTelefone.Name = "mtxtTelefone";
            this.mtxtTelefone.Size = new System.Drawing.Size(61, 20);
            this.mtxtTelefone.TabIndex = 19;
            // 
            // mtxtContribuinte
            // 
            this.mtxtContribuinte.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mtxtContribuinte.Location = new System.Drawing.Point(100, 307);
            this.mtxtContribuinte.Mask = "000000000";
            this.mtxtContribuinte.Name = "mtxtContribuinte";
            this.mtxtContribuinte.Size = new System.Drawing.Size(61, 20);
            this.mtxtContribuinte.TabIndex = 20;
            // 
            // mtxtCAE
            // 
            this.mtxtCAE.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mtxtCAE.Location = new System.Drawing.Point(285, 306);
            this.mtxtCAE.Mask = "00000";
            this.mtxtCAE.Name = "mtxtCAE";
            this.mtxtCAE.Size = new System.Drawing.Size(34, 20);
            this.mtxtCAE.TabIndex = 21;
            this.mtxtCAE.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 367);
            this.Controls.Add(this.mtxtCAE);
            this.Controls.Add(this.mtxtContribuinte);
            this.Controls.Add(this.mtxtTelefone);
            this.Controls.Add(this.mtxtCP);
            this.Controls.Add(this.lblCAE);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtLocalide);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.txtMorada);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grbContactos);
            this.Controls.Add(this.tsMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agenda";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tsMenu.ResumeLayout(false);
            this.tsMenu.PerformLayout();
            this.grbContactos.ResumeLayout(false);
            this.grbContactos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tsMenu;
        private System.Windows.Forms.ToolStripButton tsbNovo;
        private System.Windows.Forms.ToolStripButton tsbCancelar;
        private System.Windows.Forms.ToolStripButton tsbGuardar;
        private System.Windows.Forms.ToolStripButton tsbListar;
        private System.Windows.Forms.GroupBox grbContactos;
        private System.Windows.Forms.RadioButton radEmpresas;
        private System.Windows.Forms.RadioButton radParticulares;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMorada;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtLocalide;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblCAE;
        private System.Windows.Forms.MaskedTextBox mtxtCP;
        private System.Windows.Forms.MaskedTextBox mtxtTelefone;
        private System.Windows.Forms.MaskedTextBox mtxtContribuinte;
        private System.Windows.Forms.MaskedTextBox mtxtCAE;
    }
}

