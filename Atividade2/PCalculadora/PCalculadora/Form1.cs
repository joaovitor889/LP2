using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PCalculadora
{
    public partial class Form1 : Form
    {
        double numero1, numero2, resultado; //Variaveis globais

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSoma_Click(object sender, EventArgs e)
        {
            if (double.TryParse(textNum1.Text, out numero1) && double.TryParse(textNum2.Text, out numero2))
            {
                resultado = numero1 + numero2;
                textResult.Text = resultado.ToString();
            }
            else
                MessageBox.Show("Numeros inválidos");
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            if (double.TryParse(textNum1.Text, out numero1) && double.TryParse(textNum2.Text, out numero2))
            {
                resultado = numero1 - numero2;
                textResult.Text = resultado.ToString();
            }
            else
                MessageBox.Show("Numeros inválidos");
        }

        private void btnMult_Click(object sender, EventArgs e)
        {
            if(double.TryParse(textNum1.Text, out numero1) && double.TryParse(textNum2.Text, out numero2))
            {
                resultado = numero1 * numero2;
                textResult.Text = resultado.ToString();
            }
            else
                MessageBox.Show("Numeros inválidos"); 
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            if (double.TryParse(textNum1.Text, out numero1) && double.TryParse(textNum2.Text, out numero2))
            {
                if (numero2 == 0)
                    MessageBox.Show("Não pode dividir por zero!!!");
                else
                {
                    resultado = numero1 / numero2;
                    textResult.Text = resultado.ToString();
                }
            }
            else
                MessageBox.Show("Numeros inválidos");
        }

        private void textNum1_Validated(object sender, EventArgs e)
        {
            if ((textNum1.Text == "") && (textNum2.Text == ""))
                return;

            if (!Double.TryParse(textNum1.Text, out numero1))
            {
                MessageBox.Show("Número 1 inválido!!");
                textNum1.Focus();
            }
        }

        private void textNum2_Validated(object sender, EventArgs e)
        {
            if ((textNum1.Text == "") && (textNum2.Text == ""))
                return;
            if(!Double.TryParse(textNum2.Text, out numero2))
            {
                MessageBox.Show("Número 2 inválido");
                textNum2.Focus();
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            textNum1.Clear();
            textNum2.Clear();
            textResult.Clear();

            textNum1.Focus();
        }


    }
}
