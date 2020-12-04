using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jogo_do_Galo
{

    public partial class Form1 : Form
    {
        int cont = 0, p1 = 0, p2 = 0, coiso = 0;
        bool j1;
        public Form1()
        {
            InitializeComponent();
            btnReiniciar.Enabled = false;
            pnlBaixo.Enabled = false;
        }

        public void vencedor()
        {
            if (btn1.Text == "X" && btn2.Text == "X" && btn3.Text == "X" ||
                btn4.Text == "X" && btn5.Text == "X" && btn6.Text == "X" ||
                btn7.Text == "X" && btn8.Text == "X" && btn9.Text == "X" ||
                btn1.Text == "X" && btn4.Text == "X" && btn7.Text == "X" ||
                btn2.Text == "X" && btn5.Text == "X" && btn8.Text == "X" ||
                btn3.Text == "X" && btn6.Text == "X" && btn9.Text == "X" ||
                btn1.Text == "X" && btn5.Text == "X" && btn9.Text == "X" ||
                btn3.Text == "X" && btn5.Text == "X" && btn7.Text == "X")
            {
                if (j1)
                {
                    p1++;
                    lblVitoria1.Text = p1.ToString() + " - Vitorias";
                    MessageBox.Show("Ganhou o P1!");
                }
                else
                {
                    p2++;
                    lblVitoria2.Text = p2.ToString() + " - Vitorias";
                    MessageBox.Show("Ganhou o P2!");
                }
                pnlBaixo.Enabled = false;

        }

            else if (btn1.Text == "O" && btn2.Text == "O" && btn3.Text == "O" ||
                btn4.Text == "O" && btn5.Text == "O" && btn6.Text == "O" ||
                btn7.Text == "O" && btn8.Text == "O" && btn9.Text == "O" ||
                btn1.Text == "O" && btn4.Text == "O" && btn7.Text == "O" ||
                btn2.Text == "O" && btn5.Text == "O" && btn8.Text == "O" ||
                btn3.Text == "O" && btn6.Text == "O" && btn9.Text == "O" ||
                btn1.Text == "O" && btn5.Text == "O" && btn9.Text == "O" ||
                btn3.Text == "O" && btn5.Text == "O" && btn7.Text == "O")
            {
                if (j1)
                {
                    p2++;
                    lblVitoria2.Text = p2.ToString() + " - Vitorias";
                    MessageBox.Show("Ganhou o P2!");
                }
                else
                {
                    p1++;
                    lblVitoria1.Text = p1.ToString() + " - Vitorias";
                    MessageBox.Show("Ganhou o P1!");
                }
            
        }
            else if (cont >= 9)
            {
                coiso++;
                lblEmpate.Text = coiso + " - Empate(s)";
                MessageBox.Show("Empate");
            }
        }
        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnIniciar_Click(object sender, EventArgs e)
        {
            

            if (txtPlayer1.Text != "" || txtPlayer2.Text != "")
            {
           

                lblJogador1.Text = txtPlayer1.Text + " Joga com";
                lblJogador2.Text = txtPlayer2.Text + " Joga com";

                txtPlayer1.Visible = false;
                txtPlayer2.Visible = false;

                if (rbtX.Checked)
                {
                    lblJogador1.Text = lblJogador1.Text + " X";
                    lblJogador2.Text = lblJogador2.Text + " O";
                    j1 = true;
                }
                else if (rbtO.Checked)
                {
                    lblJogador1.Text = lblJogador1.Text + " O";
                    lblJogador2.Text = lblJogador2.Text + " X";
                    j1 = false;
                }

                lblVitoria1.Text = "0 - Vitórias";
                lblVitoria2.Text = "0 - Vitórias";

                btnIniciar.Enabled = false;
                btnReiniciar.Enabled = true;
                pnlBaixo.Enabled = true;

            }
            else
                MessageBox.Show("Insira os dois nomes!!");
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Quer Sair?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void BtnReiniciar_Click(object sender, EventArgs e)
        {
            cont = 0;
            limpar();
            habilitar();
        }

        private void Btn1_Click(object sender, EventArgs e)
        {
            if (rbtX.Checked)
            {
                rbtO.Checked = true;
                btn1.Text = "X";
                btn1.Enabled = false;
            }
            else if (rbtO.Checked)
            {
                rbtX.Checked = true;
                btn1.Text = "O";
                btn1.Enabled = false;
            }
            cont++;
            vencedor();
        }

        private void Btn2_Click(object sender, EventArgs e)
        {
            if (rbtX.Checked)
            {
                rbtO.Checked = true;
                btn2.Text = "X";
                btn2.Enabled = false;
            }
            else if (rbtO.Checked)
            {
                rbtX.Checked = true;
                btn2.Text = "O";
                btn2.Enabled = false;
            }
            cont++;
            vencedor();
        }

        private void Btn3_Click(object sender, EventArgs e)
        {
            if (rbtX.Checked)
            {
                rbtO.Checked = true;
                btn3.Text = "X";
                btn3.Enabled = false;
            }
            else if (rbtO.Checked)
            {
                rbtX.Checked = true;
                btn3.Text = "O";
                btn3.Enabled = false;
            }
            cont++;
            vencedor();
        }

        private void Btn4_Click(object sender, EventArgs e)
        {
            if (rbtX.Checked)
            {
                rbtO.Checked = true;
                btn4.Text = "X";
                btn4.Enabled = false;
            }
            else if (rbtO.Checked)
            {
                rbtX.Checked = true;
                btn4.Text = "O";
                btn4.Enabled = false;
            }
            cont++;
            vencedor();
        }

        private void Btn5_Click(object sender, EventArgs e)
        {
            if (rbtX.Checked)
            {
                rbtO.Checked = true;
                btn5.Text = "X";
                btn5.Enabled = false;
            }
            else if (rbtO.Checked)
            {
                rbtX.Checked = true;
                btn5.Text = "O";
                btn5.Enabled = false;
            }
            cont++;
            vencedor();
        }

        private void Btn6_Click(object sender, EventArgs e)
        {
            if (rbtX.Checked)
            {
                rbtO.Checked = true;
                btn6.Text = "X";
                btn6.Enabled = false;
            }
            else if (rbtO.Checked)
            {
                rbtX.Checked = true;
                btn6.Text = "O";
                btn6.Enabled = false;
            }
            cont++;
            vencedor();
        }

        private void Btn7_Click(object sender, EventArgs e)
        {
            if (rbtX.Checked)
            {
                rbtO.Checked = true;
                btn7.Text = "X";
                btn7.Enabled = false;
            }
            else if (rbtO.Checked)
            {
                rbtX.Checked = true;
                btn7.Text = "O";
                btn7.Enabled = false;
            }
            cont++;
            vencedor();
        }

        private void PnlBaixo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Btn8_Click(object sender, EventArgs e)
        {
            if (rbtX.Checked)
            {
                rbtO.Checked = true;
                btn8.Text = "X";
                btn8.Enabled = false;
            }
            else if (rbtO.Checked)
            {
                rbtX.Checked = true;
                btn8.Text = "O";
                btn8.Enabled = false;
            }
            cont++;
            vencedor();
        }

        private void Btn9_Click(object sender, EventArgs e)
        {
            if (rbtX.Checked)
            {
                rbtO.Checked = true;
                btn9.Text = "X";
                btn9.Enabled = false;
            }
            else if (rbtO.Checked)
            {
                rbtX.Checked = true;
                btn9.Text = "O";
                btn9.Enabled = false;
            }
            cont++;
            vencedor();
        }
        public void limpar()
        {
            btn1.Text = "";
            btn2.Text = "";
            btn3.Text = "";
            btn4.Text = "";
            btn5.Text = "";
            btn6.Text = "";
            btn7.Text = "";
            btn8.Text = "";
            btn9.Text = "";
        }
        public void habilitar()
        {
            btn1.Enabled = true;
            btn2.Enabled = true;
            btn3.Enabled = true;
            btn4.Enabled = true;
            btn5.Enabled = true;
            btn6.Enabled = true;
            btn7.Enabled = true;
            btn8.Enabled = true;
            btn9.Enabled = true;
        }

    }
}
