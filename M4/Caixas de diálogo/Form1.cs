using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Caixas_de_diálogo
{
    public partial class Form1 : Form
    {
        bool guarda;
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
          
                saveFileDialog1.DefaultExt = "*.rtf";
                saveFileDialog1.AddExtension = true;
                saveFileDialog1.FileName = "";
                saveFileDialog1.Filter = "Documento de Texto | *.rtf";


                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    rtbTexto.SaveFile(saveFileDialog1.FileName, RichTextBoxStreamType.RichText);
                    guarda = true;
                }
              
            }
        
        private void BtnAbrir_Click(object sender, EventArgs e)
        {
           
                saveFileDialog1.DefaultExt = "*.rtf";
            saveFileDialog1.AddExtension = true;
            saveFileDialog1.FileName = "";
            saveFileDialog1.Filter = "Documento de Texto | *.rtf";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                rtbTexto.LoadFile(openFileDialog1.FileName, RichTextBoxStreamType.RichText);
            }
        }
        

        private void BtnTipoLetra_Click(object sender, EventArgs e)
        {
            
            fontDialog1.FontMustExist = true;
            fontDialog1.ShowEffects = true;
            fontDialog1.ShowColor = true;

            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                rtbTexto.SelectionFont = fontDialog1.Font;
                rtbTexto.SelectionColor = fontDialog1.Color;
            }
       
        }

        private void BtnEsquerda_Click(object sender, EventArgs e)
        {
           
            rtbTexto.SelectionAlignment = HorizontalAlignment.Left;
            btnEsquerda.Enabled = false;
            btnDireita.Enabled = true;
            btnCentro.Enabled = true;
        
        }

        private void BtnCentro_Click(object sender, EventArgs e)
        {
                rtbTexto.SelectionAlignment = HorizontalAlignment.Center;
                btnEsquerda.Enabled = true;
                btnDireita.Enabled = true;
                btnCentro.Enabled = false;
          
        }

        private void BtnDireita_Click(object sender, EventArgs e)
        {
            
            rtbTexto.SelectionAlignment = HorizontalAlignment.Right;
            btnEsquerda.Enabled = true;
            btnDireita.Enabled = false;
            btnCentro.Enabled = true;
        
        }

       private void GuardaNoFechar()
        {


            if (guarda == false)
            {
                saveFileDialog1.DefaultExt = "*.rtf";
                saveFileDialog1.AddExtension = true;
                saveFileDialog1.FileName = "";
                saveFileDialog1.Filter = "Documento de Texto | *.rtf";


             

                DialogResult dialogResult = MessageBox.Show("Deverá guardar antes de sair!", "Aviso!", MessageBoxButtons.OK);

                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    if (dialogResult == DialogResult.OK)
                    {
                        rtbTexto.SaveFile(saveFileDialog1.FileName, RichTextBoxStreamType.RichText);
                    }
                }
            }

        } 


        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            GuardaNoFechar();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
