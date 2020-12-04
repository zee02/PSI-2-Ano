using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3
{
    public partial class Form1 : Form
    {
        int A = 0, B = 0, C = 0, D = 0, vencedor = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnCandB_Click(object sender, EventArgs e)
        {
            B++;
            if (B > vencedor)
            {
                vencedor = B;
                lblWinner.Text = "B";
            }

        }

        private void BtnCandC_Click(object sender, EventArgs e)
        {
            C++;
            if (C > vencedor)
            {
                vencedor = C;
                lblWinner.Text = "C";
            }

        }

        private void BtnCandD_Click(object sender, EventArgs e)
        {
            D++;
            if (D > vencedor)
            {
                vencedor = D;
                lblWinner.Text = "D";
            }

        }

        private void BtnTermina_Click(object sender, EventArgs e)
           
        {
  
            double pA = 0, pB = 0, pC = 0, pD = 0, all =0;
            this.Height = 400;
 
            lblVotosA.Text = A.ToString();
            lblVotosB.Text = B.ToString();
            lblVotosC.Text = C.ToString();
            lblVotosD.Text = D.ToString();

            all = A + B + C + D;
            pA = (A)/all;
            pB = (B) / all;
            pC = (C) / all;
            pD = (D) / all;

           lblPerA.Text= pA.ToString("P1");
           lblPerB.Text = pB.ToString("P1");
           lblPerC.Text = pC.ToString("P1");
           lblPerD.Text = pD.ToString("P1");


            lblTotal.Text = all.ToString();

            btnTermina.Enabled = false;

            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void BtnCand4_Click(object sender, EventArgs e)
        {
            A++;
            if( A>vencedor)
            {
                vencedor = A;
            }
            lblWinner.Text= "A";
           
        }
    }
}
