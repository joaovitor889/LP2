using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PSalário
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtFunc.Clear();
            txtFilhos.Clear();
   
            mskbxSalBruto.Clear();
            txtDescontoINSS.Clear();
            txtDescontoIRPF.Clear();
            txtSalFamilia.Clear();
            txtSalLiquido.Clear();
            txtAliqINSS.Clear();
            txtAliqIRPF.Clear();
            txtResumo.Clear();
        }


        private void textFunc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (Char)13)
            {
                SendKeys.Send("{TAB}");
                e.Handled = true;
            }
        }

        private void txtFunc_Validated(object sender, EventArgs e)
        {
            if((txtFunc.Text == "") || (txtFunc.Text.Length<10))
                MessageBox.Show("Nome inválido!!!");
        }

        private void btnValidar_Click(object sender, EventArgs e)
        {
            double descontoINSS = 0;
            double descontoIRPF = 0;
            double salarioFamilia = 0;
            double salarioLiquido = 0;
            double salarioBruto = 0;

            if((txtFunc.Text == "") || (txtFunc.Text.Length<10))
                MessageBox.Show("Nome inválido");
            else if(double.TryParse(mskbxSalBruto.Text, out salarioBruto))
            {
                if(salarioBruto<=0)
                    MessageBox.Show("Salário Bruto inválido");
                else
                {
                    if(salarioBruto<= 800.47)
                    {
                        txtAliqINSS.Text = "7.65%";
                        descontoINSS = 0.0765 * salarioBruto;
                    }
                    else if(salarioBruto<= 1050)
                    {
                        txtAliqINSS.Text = "8.65%";
                        descontoINSS = 0.0865 * salarioBruto;
                    }
                    else if(salarioBruto <= 1400.77)
                    {
                        txtAliqINSS.Text = "9%";
                        descontoINSS = 0.09 * salarioBruto;
                    }
                    else if(salarioBruto <= 2801.56)
                    {
                        txtAliqINSS.Text = "11%";
                        descontoINSS = 0.11 * salarioBruto;
                    }
                    else
                    {
                        txtAliqINSS.Text = "Teto";
                        descontoINSS = 308.17;
                    }

                    txtDescontoINSS.Text = descontoINSS.ToString("N2");

                    if(salarioBruto <= 1257.12)
                    {
                        txtAliqIRPF.Text = "Insento";
                        descontoIRPF = 0;
                    }
                    else if(salarioBruto <= 2512.08)
                    {
                        txtAliqIRPF.Text = "15%";
                        descontoIRPF = 0.15 * salarioBruto;
                    }
                    else
                    {
                        txtAliqIRPF.Text = "27.5%";
                        descontoIRPF = 0.275 * salarioBruto;
                    }

                    txtDescontoIRPF.Text = descontoIRPF.ToString("N2");

                    if(salarioBruto <= 450.52)
                    {
                        salarioFamilia = 22.33 * Convert.ToDouble(txtFilhos.Text);
                        txtSalFamilia.Text = salarioFamilia.ToString("N2");
                    }
                    else if(salarioBruto <= 654.61)
                    {
                        salarioFamilia = 15.74 * Convert.ToDouble(txtFilhos.Text);
                        txtSalFamilia.Text = salarioFamilia.ToString("N2");
                    }
                    else
                    {
                        salarioFamilia = 0;
                        txtSalFamilia.Text = salarioFamilia.ToString("N2");
                    }

                    if (rbtnFeminino.Checked)
                        txtResumo.Text = "Os descontos da Sra " + txtFunc.Text;
                    else
                        txtResumo.Text = "Os descontos do Sro " + txtFunc.Text;

                    if (ckbxCasado.Checked)
                        txtResumo.Text = txtResumo.Text + " que é casado(a) e tem " + txtFilhos.Text + " filho(s) são:";
                    else
                        txtResumo.Text = txtResumo.Text + " que é solteiro(a) e tem " + txtFilhos.Text + " filho(s) são:";

                }
            }
        }

        private void txtFilhos_Validated(object sender, EventArgs e)
        {
            double filhos;
            if (txtFilhos.Text == "")
                return;
            if (!Double.TryParse(txtFilhos.Text, out filhos ))
            {
                MessageBox.Show("Valor inválido!!!");
                txtFilhos.Focus();
            }    
        }
    }
}
