using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exemplo_Classes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnOk_Click(object sender, EventArgs e)
        {
            Triangulo X = new Triangulo();

            X.ladoA = int.Parse(txtXA.Text);
            X.ladoB = int.Parse(txtXB.Text);
            X.ladoC = int.Parse(txtXC.Text);

            lblResult.Text = X.Area().ToString("F2");


        }

        private void BtnKO_Click(object sender, EventArgs e)
        {
            Triangulo Y = new Triangulo();

            Y.ladoA = int.Parse(txtYA.Text);
            Y.ladoB = int.Parse(txtYB.Text);
            Y.ladoC = int.Parse(txtYC.Text);

            lblResult2.Text = Y.Area().ToString("F2");
        }
    }
}
