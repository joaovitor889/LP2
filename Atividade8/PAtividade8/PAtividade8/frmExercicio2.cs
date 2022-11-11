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
    public partial class frmExercicio2 : Form
    {
        public frmExercicio2()
        {
            InitializeComponent();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtH.Clear();
            txtN.Clear();
        }

        private void btnTestar_Click(object sender, EventArgs e)
        {
            int numeroN;
            Double numeroH = 0;
            if (int.TryParse(txtN.Text, out numeroN))
                if (numeroN < 0)
                {
                    MessageBox.Show("Numero inválido");
                    txtN.Focus();
                }
                else
                {
                    for (var i = 1; i <= numeroN; i++)
                    {
                        numeroH += 1.00 / i;
                    }
                    txtH.Text = numeroH.ToString("N2");
                }
        }

    }
}
