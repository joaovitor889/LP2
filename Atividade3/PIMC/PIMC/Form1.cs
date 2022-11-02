using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PIMC
{
    public partial class Form1 : Form
    {
        double imc;
        double altura;
        double peso; 

        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {

            if (Double.TryParse(txtAlt.Text, out altura) && Double.TryParse(txtPeso.Text, out peso))
            {
                if (peso <= 0 || altura <= 0)
                {
                    MessageBox.Show("Valores inválidos");
                    txtAlt.Focus();
                }

                imc = peso / (Math.Pow(altura, 2));

                imc = Math.Round(imc, 1);

                txtResult.Text = imc.ToString("N1");

                if (imc < 18.5)
                    MessageBox.Show("Magreza");
                else if (imc <= 24.9)
                    MessageBox.Show("Normalidade");
                else if (imc <= 29.9)
                    MessageBox.Show("Sobrepeso");
                else if (imc <= 39.9)
                    MessageBox.Show("Obesidade");
                else
                    MessageBox.Show("Obesidade grave");
            }
            else
                MessageBox.Show("Valor inválido");
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtAlt.Clear();
            txtPeso.Clear();
            txtResult.Clear();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtAlt_Validated(object sender, EventArgs e)
        {
            if ((txtAlt.Text == "") && (txtPeso.Text == ""))
                return;
            if(!Double.TryParse(txtAlt.Text, out altura))
            {
                MessageBox.Show("Numero inválido");
                txtAlt.Focus();
            }

        }

        private void txtPeso_Validated(object sender, EventArgs e)
        {
            if ((txtAlt.Text == "") && (txtPeso.Text == ""))
                return;
            if (!Double.TryParse(txtPeso.Text, out peso))
            {
                MessageBox.Show("Peso inválido");
                txtPeso.Focus();
            }
        }
    }
}
