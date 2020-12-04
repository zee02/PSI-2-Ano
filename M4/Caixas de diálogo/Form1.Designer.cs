namespace Caixas_de_diálogo
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
            this.rtbTexto = new System.Windows.Forms.RichTextBox();
            this.btnTipoLetra = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnAbrir = new System.Windows.Forms.Button();
            this.btnEsquerda = new System.Windows.Forms.Button();
            this.btnCentro = new System.Windows.Forms.Button();
            this.btnDireita = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rtbTexto
            // 
            this.rtbTexto.Location = new System.Drawing.Point(23, 12);
            this.rtbTexto.Name = "rtbTexto";
            this.rtbTexto.Size = new System.Drawing.Size(480, 177);
            this.rtbTexto.TabIndex = 0;
            this.rtbTexto.Text = "";
            // 
            // btnTipoLetra
            // 
            this.btnTipoLetra.Location = new System.Drawing.Point(130, 240);
            this.btnTipoLetra.Name = "btnTipoLetra";
            this.btnTipoLetra.Size = new System.Drawing.Size(96, 37);
            this.btnTipoLetra.TabIndex = 4;
            this.btnTipoLetra.Text = "Tipo de Letra";
            this.btnTipoLetra.UseVisualStyleBackColor = true;
            this.btnTipoLetra.Click += new System.EventHandler(this.BtnTipoLetra_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(154, 209);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Formatar";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(362, 209);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Alinhamento";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackgroundImage = global::Caixas_de_diálogo.Properties.Resources.save_icon_3;
            this.btnGuardar.Location = new System.Drawing.Point(33, 209);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(38, 35);
            this.btnGuardar.TabIndex = 6;
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // btnAbrir
            // 
            this.btnAbrir.BackgroundImage = global::Caixas_de_diálogo.Properties.Resources.Open_512;
            this.btnAbrir.Location = new System.Drawing.Point(33, 250);
            this.btnAbrir.Name = "btnAbrir";
            this.btnAbrir.Size = new System.Drawing.Size(38, 37);
            this.btnAbrir.TabIndex = 5;
            this.btnAbrir.UseVisualStyleBackColor = true;
            this.btnAbrir.Click += new System.EventHandler(this.BtnAbrir_Click);
            // 
            // btnEsquerda
            // 
            this.btnEsquerda.BackColor = System.Drawing.Color.White;
            this.btnEsquerda.BackgroundImage = global::Caixas_de_diálogo.Properties.Resources.General___Office_27_512;
            this.btnEsquerda.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEsquerda.Location = new System.Drawing.Point(289, 233);
            this.btnEsquerda.Name = "btnEsquerda";
            this.btnEsquerda.Size = new System.Drawing.Size(40, 37);
            this.btnEsquerda.TabIndex = 3;
            this.btnEsquerda.UseVisualStyleBackColor = false;
            // 
            // btnCentro
            // 
            this.btnCentro.BackColor = System.Drawing.Color.White;
            this.btnCentro.BackgroundImage = global::Caixas_de_diálogo.Properties.Resources.transferir;
            this.btnCentro.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCentro.Location = new System.Drawing.Point(376, 233);
            this.btnCentro.Name = "btnCentro";
            this.btnCentro.Size = new System.Drawing.Size(36, 37);
            this.btnCentro.TabIndex = 2;
            this.btnCentro.UseVisualStyleBackColor = false;
            // 
            // btnDireita
            // 
            this.btnDireita.BackColor = System.Drawing.Color.White;
            this.btnDireita.BackgroundImage = global::Caixas_de_diálogo.Properties.Resources.transferir__1_;
            this.btnDireita.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDireita.Location = new System.Drawing.Point(458, 233);
            this.btnDireita.Name = "btnDireita";
            this.btnDireita.Size = new System.Drawing.Size(34, 37);
            this.btnDireita.TabIndex = 1;
            this.btnDireita.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(541, 289);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnAbrir);
            this.Controls.Add(this.btnTipoLetra);
            this.Controls.Add(this.btnEsquerda);
            this.Controls.Add(this.btnCentro);
            this.Controls.Add(this.btnDireita);
            this.Controls.Add(this.rtbTexto);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Processador de Texto";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbTexto;
        private System.Windows.Forms.Button btnDireita;
        private System.Windows.Forms.Button btnCentro;
        private System.Windows.Forms.Button btnEsquerda;
        private System.Windows.Forms.Button btnTipoLetra;
        private System.Windows.Forms.Button btnAbrir;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

