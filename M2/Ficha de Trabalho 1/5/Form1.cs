using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _5
{
    public partial class Idades : Form
    {
        int idade, p1 = 0, p2 = 0, p3 = 0, p4 = 0, p5 = 0,total;

        private void Form1_Load(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void TxtIdade_TextChanged(object sender, EventArgs e)
        {
            
            
        }

        private void BtnSair_Click(object sender, EventArgs e)
        {

        }

        public Idades()
        {
            InitializeComponent();
        }

        private void BtnOk_Click(object sender, EventArgs e)
        {
           
          
            double total = 0, per1 = 0, per2 = 0, per3 = 0, per4 = 0, per5 = 0;
            bool verifica;

            verifica = int.TryParse(txtIdade.Text, out idade);

            if (verifica == true && idade > 0)
            {

            if (idade <= 15 && idade > 0)
                {
                    p1++;
                }
            if (idade <=30 && idade > 16)
                {
                    p2++;
                }
            if (idade <= 45 && idade > 31)
                {
                    p3++;

                }
            if (idade <= 60 && idade > 46)
                {
                    p4++;

                }
            if (idade >= 61)
                {
                    p5++;
                }
                total = p1 + p2 + p3 + p4 + p5;

            per1=  p1/ total;
            per2 = p2 / total;
            per3 = p3 / total;
            per4 = p4 / total;
            per5 = p5 / total;

            lbl15.Text = Convert.ToString(p1);
            lbl30.Text = Convert.ToString(p2);
            lbl45.Text = Convert.ToString(p3);
            lbl60.Text = Convert.ToString(p4);
            lbl61.Text = Convert.ToString(p5);

            lblP15.Text = per1.ToString("P1");
            lblP30.Text = per2.ToString("P1");
            lblP45.Text = per3.ToString("P1");
            lblP60.Text = per4.ToString("P1");
            lblP61.Text = per5.ToString("P1");

      
            }
            else
                MessageBox.Show("Valor inválido");

            

            
        }
        

        private void Label5_Click(object sender, EventArgs e)
        {

        }

        private void Label18_Click(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void LblP60_Click(object sender, EventArgs e)
        {

        }
    }
}
