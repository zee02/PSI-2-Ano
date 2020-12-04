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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            int mov = 5;
            int andar = lblQuadrado.Left;
            int andaright = this.Width - 65 - lblQuadrado.Left; 
            int andardown = this.Height - 90 -lblQuadrado.Top;
            int andarup = lblQuadrado.Top;

            switch (e.KeyCode)
            {
                case Keys.Left:
                    if (andar > mov)
                    {
                        lblQuadrado.Left = lblQuadrado.Left - mov;

                    }
                    else
                        lblQuadrado.Left = lblQuadrado.Left - andar;
                    break;

                case Keys.Right:
                    if (andaright > mov)
                    {
                        lblQuadrado.Left = lblQuadrado.Left + mov;
                    }
                    else
                        lblQuadrado.Left = lblQuadrado.Left + andaright;
                    break;

                case Keys.Down:
                    if (andardown > mov)
                    {
                        lblQuadrado.Top = lblQuadrado.Top + mov;
                    }
                    else
                        lblQuadrado.Top = lblQuadrado.Top + andardown;                
                    break;
                
                case Keys.Up:
                    if (andarup > mov)
                    {
                        lblQuadrado.Top = lblQuadrado.Top - mov;
                    }
                    else
                        lblQuadrado.Top = lblQuadrado.Top - andarup;
                    break;

            }
        }
    }

}

