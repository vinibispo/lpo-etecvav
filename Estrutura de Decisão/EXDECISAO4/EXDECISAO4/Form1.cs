using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EXDECISAO4
{
    public partial class Form1 : Form
    {
        Double m, n1, n2, n3;
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            n1 = Double.Parse(txt_n1.Text);
            n2 = Double.Parse(txt_n3.Text);
            n3 = Double.Parse(txt_n2.Text);
            m = (n1 + n2 + n3) / 3;
            if (m >= 7)
            {
                MessageBox.Show("Nome: " + txt_nome.Text + "\nMédia: " + m + "\nMenção: Aprovado!", "Menção", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (m <= 5)
            {
                MessageBox.Show("Nome: " + txt_nome.Text + "\nMédia: " + m + "\nMenção: Reprovado!", "Menção", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Nome: " + txt_nome.Text  + "\nMédia: " + m + "\nMenção: Recuperação!", "Menção", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
    }
}
