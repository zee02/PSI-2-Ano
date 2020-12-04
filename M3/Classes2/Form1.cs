using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Classes2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Retangulo A = new Retangulo();

            A.altura = int.Parse(txtAltura.Text);
            A.largura = int.Parse(txtLargura.Text);
            

            lblAltura.Text = A.Area().ToString("F2");
            lblPerimetro.Text = A.perimetro().ToString("F2");
            lblDiagonal.Text= A.diagonal().ToString("F2");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
