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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void atividade1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();
            
        }

        private void atividade2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Atividade2 a2 = new Atividade2();
            a2.Show();
            this.Hide();
        }

        private void atividade3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Atividade3 a3 = new Atividade3();
            a3.Show();
            this.Hide();
        }
    }
}
