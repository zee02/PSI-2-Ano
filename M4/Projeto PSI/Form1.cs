using System;
using System.IO;
using System.Windows.Forms;


namespace Projeto_PSI
{
    public partial class Form1 : Form
    {
        string caminho = "inscricoes.txt", nome, rank, jogo;

      
        public Form1()
        {
            InitializeComponent();

          
        }

        private void ComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BtnInsere_Click(object sender, EventArgs e)
        {


        }

        private void TsbEliminar_Click(object sender, EventArgs e)
        {
            File.WriteAllText(@"D:\Curso\PSI\M4\Projeto PSI\bin\Debug\inscricoes.txt", String.Empty);

            //Remove a célula selecionada quando clicado o botão eliminar
            foreach (DataGridViewCell kek in dgvInscrições.SelectedCells)
            {
                if (kek.Selected)
                    dgvInscrições.Rows.RemoveAt(kek.RowIndex);
            }

            cmbJogos.Text = "";
            cmbRank.Text = "";
            txtNome.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            FileStream fichLer = new FileStream(caminho, FileMode.Open, FileAccess.Read);
            StreamReader RD = new StreamReader(fichLer);



            while (RD.Peek() != -1)
            {

                string linha = RD.ReadLine();

                int pos1 = linha.IndexOf(";") + 1;
                int pos2 = linha.IndexOf(";", pos1) + 1;

                nome = linha.Substring(0, pos1 - 1);
                jogo = linha.Substring(pos1, pos2 - pos1 - 1);
                rank = linha.Substring(pos2);

                dgvInscrições.Rows.Add(nome, jogo, rank);
            }

            RD.Close();
        }

        private void DgvInscrições_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //obtém um valor , indicando o índice de linha da célula na qual o evento ocorre
            //Envia a célula do Data Grid View selecionada para as text box e as combo

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvInscrições.Rows[e.RowIndex];

                txtNome.Text = row.Cells[0].Value.ToString();
                cmbJogos.Text = row.Cells[1].Value.ToString();
                cmbRank.Text = row.Cells[2].Value.ToString();
            }


        }
        private void TsbAnular_Click(object sender, EventArgs e)
        {
            cmbJogos.Text = "";
            cmbRank.Text = "";
            txtNome.Text = "";
        }

        private void ToolStripButton1_Click(object sender, EventArgs e)
        {
            cmbJogos.Enabled = true;
            cmbRank.Enabled = true;
            txtNome.Enabled = true;
            dgvInscrições.Enabled = true;

            cmbJogos.Text = "";
            cmbRank.Text = "";
            txtNome.Text = "";

            nome = txtNome.Text;
            rank = cmbRank.Text;
            jogo = cmbJogos.Text;

        }

        private void ToolStripButton2_Click(object sender, EventArgs e)
        {
            if (cmbJogos.Text != "" && cmbRank.Text != "" && txtNome.Text != "")
            {

                foreach (DataGridViewCell kek in dgvInscrições.SelectedCells)
                {
                    if (kek.Selected)
                        dgvInscrições.Rows.RemoveAt(kek.RowIndex);
                }

                string nome = txtNome.Text;
                string jogo = cmbJogos.Text;
                string rank = cmbRank.Text;
                string[] row = { nome, jogo, rank };
                dgvInscrições.Rows.Add(row);

                FileStream fichE = new FileStream(caminho, FileMode.Open, FileAccess.Write);
                StreamWriter escrever = new StreamWriter(fichE);

                escrever.WriteLine(nome + ";" + jogo + ";" + rank);

                escrever.Close();
            }
            else
                MessageBox.Show("Preencha todos os campos!", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        private void TsbGuardar_Click(object sender, EventArgs e)

        {
            if (cmbJogos.Text != "" && cmbRank.Text != "" && txtNome.Text != "")
            {

            nome = txtNome.Text;
            jogo = cmbJogos.Text;
            rank = cmbRank.Text;

            FileStream fichE = new FileStream(caminho, FileMode.Append, FileAccess.Write);
            StreamWriter escrever = new StreamWriter(fichE);

            escrever.WriteLine(nome + ";" + jogo + ";" + rank);

            escrever.Close();



                if (File.Exists(caminho))
                {
                    dgvInscrições.Rows.Clear();
                    FileStream fichL = new FileStream(caminho, FileMode.Open, FileAccess.Read);
                    StreamReader ler = new StreamReader(fichL);



                    while (ler.Peek() != -1)
                    {

                        string linha = ler.ReadLine();

                        int pos1 = linha.IndexOf(";") + 1;
                        int pos2 = linha.IndexOf(";", pos1) + 1;

                        nome = linha.Substring(0, pos1 - 1);
                        jogo = linha.Substring(pos1, pos2 - pos1 - 1);
                        rank = linha.Substring(pos2);

                        dgvInscrições.Rows.Add(nome, jogo, rank);
                        txtNome.Text = "";
                        cmbJogos.Text = "";
                        cmbRank.Text = "";
                        cmbJogos.Focus();
                    }

                    ler.Close();
                }
                else
                {
                    FileStream fich = new FileStream(caminho, FileMode.CreateNew, FileAccess.Write);
                    fich.Close();
                }
            }
            else
                MessageBox.Show("Preencha todos os campos!", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}



