using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EXDECISAO1
{
    public partial class Form1 : Form
    {
        double n1, n2, r;
       

        private void btn_ok_Click(object sender, EventArgs e)
        {
            n1 = Double.Parse(txt_n1.Text);
            n2 = Double.Parse(txt_n2.Text);
            if (txt_op.Text == "+")
            {
                r = n1 + n2;
            }
            else if (txt_op.Text == "-")
            {
                r = n1 - n2;
            }
            else if (txt_op.Text == "*")
            {
                r = n1 * n2;
            }
            else if (txt_op.Text == "/")
            {
                r = n1 / n2;
            }
            MessageBox.Show("O resultado é " + r, "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public Form1()
        {
            InitializeComponent();
        }


    }
}
