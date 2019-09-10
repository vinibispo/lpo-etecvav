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
    public partial class ManipulacaoString : Form
    {
        int a, lettere, i, o, u;
        string phrase, inverse, space;
        string[] words;

        private void button2_Click(object sender, EventArgs e)
        {
            txt_fra.Clear();
            txt_a.Clear();
            txt_e.Clear();
            txt_i.Clear();
            txt_o.Clear();
            txt_oposite.Clear();
            txt_together.Clear();
            txt_u.Clear();
            lb_letter.Text = "";
        }

        public ManipulacaoString()
        {
            InitializeComponent();
        }

        private void btn_exe_Click(object sender, EventArgs e)
        {
            txt_a.Clear();
            txt_e.Clear();
            txt_i.Clear();
            txt_o.Clear();
            txt_oposite.Clear();
            txt_together.Clear();
            txt_u.Clear();
            lb_letter.Text = "";
            phrase = txt_fra.Text;
            for (int i = phrase.Length - 1; i >= 0; i--)
            {
                inverse += phrase[i];
            }
            txt_oposite.Text = inverse;
            inverse = "";
            for (int i = 0; i < phrase.Length; i++)
            {
                lb_letter.Items.Add(phrase[i]);
            }
            txt_char.Text = phrase.Length.ToString();
            txt_a.Text = a.ToString();
            txt_e.Text = lettere.ToString();
            txt_i.Text = i.ToString();
            txt_o.Text = o.ToString();
            txt_u.Text = u.ToString();
            txt_together.Text = phrase.Replace(" ", "");
            words = txt_fra.Text.Split();
            
        }
    }
}
