using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex4
{
    public partial class Form1 : Form
    {
        double vendas, salario, novosalario;
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            vendas = Double.Parse(txt_vendas.Text);
            salario = Double.Parse(txt_salario.Text);
            novosalario = salario + 15 * vendas / 100;
            MessageBox.Show("Seu nome é " + txt_nome.Text + "\nSeu salário fixo é R$" + salario + "\nE com suas vendas ele aumentou para R$" + novosalario, "Salário do Vendedor", MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
    }
}
