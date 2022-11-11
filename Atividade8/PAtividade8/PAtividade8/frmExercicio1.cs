using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PAtividade8
{
    public partial class frmExercicio1 : Form
    {
        public frmExercicio1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            int cont = 0;
            for (var i = 0; i < rchtxtFrase.Text.Length - 1; i++)
            {
                if (Char.IsWhiteSpace(rchtxtFrase.Text[i]))
                    cont++;
            }
            MessageBox.Show("No seu texto tem " + cont + " espaços em branco");
        }

        private void btnEspaço_Click(object sender, EventArgs e)
        {
            int cont = 0;
            for (var i = 0; i < rchtxtFrase.Text.Length - 1; i++)
            {
                if (Char.IsWhiteSpace(rchtxtFrase.Text[i]))
                    cont++;
            }
            MessageBox.Show("No seu texto tem " + cont + " espaços em branco");
        }

        private void btnR_Click(object sender, EventArgs e)
        {
            int cont2 = 0;
            for (var i = 0; i < rchtxtFrase.Text.Length; i++)
            {
                if (rchtxtFrase.Text[i].ToString() == "r" ||
                    rchtxtFrase.Text[i].ToString() == "R")
                    cont2 += 1;
               
            }

            MessageBox.Show("No seu texto tem " + cont2  + " letras R");
        }


        private void btnPares_Click(object sender, EventArgs e)
        {
            int cont3 = 0;
            for(var i = 0; i < rchtxtFrase.Text.Length - 1; i++)
            {
                if (rchtxtFrase.Text[i] == rchtxtFrase.Text[i + 1])
                    cont3++;
            }
            MessageBox.Show("No seu texto tem " + cont3 + " pares de letras seguidos");
        }
    }
}
