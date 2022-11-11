using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace PAtividade9
{
    public partial class frmExercicio2 : Form
    {
        public frmExercicio2()
        {
            InitializeComponent();
        }

        private void btnExecutar_Click(object sender, EventArgs e)
        {
            double[] quantidade = new double[10];
            double[] preco = new double[10];
            string auxiliar;
            double Faturamento = 0;

            for(var i = 0; i < 10; i++)
            {
                auxiliar = Interaction.InputBox("Texto 1", "Texto 2");

                if (!Double.TryParse(auxiliar, out quantidade[i]))
                {
                    MessageBox.Show("Valor invalido!!!");
                    i--;
                }

                else
                {
                    while (true)
                    {
                        auxiliar = Interaction.InputBox("Texto 3", "Texto 4");
                        if(!Double.TryParse(auxiliar, out preco[i]))
                            MessageBox.Show("Valor invalido");

                        else
                            Faturamento += preco[i] * quantidade[i];
                        break;
                    }
                }
            }
            MessageBox.Show(Faturamento.ToString());
        }
    }
}
