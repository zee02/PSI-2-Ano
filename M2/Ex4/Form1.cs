using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex4
{
    public partial class Form1 : Form
    {
        int num1,num2,result = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void TxtOperators_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {
            num1 = int.Parse(txtInsere1.Text);
            num2 = int.Parse(txtInsere2.Text);
            result = (num1 / num2);
            txtResult.Text = Convert.ToString(result);

        }

        private void Label2_Click(object sender, EventArgs e)
        {
            num1 = int.Parse(txtInsere1.Text);
            num2 = int.Parse(txtInsere2.Text);
            result = (num1 * num2);
            txtResult.Text = Convert.ToString(result);
        }

        private void Label3_Click(object sender, EventArgs e)
        {
            num1 = int.Parse(txtInsere1.Text);
            num2 = int.Parse(txtInsere2.Text);
            result = (num1 - num2);
            txtResult.Text = Convert.ToString(result);
        }

        private void LblMais_Click(object sender, EventArgs e)
        {

             num1 = int.Parse(txtInsere1.Text);
             num2 = int.Parse(txtInsere2.Text);
             result = (num1 + num2);
            txtResult.Text = Convert.ToString(result);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BtnTerminar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnLimpar_Click(object sender, EventArgs e)
        {
            txtInsere1.Text = String.Empty;
            txtInsere2.Text = String.Empty;
            txtResult.Text = String.Empty;
        }

        private void TxtInsere1_TextChanged(object sender, EventArgs e)
        {
          
           
        }

        private void TxtInsere2_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
