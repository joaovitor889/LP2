using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PTesteMetodos
{
    public partial class frmExercicio5 : Form
    {
        public frmExercicio5()
        {
            InitializeComponent();
        }

        private void btnTestar_Click(object sender, EventArgs e)
        {
            Random numeroAleatorio = new Random();
            int num1 = Convert.ToInt32(txtNum1.Text);
            int num2 = Convert.ToInt32(txtNum2.Text);
            int valor = numeroAleatorio.Next(1,100);
            int media;

            media = (num2 + num1)/2;
            if(valor > media)
            {
                MessageBox.Show("Parabéns número: "+num2);
            }
            else
            {
                MessageBox.Show("Parabéns número: "+num1);
            }

        }
    }
}
