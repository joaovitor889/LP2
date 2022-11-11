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
    public partial class frmMensalista : Form
    {
        public frmMensalista()
        {
            InitializeComponent();
        }

        private void btnInstanciar_Click_1(object sender, EventArgs e)
        {
            Mensalista objMensalista = new Mensalista();
            //set
            objMensalista.Matricula = Convert.ToInt32(txtMatricula.Text);
            objMensalista.NomeEmpregado = txtNome.Text;
            objMensalista.DataEntradaEmpresa = Convert.ToDateTime(mskbxData.Text);
            objMensalista.SalarioMensal = Convert.ToDouble(txtSalarioMensal.Text);

            //get
            MessageBox.Show("Matricula:"+objMensalista.Matricula+"\n"+
                "Nome:"+objMensalista.NomeEmpregado+"\n"+
                "Data de entrada:"+objMensalista.DataEntradaEmpresa+"\n"+
                "Salario Bruto: "+objMensalista.SalarioBruto()+"\n"+
                "Tempo de Trabalho "+objMensalista.TempoTrabalho());
        }


        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtMatricula.Clear();
            txtNome.Clear();
            txtSalarioMensal.Clear();
            mskbxData.Clear();
        }

        private void txtMatricula_Validated(object sender, EventArgs e)
        {
            int matricula;
            if (!int.TryParse(txtMatricula.Text, out matricula))
            {
                MessageBox.Show("O vlaor inserido está incorreto!!");
                txtMatricula.Focus();
            }
            else if (txtMatricula.Text == "")
                return;
        }

        private void txtNome_Validated(object sender, EventArgs e)
        {
            if ((txtNome.Text == "") || (txtNome.Text.Length < 10))
                MessageBox.Show("Nome inválido!!!");
        }

        private void txtSalarioMensal_Validated(object sender, EventArgs e)
        {
            double SalarioMensal;
            if(!Double.TryParse(txtSalarioMensal.Text, out SalarioMensal))
            {
                MessageBox.Show("O valor está incorreto!!");
                txtSalarioMensal.Focus();
            }
        }
    }
}
