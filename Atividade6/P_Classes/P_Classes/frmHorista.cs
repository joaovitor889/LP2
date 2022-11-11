using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P_Classes
{
    public partial class frmHorista : Form
    {
        public frmHorista()
        {
            InitializeComponent();
        }

        private void btnInstanciar_Click(object sender, EventArgs e)
        {
            Horista objHorista = new Horista();
            objHorista.Matricula = Convert.ToInt32(txtMatricula.Text);
            objHorista.NomeEmpregado = txtNome.Text;
            objHorista.DataEntradaEmpresa = Convert.ToDateTime(mksbxData.Text);
            objHorista.SalarioHora = Convert.ToDouble(txtSalarioHora.Text);
            objHorista.NumeroHora = Convert.ToDouble(txtNumeroHora.Text);
            objHorista.DiasFalta = Convert.ToInt32(txtDiasFalta.Text);

            MessageBox.Show("Matricula:" + objHorista.Matricula + "\n" +
               "Nome:" + objHorista.NomeEmpregado + "\n" +
               "Data de entrada:" + objHorista.DataEntradaEmpresa + "\n" +
               "Salario Bruto: " + objHorista.SalarioBruto() + "\n" +
               "Tempo de Trabalho " + objHorista.TempoTrabalho()+ "\n"+
               "Dias de Ausencia " + objHorista.DiasFalta + "\n");
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtMatricula.Clear();
            txtNome.Clear();
            mksbxData.Clear();
            txtDiasFalta.Clear();
            txtNumeroHora.Clear();
            txtSalarioHora.Clear();
        }

        private void txtMatricula_Validated(object sender, EventArgs e)
        {
            int matricula;
            if (!int.TryParse(txtMatricula.Text, out matricula))
            {
                MessageBox.Show("O valor inserid oestá inválido!!");
                txtMatricula.Focus();
            }
            else if (txtMatricula.Text == "")
                return;
        }

        private void txtSalarioHora_Validated(object sender, EventArgs e)
        {
            double SalarioHora;
            if (!Double.TryParse(txtSalarioHora.Text, out SalarioHora))
            {
                MessageBox.Show("O valor está incorreto!!");
                txtSalarioHora.Focus();
            }
        }

        private void txtNome_Validated(object sender, EventArgs e)
        {
            if ((txtNome.Text == "") || (txtNome.Text.Length < 10))
                MessageBox.Show("Nome inválido!!!");
        }

        private void txtNumeroHora_Validated(object sender, EventArgs e)
        {
            int numHoras;
            if (!int.TryParse(txtNumeroHora.Text, out numHoras))
            {
                MessageBox.Show("O valor inserid oestá inválido!!");
                txtMatricula.Focus();
            }
            else if (txtNumeroHora.Text == "")
                return;

        }

        private void txtDiasFalta_Validated(object sender, EventArgs e)
        {
            int diasFalta;
            if (!int.TryParse(txtDiasFalta.Text, out diasFalta))
            {
                MessageBox.Show("O valor inserid oestá inválido!!");
                txtDiasFalta.Focus();
            }
            else if (txtDiasFalta.Text == "")
                return;
        }
    }
}
