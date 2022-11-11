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
    public partial class frmExercicio6 : Form
    {
        public frmExercicio6()
        {
            InitializeComponent();
        }

        private void btnExecutar_Click(object sender, EventArgs e)
        {
            string[] vetor = new string[4];

            for(var i=0;i<4;i++)
            {
                vetor[i] = Interaction.InputBox("Digite um nome", "Entrada de dados");

                lstboxResultado.Items.Add("O nome " + vetor[i] + " tem " + vetor[i].Replace(" ", "").Length + " caracteres");
            }
        }
    }
}
