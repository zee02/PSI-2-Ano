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

namespace Ficheiro
{
    public partial class Form1 : Form
    {
  
            public struct info
            {
                public string nome;
                public int idade;
                public  string profissao;
            }
            info pessoas;


        string caminho = "ficheiros.txt";
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnInserir_Click(object sender, EventArgs e)
        {
            if (txtNome.Text != "" && txtProfissao.Text != "")
            {
              
                pessoas.nome = txtNome.Text;
                pessoas.idade = int.Parse(nudIdade.Text);
                pessoas.profissao = txtProfissao.Text;

                FileStream ficheiro = new FileStream(caminho, FileMode.Append, FileAccess.Write);
                StreamWriter escreve = new StreamWriter(ficheiro);
             
                escreve.WriteLine(pessoas.nome + ";" + pessoas.idade.ToString() + ";" +
               pessoas.profissao);
             
                dgvGrelha.Rows.Add(pessoas.nome, pessoas.idade, pessoas.profissao);
  
                escreve.Close();
               
                txtNome.ResetText();
                nudIdade.Value = 18;
                txtProfissao.ResetText();
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
         
            if (File.Exists(caminho))
            {
         
                    FileStream ficheiro = new FileStream(caminho, FileMode.Open, FileAccess.Read);
                    StreamReader ler = new StreamReader(ficheiro);

      
                    while (ler.Peek() != -1)
                    {
              
                        string linha = ler.ReadLine();
         
                        int pos1 = linha.IndexOf(";") + 1;
                        int pos2 = linha.IndexOf(";", pos1) + 1;
              
                        pessoas.nome = linha.Substring(0, pos1 - 1);
                        pessoas.idade = int.Parse(linha.Substring(pos1, pos2 - pos1 - 1));
                        pessoas.profissao = linha.Substring(pos2);
                 
                        dgvGrelha.Rows.Add(pessoas.nome, pessoas.idade, pessoas.profissao);
                    }

                    ler.Close();
            }
            else
            { 
                FileStream ficheiro = new FileStream(caminho, FileMode.CreateNew, FileAccess.Write);
                ficheiro.Close();
            }
        }
    }
}
    
