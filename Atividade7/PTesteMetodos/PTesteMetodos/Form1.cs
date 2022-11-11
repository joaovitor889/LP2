﻿using System;
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
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void exercicioSairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void copiarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Cloclou no copiar");
        }

        private void colarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Clicou no colar");
        }

        private void exercicioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmExercicio2 FRM2 = new frmExercicio2();
            FRM2.MdiParent = this;
            FRM2.WindowState = FormWindowState.Maximized;
            FRM2.Show();
        }

        private void exercico3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmExercicio3 FRM3 = new frmExercicio3();
            FRM3.MdiParent = this;
            FRM3.WindowState = FormWindowState.Maximized;
            FRM3.Show();
        }

        private void exercicio4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmExercicio4 FRM4 = new frmExercicio4();
            FRM4.MdiParent = this;
            FRM4.WindowState = FormWindowState.Maximized;
            FRM4.Show();
        }

        private void exercicio5ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmExercicio5 FRM5 = new frmExercicio5();
            FRM5.MdiParent = this;
            FRM5.WindowState = FormWindowState.Maximized;
            FRM5.Show();
        }
    }
}
