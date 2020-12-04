using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Exercício_de_Aula_sobre_Ficheiros
{
    public partial class Form1 : Form
    {
       
        public Form1()
        {
            InitializeComponent();
        }

        private void RtbEscreve_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnEscrever_Click(object sender, EventArgs e)
        {
            string caminho = "ficheiro.txt";
            FileStream ficheiroo = new FileStream(caminho, FileMode.Append,FileAccess.Write);

            StreamWriter SW = new StreamWriter(ficheiroo);

            SW.WriteLine(rtbEscreve.Text);

            SW.Close();
        }

        private void BtnLer_Click(object sender, EventArgs e)
        {
            string caminho = "ficheiro.txt";
            FileStream ficheiroo = new FileStream(caminho, FileMode.Open, FileAccess.Read);

            StreamReader SR = new StreamReader(ficheiroo);

            rtbLer.Text = SR.ReadToEnd();

            SR.Close();
        }
    }
}
