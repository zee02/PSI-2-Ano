using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex6__NÃO_DA_FICHA_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            for(int x=0; x <= 10; x++ )
            {
                cmbNumero.Items.Add(x);
            }
        }

        private void CmbNumero_SelectedIndexChanged(object sender, EventArgs e)
        {
            int u = Convert.ToInt32(cmbNumero.Text), result;
            lstTabuada.Items.Clear();
            for (int x = 0; x <= 10; x++)
            {
                result = u * x;
                lstTabuada.Items.Add (u + " X " + x + " = " + result);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
