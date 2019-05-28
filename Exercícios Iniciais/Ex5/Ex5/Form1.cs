using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex5
{
    public partial class Form1 : Form
    {
        double n1, n2, n3, media;
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            n1 = Double.Parse(txt_n1.Text);
            n2 = Double.Parse(txt_n2.Text);
            n3 = Double.Parse(txt_n3.Text);
            media = (n1 + n2 + n3) / 3;
            MessageBox.Show("O aluno " + txt_nome.Text + " obteve uma média de " + media + " com as notas " + n1 + ", " + n2 + ", " + n3, "Média do aluno", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
