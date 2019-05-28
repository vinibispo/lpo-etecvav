using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex3
{
    public partial class Form1 : Form
    {
        double cg, dp, media;
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            cg = Double.Parse(txt_cg.Text);
            dp = Double.Parse(txt_dp.Text);
            media = dp / cg;
            MessageBox.Show("O consumo médio é " + media + "Km/l","Consumo Médio", MessageBoxButtons.OK, MessageBoxIcon.Information );
        }
    }
}
