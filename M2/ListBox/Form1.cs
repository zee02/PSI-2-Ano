using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnGerar_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            lstAleatorios.Items.Clear();
            for (int i = 0; i < 10; i++)
            {

                lstAleatorios.Items.Add(rnd.Next(1, 10));
            }
        }
        private void BtnLimpar_Click(object sender, EventArgs e)
        {
            lstAleatorios.Items.Clear();
        }

        private void BtnJanela_Click(object sender, EventArgs e)
        {
            new Janela().Show();
        }
    }
}
