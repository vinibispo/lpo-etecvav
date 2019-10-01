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
        int a, lettere, letteri, o, u;
        string phrase, inverse, space;
        string[] words;
        char[] arr;

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
            arr = phrase.ToCharArray();
            Array.Reverse(arr);
            inverse = new string(arr);
            txt_oposite.Text = inverse;
            inverse = "";
            for (int i = 0; i < phrase.Length; i++)
            {
                if(phrase.ToUpper().Substring(i, 1) == "A")
                {
                    a += 1;
                }
                if (phrase.ToUpper().Substring(i, 1) == "E")
                {
                   lettere += 1;
                }
                if (phrase.ToUpper().Substring(i, 1) == "I")
                {
                    letteri += 1;
                }
                if (phrase.ToUpper().Substring(i, 1) == "O")
                {
                    o += 1;
                }
                if (phrase.ToUpper().Substring(i, 1) == "U")
                {
                    u += 1;
                }
                lb_letter.Items.Add(phrase[i]);
            }
            txt_char.Text = phrase.Length.ToString();
            txt_a.Text = a.ToString();
            txt_e.Text = lettere.ToString();
            txt_i.Text = letteri.ToString();
            txt_o.Text = o.ToString();
            txt_u.Text = u.ToString();
            txt_together.Text = phrase.Replace(" ", "");
            words = txt_fra.Text.Split(' ');
            for(int i = 0; i< words.Length; i++)
            {
                lb_word.Items.Add(words[i]);
            }
            
        }
    }
}
