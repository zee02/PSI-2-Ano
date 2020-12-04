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

namespace Contadores
{
    public partial class Form1 : Form
    {
        int elec;
        string path = "contadores.txt";

        Form2 ok = new Form2();
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

            if (File.Exists(path))
            {

                FileStream fich = new FileStream(path, FileMode.Open, FileAccess.Read);
                StreamReader read = new StreamReader(fich);

                read.Close();

            }
            else
            {
                FileStream fich = new FileStream(path, FileMode.CreateNew, FileAccess.Write);
           
                fich.Close();
            }
        }

        private void BtnInserir_Click(object sender, EventArgs e)
        {
            bool kek = int.TryParse(txtElec.Text, out elec);

            if (txtElec.Text != "" && cboAno.Text != "" && cboMes.Text != "")
            {

                FileStream fich = new FileStream(path, FileMode.Append, FileAccess.Write);
                StreamWriter escreve = new StreamWriter(fich);
                if (kek)
                {
                    escreve.WriteLine(cboAno.Text + ";" + cboMes.Text + ";" + dtpData.Value + ";" + elec.ToString());

                    ok.dgvLista.Rows.Add(cboAno.Text, cboMes.Text, dtpData.Value, elec);

                    escreve.Close();

                    txtElec.ResetText();
                    txtElec.ResetText();
                    cboAno.Text = "";
                    cboMes.Text = "";
                }
            }
            else
                MessageBox.Show("Insere tudo");
        }

        private void BtnListar_Click(object sender, EventArgs e)
        {

            string data;

            data = dtpData.Value.ToString();
            

            FileStream fich = new FileStream(path, FileMode.Open, FileAccess.Read);
                StreamReader read = new StreamReader(fich);

                while (read.Peek() != -1)
                {


                    string linha = read.ReadLine();

                    int pos1 = linha.IndexOf(";") + 1;
                    int pos2 = linha.IndexOf(";", pos1) + 1;
                    int pos3 = linha.IndexOf(";", pos2) + 1;


                    cboAno.SelectedItem = linha.Substring(0, pos1);
                    cboMes.SelectedItem = linha.Substring(pos1, pos2 - pos1 - 1);
                    data = linha.Substring(pos2 - pos1 - 1);
                    txtElec.Text = linha.Substring(pos3);


                    ok.dgvLista.Rows.Add(cboAno.SelectedItem, cboMes.SelectedItem, data, txtElec.Text);
                    ok.Show();


                }
                read.Close();
            }
        
        }
    }

    
        
        

