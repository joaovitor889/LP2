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
    public partial class frmExercicio3 : Form
    {
        public frmExercicio3()
        {
            InitializeComponent();
        }

        private void bntTestar_Click(object sender, EventArgs e)
        {
            string stringona =  txtTexto.Text.ToLower().Replace(" ", "");
            string stringona2 = stringona;
            char[] vetor = stringona.ToCharArray();

            stringona = "";

            Array.Reverse(vetor);
            foreach (char c in vetor)
               stringona += c;

            if(String.Equals(stringona,stringona2))
                MessageBox.Show("É um palíndromo");
            else
                MessageBox.Show("Não é um palíndromo");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtTexto.Clear();
        }
    }
}
