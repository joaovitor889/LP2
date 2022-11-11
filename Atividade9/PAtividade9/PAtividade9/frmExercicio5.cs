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
    public partial class frmExercicio5 : Form
    {
        public frmExercicio5()
        {
            InitializeComponent();
        }

        private void btnExecutar_Click(object sender, EventArgs e)
        {
            double[,] matriz = new double[20, 3];
            double media =0;
            string auxiliar;
            
            //Entrada de dados
            for(var i =0; i < 20; i++)
            {
                for (var j=0; j<3; j++)
                {
                    auxiliar = Interaction.InputBox("Digite a nota " + (j+1), " Texto 2");
                    if (!Double.TryParse(auxiliar, out matriz[i, j]))
                    {
                        MessageBox.Show("Valor invalido!!!");
                        i--;
                        j--;
                    }
                    else
                    {
                        media += matriz[i, j];
                    }

                }
                media = media / 3;
                MessageBox.Show("A media do aluno  " + (i + 1)+"\n" + media.ToString());
                media = 0;
            }
        }
    }
}
