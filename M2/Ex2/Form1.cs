using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnOK_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Olá " +txtInsere.Text+ " Bem vindo/a ao C#!");
        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            DialogResult left;
            left = MessageBox.Show("Deseja Sair?", "Saída", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (left == DialogResult.Yes)
                Application.Exit();
        
        }

        private void BtnOK_KeyPress(object sender, KeyPressEventArgs e)
        {
          
        }
    }
}
 