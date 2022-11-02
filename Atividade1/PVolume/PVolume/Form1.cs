using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PVolume
{
    public partial class Form1 : Form
    {
        Double raio;
        Double altura;
        public Form1()
        {
            InitializeComponent();
        }

        private void txtRaio_Validated(object sender, EventArgs e)
        {
            if(!Double.TryParse(txtRaio.Text, out raio))
            {
                MessageBox.Show("Valor invalido!");
                txtRaio.Text = "";
                txtRaio.Focus();
            }
            else
            if(raio <= 0)
            {
                MessageBox.Show("Raio deve ser maior que zero!");
                txtRaio.Text = "";
                txtRaio.Focus();
            }
        }

        private void txtAltura_Validated(object sender, EventArgs e)
        {
            if(!Double.TryParse(txtAltura.Text, out altura))
            {
                MessageBox.Show("Valor invalido!");
                txtAltura.Text = "";
                txtAltura.Focus();
            }
            else
            if(altura <= 0)
            {
                MessageBox.Show("Altura tem que ser maior que zero!");
                txtAltura.Text = "";
                txtAltura.Focus();
            }
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if(Double.TryParse(txtAltura.Text, out altura) && Double.TryParse(txtRaio.Text, out raio))
            {
                Double volume;
                volume = Math.PI * Math.Pow(raio, 2) * altura;
                txtVolume.Text = volume.ToString("N2");
            }
            else
            {
                MessageBox.Show("Valores invalidos!");
                txtRaio.Focus();
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtRaio.Clear();
            txtAltura.Clear();
            txtVolume.Clear();

            txtRaio.Focus();
        }
    }
}
