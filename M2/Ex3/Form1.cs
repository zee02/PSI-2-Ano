using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnCor_Click(object sender, EventArgs e)
        {
            int num;
            num = int.Parse(txtNum.Text);

            if (num > 5 || num < 1) {
                MessageBox.Show("Número inválido");
            
        }
            if (num == 1)
            {
                BackColor = Color.Red;
            }
            if (num == 2)
            {
                BackColor = Color.Blue;
            }
            if (num == 3)
            {
                BackColor = Color.Aquamarine;
            }
            if (num == 4)
            {
                BackColor = Color.BlueViolet;
            }
            if (num == 5)
            {
                BackColor = Color.DarkOrange;
            }
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
              Application.Exit();
        }

        private void BtnLimpar_Click(object sender, EventArgs e)
        {
            BackColor = DefaultBackColor;
           txtNum.Text = String.Empty;
            
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
