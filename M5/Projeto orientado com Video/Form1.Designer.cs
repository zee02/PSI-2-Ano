namespace Projeto_orientado_com_Video
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnInsere = new System.Windows.Forms.Button();
            this.btnEdita = new System.Windows.Forms.Button();
            this.btnApaga = new System.Windows.Forms.Button();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtPrim = new System.Windows.Forms.TextBox();
            this.txtUlt = new System.Windows.Forms.TextBox();
            this.txtIdade = new System.Windows.Forms.TextBox();
            this.dataGridView_USERS = new System.Windows.Forms.DataGridView();
            this.btnProcura = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_USERS)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(5, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(5, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Primeiro Nome:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(5, 217);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Idade:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(5, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Último Nome:";
            // 
            // btnInsere
            // 
            this.btnInsere.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnInsere.Location = new System.Drawing.Point(33, 318);
            this.btnInsere.Name = "btnInsere";
            this.btnInsere.Size = new System.Drawing.Size(84, 33);
            this.btnInsere.TabIndex = 4;
            this.btnInsere.Text = "Inserir";
            this.btnInsere.UseVisualStyleBackColor = true;
            this.btnInsere.Click += new System.EventHandler(this.Button1_Click);
            // 
            // btnEdita
            // 
            this.btnEdita.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEdita.Location = new System.Drawing.Point(132, 318);
            this.btnEdita.Name = "btnEdita";
            this.btnEdita.Size = new System.Drawing.Size(84, 33);
            this.btnEdita.TabIndex = 5;
            this.btnEdita.Text = "Editar";
            this.btnEdita.UseVisualStyleBackColor = true;
            this.btnEdita.Click += new System.EventHandler(this.Button2_Click);
            // 
            // btnApaga
            // 
            this.btnApaga.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnApaga.Location = new System.Drawing.Point(235, 318);
            this.btnApaga.Name = "btnApaga";
            this.btnApaga.Size = new System.Drawing.Size(81, 33);
            this.btnApaga.TabIndex = 6;
            this.btnApaga.Text = "Apagar";
            this.btnApaga.UseVisualStyleBackColor = true;
            this.btnApaga.Click += new System.EventHandler(this.Button3_Click);
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(138, 46);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(156, 20);
            this.txtID.TabIndex = 7;
            // 
            // txtPrim
            // 
            this.txtPrim.Location = new System.Drawing.Point(138, 99);
            this.txtPrim.Name = "txtPrim";
            this.txtPrim.Size = new System.Drawing.Size(156, 20);
            this.txtPrim.TabIndex = 8;
            // 
            // txtUlt
            // 
            this.txtUlt.Location = new System.Drawing.Point(138, 155);
            this.txtUlt.Name = "txtUlt";
            this.txtUlt.Size = new System.Drawing.Size(156, 20);
            this.txtUlt.TabIndex = 9;
            // 
            // txtIdade
            // 
            this.txtIdade.Location = new System.Drawing.Point(138, 215);
            this.txtIdade.Name = "txtIdade";
            this.txtIdade.Size = new System.Drawing.Size(156, 20);
            this.txtIdade.TabIndex = 10;
            // 
            // dataGridView_USERS
            // 
            this.dataGridView_USERS.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_USERS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_USERS.Location = new System.Drawing.Point(365, 22);
            this.dataGridView_USERS.Name = "dataGridView_USERS";
            this.dataGridView_USERS.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_USERS.Size = new System.Drawing.Size(423, 416);
            this.dataGridView_USERS.TabIndex = 11;
            this.dataGridView_USERS.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView_USERS_CellContentClick);
            this.dataGridView_USERS.MouseClick += new System.Windows.Forms.MouseEventHandler(this.DataGridView_USERS_MouseClick);
            // 
            // btnProcura
            // 
            this.btnProcura.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnProcura.Location = new System.Drawing.Point(300, 46);
            this.btnProcura.Name = "btnProcura";
            this.btnProcura.Size = new System.Drawing.Size(59, 20);
            this.btnProcura.TabIndex = 12;
            this.btnProcura.Text = "Procurar";
            this.btnProcura.UseVisualStyleBackColor = true;
            this.btnProcura.Click += new System.EventHandler(this.BtnProcura_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnProcura);
            this.Controls.Add(this.dataGridView_USERS);
            this.Controls.Add(this.txtIdade);
            this.Controls.Add(this.txtUlt);
            this.Controls.Add(this.txtPrim);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.btnApaga);
            this.Controls.Add(this.btnEdita);
            this.Controls.Add(this.btnInsere);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Revisão";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_USERS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnInsere;
        private System.Windows.Forms.Button btnEdita;
        private System.Windows.Forms.Button btnApaga;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtPrim;
        private System.Windows.Forms.TextBox txtUlt;
        private System.Windows.Forms.TextBox txtIdade;
        private System.Windows.Forms.DataGridView dataGridView_USERS;
        private System.Windows.Forms.Button btnProcura;
    }
}

