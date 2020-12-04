namespace Exemplo_Classes
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
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnKO = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.lblResult2 = new System.Windows.Forms.Label();
            this.txtXA = new System.Windows.Forms.TextBox();
            this.txtXB = new System.Windows.Forms.TextBox();
            this.txtXC = new System.Windows.Forms.TextBox();
            this.txtYB = new System.Windows.Forms.TextBox();
            this.txtYA = new System.Windows.Forms.TextBox();
            this.txtYC = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 200);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Triangulo Y";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Lado A";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(53, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Lado B";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(53, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Lado C";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(53, 242);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Lado A";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(53, 350);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Lado C";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(53, 294);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Lado B";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(12, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 16);
            this.label8.TabIndex = 7;
            this.label8.Text = "Triangulo X";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(338, 103);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 16);
            this.label9.TabIndex = 8;
            this.label9.Text = "Area:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(338, 294);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(40, 16);
            this.label10.TabIndex = 9;
            this.label10.Text = "Area:";
            // 
            // btnKO
            // 
            this.btnKO.Location = new System.Drawing.Point(406, 331);
            this.btnKO.Name = "btnKO";
            this.btnKO.Size = new System.Drawing.Size(45, 32);
            this.btnKO.TabIndex = 10;
            this.btnKO.Text = "OK";
            this.btnKO.UseVisualStyleBackColor = true;
            this.btnKO.Click += new System.EventHandler(this.BtnKO_Click);
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(406, 139);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(45, 31);
            this.btnOk.TabIndex = 11;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.BtnOk_Click);
            // 
            // lblResult
            // 
            this.lblResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblResult.Location = new System.Drawing.Point(384, 103);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(77, 24);
            this.lblResult.TabIndex = 12;
            this.lblResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblResult2
            // 
            this.lblResult2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblResult2.Location = new System.Drawing.Point(384, 295);
            this.lblResult2.Name = "lblResult2";
            this.lblResult2.Size = new System.Drawing.Size(77, 24);
            this.lblResult2.TabIndex = 13;
            this.lblResult2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtXA
            // 
            this.txtXA.Location = new System.Drawing.Point(111, 37);
            this.txtXA.Name = "txtXA";
            this.txtXA.Size = new System.Drawing.Size(100, 20);
            this.txtXA.TabIndex = 14;
            // 
            // txtXB
            // 
            this.txtXB.Location = new System.Drawing.Point(111, 89);
            this.txtXB.Name = "txtXB";
            this.txtXB.Size = new System.Drawing.Size(100, 20);
            this.txtXB.TabIndex = 15;
            // 
            // txtXC
            // 
            this.txtXC.Location = new System.Drawing.Point(111, 145);
            this.txtXC.Name = "txtXC";
            this.txtXC.Size = new System.Drawing.Size(100, 20);
            this.txtXC.TabIndex = 16;
            // 
            // txtYB
            // 
            this.txtYB.Location = new System.Drawing.Point(111, 291);
            this.txtYB.Name = "txtYB";
            this.txtYB.Size = new System.Drawing.Size(100, 20);
            this.txtYB.TabIndex = 17;
            // 
            // txtYA
            // 
            this.txtYA.Location = new System.Drawing.Point(111, 239);
            this.txtYA.Name = "txtYA";
            this.txtYA.Size = new System.Drawing.Size(100, 20);
            this.txtYA.TabIndex = 18;
            // 
            // txtYC
            // 
            this.txtYC.Location = new System.Drawing.Point(111, 347);
            this.txtYC.Name = "txtYC";
            this.txtYC.Size = new System.Drawing.Size(100, 20);
            this.txtYC.TabIndex = 19;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 388);
            this.Controls.Add(this.txtYC);
            this.Controls.Add(this.txtYA);
            this.Controls.Add(this.txtYB);
            this.Controls.Add(this.txtXC);
            this.Controls.Add(this.txtXB);
            this.Controls.Add(this.txtXA);
            this.Controls.Add(this.lblResult2);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.btnKO);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnKO;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Label lblResult2;
        private System.Windows.Forms.TextBox txtXA;
        private System.Windows.Forms.TextBox txtXB;
        private System.Windows.Forms.TextBox txtXC;
        private System.Windows.Forms.TextBox txtYB;
        private System.Windows.Forms.TextBox txtYA;
        private System.Windows.Forms.TextBox txtYC;
    }
}

