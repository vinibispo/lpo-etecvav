using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoForm1
{
    public partial class Atividade8 : Form
    {
        public Atividade8()
        {
            InitializeComponent();
        }

        private void salvarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Arquivos de Texto (.txt)|*.txt*";
            sfd.Title = "Salve um arquivo";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                System.IO.StreamWriter sw = new System.IO.StreamWriter(sfd.FileName);
                sw.Write(richTextBox1.Text);
                sw.Close();
            }
        }

        private void Atividade8_Load(object sender, EventArgs e)
        {

        }

        private void novoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Arquivos de texto (.txt)|*.txt*";
            ofd.Title = "Abra um arquivo";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                System.IO.StreamReader sis = new System.IO.StreamReader(ofd.FileName);
                richTextBox1.Text = sis.ReadToEnd();
                sis.Close();
            }
        }

        private void Atividade8_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Você realmente deseja sair?", "Deseja sair?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.ExitThread();
            }

            else
            {
                e.Cancel = true;

            }
        }
    }
}
