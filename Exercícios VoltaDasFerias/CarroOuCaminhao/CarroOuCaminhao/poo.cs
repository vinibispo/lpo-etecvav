using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarroOuCaminhao
{
    public partial class poo : Form
    {
        Veiculo v1 = new Veiculo();
        string eixo;
        public poo()
        {
            InitializeComponent();
            v1.Infcarro = true;
        }

        private void poo_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btn_send_Click(object sender, EventArgs e)
        {
            if (v1.Infcarro)
            {
                v1.Infmod = txt_modelo.Text;
                v1.Infplaca = msk_placa.Text;
                v1.Infkm = txt_km.Text;
            }
            else
            {
                v1.Infmod = txt_modelo.Text;
                v1.Infplaca = msk_placa.Text;
                v1.Infkm = txt_km.Text;
                eixo = txt_eixo.Text;            }
        }

        private void btn_carro_Click(object sender, EventArgs e)
        {
            v1.Infcarro = true;
        }

        private void btn_caminhao_Click(object sender, EventArgs e)
        {
            v1.Infcarro = false;
        }
    }
}
