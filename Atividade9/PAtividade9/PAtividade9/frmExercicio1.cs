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
    public partial class frmExercicio1 : Form
    {
        public frmExercicio1()
        {
            InitializeComponent();
        }

        private void btnExecutar_Click(object sender, EventArgs e)
        {
            int[] vetor = new int[20];//Declaração de vetor
            string auxiliar;//Declaração de variavel
            string invertido ="";

            //Entrada de dados
            for(var i=0; i <  vetor.Length; i++ )
            {
                auxiliar = Interaction.InputBox("Digite um número, posição:" + (i + 1), "Entrada de Dados:");
                if (!int.TryParse(auxiliar, out vetor[i]))
                {
                    MessageBox.Show("Número invalido!!!");
                    i--;
                }
                else
                {
                    invertido = vetor[i] +"\n"+ invertido;
                }
            }
            MessageBox.Show(invertido);

        //Reverse
        //auxiliar = "";//Limpei a variavel auxiliar
        //for (var i = vetor.Length - 1; i >= 0; i--)
        //    auxiliar += vetor[i] + "\n";//Inseri novos valores na variavel
        //MessageBox.Show(auxiliar);//Imprimi o valor da variavel
    }
    }
}
