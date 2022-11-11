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
    public partial class frmExercicio4 : Form
    {
        public frmExercicio4()
        {
            InitializeComponent();
        }

        private void btnTestar_Click(object sender, EventArgs e)
        {
            Double SalarioBruto = 0;
            Double SalarioCargo = 0;
            Double Gratificacao = 0;
            int Producao = 0;

            if (Double.TryParse(msktxtGratificacao.Text, out Gratificacao))
            {
                if (Double.TryParse(mkstxtSalario.Text, out SalarioCargo))
                {
                    if (int.TryParse(txtProducao.Text, out Producao))
                    {
                        if (Producao >= 100)
                            SalarioBruto = SalarioCargo+(SalarioCargo * 0.05) + Gratificacao;
                        if (Producao >= 120)
                            SalarioBruto = SalarioCargo+(SalarioCargo * 0.15) + Gratificacao;
                        if (Producao >= 150)
                            SalarioBruto = SalarioCargo+(SalarioCargo * 0.25) + Gratificacao;
                    }

                    MessageBox.Show("Nome: " + txtNome.Text +"\n" + "Cargo: "+ txtCargo.Text + "\n"+
                    "Matricula: "+ txtMatricula.Text + "\n"+ "Salário Bruto: "+ SalarioBruto);
                }
            }

        }

    }
}
