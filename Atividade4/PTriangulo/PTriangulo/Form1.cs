using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PTriangulo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            textLadoA.Clear();
            textLadoB.Clear();
            textLadoC.Clear();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double A, B, C;

            if(!Double.TryParse(textLadoA.Text, out A) ||
                !Double.TryParse(textLadoB.Text, out B) ||
                !Double.TryParse(textLadoC.Text, out C))
            {
                MessageBox.Show("Valores inválidos");
            }

            else
            {
                if(A < (B + C) && A > Math.Abs(B-C) && B < (A + C) &&
                    B >Math.Abs(A - C) && C < (A + B) && C >Math.Abs (A-B))
                {
                    if(A == B && B == C)
                        MessageBox.Show("Triangulo Equilátero");
                    else
                    {
                        if(A == B || A == C || C == B)
                            MessageBox.Show("Triangulo Isósceles");
                        else
                            MessageBox.Show(" Triangulo escaleno");
                    }
                }
                else
                    MessageBox.Show("Os válores não formam um triangulo");
            }
        }
    }
}
