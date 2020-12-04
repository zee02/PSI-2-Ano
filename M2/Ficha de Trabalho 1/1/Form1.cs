using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1
{
    public partial class lblSeg : Form
    {
        double irs=0, seg=0, liq=0, sal=0;
        public lblSeg()
        {
            InitializeComponent();
        }

        private void Label6_Click(object sender, EventArgs e)
        {

        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        {
           


            if (txtSalario.Text != "")
            {
                sal = Convert.ToDouble(txtSalario.Text);


                irs = (sal * 0.15);


                seg = (sal * 0.12);

                
                lblLiq.Text = (sal - (seg + irs)).ToString("C2");

                lblSocial.Text = irs.ToString("C2");
                lblSeguranca.Text = seg.ToString("C2");
            }
            else
                MessageBox.Show("Insere números!");
        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }
    }
}
