using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IMC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double weight, height, imc;
            weight = Double.Parse(txt_weight.Text);
            height = Double.Parse(txt_height.Text);
            imc = weight / Math.Pow(height, 2);
            if (imc < 18.5)
            {
                MessageBox.Show("Magro", "IMC", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } else if (imc < 25)
            {
                MessageBox.Show("Normal", "IMC", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } else if(imc < 30)
            {
                MessageBox.Show("Obeso I", "IMC", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Obeso II", "IMC", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
