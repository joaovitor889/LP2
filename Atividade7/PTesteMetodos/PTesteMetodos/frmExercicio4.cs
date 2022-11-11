using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PTesteMetodos
{
    public partial class frmExercicio4 : Form
    {
        public frmExercicio4()
        {
            InitializeComponent();
        }

        private void btnLetras_Click(object sender, EventArgs e)
        {
            int cont2 = 0, posicao = 0;
            foreach(char c in rchtxtFrase.Text)
            {
                posicao++;
                if (char.IsLetter(c))
                    cont2++;
            }
            MessageBox.Show("O numero de letras é "+cont2);
        }

        private void btnNumeros_Click(object sender, EventArgs e)
        {
            int cont = 0;
            for(var i = 0; i < rchtxtFrase.Text.Length - 1; i++)
            {
                if (Char.IsNumber(rchtxtFrase.Text[i]))
                    cont ++;
            }
            MessageBox.Show("No seu texto tem "+ (cont+1) + " numeros");
        }

        private void btnEspaco_Click(object sender, EventArgs e)
        {
            int x =0;
            while(x < rchtxtFrase.Text.Length-1)
            {
                if (Char.IsWhiteSpace(rchtxtFrase.Text[x]))
                {
                    MessageBox.Show("A podição do primeiro caracter em branco é " + (x+1));
                    break;
                }

                x++;    
            }

        }
    }
}
