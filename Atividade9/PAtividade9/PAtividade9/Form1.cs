using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PAtividade9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void exercício1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmExercicio1 Frm1 = new frmExercicio1();
            Frm1.MdiParent = this;
            Frm1.WindowState = FormWindowState.Maximized;
            Frm1.Show();
        }

        private void exercício2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmExercicio2 Frm2 = new frmExercicio2();
            Frm2.MdiParent = this;
            Frm2.WindowState = FormWindowState.Maximized;
            Frm2.Show();
        }

        private void exercício3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmExercicio3 Frm3 = new frmExercicio3();
            Frm3.MdiParent = this;
            Frm3.WindowState = FormWindowState.Maximized;
            Frm3.Show();
        }

        private void exercício4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmExercicio4 Frm4 = new frmExercicio4();
            Frm4.MdiParent = this;
            Frm4.WindowState = FormWindowState.Maximized;
            Frm4.Show();
        }

        private void exercício5ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmExercicio5 Frm5 = new frmExercicio5();
            Frm5.MdiParent = this;
            Frm5.WindowState = FormWindowState.Maximized;
            Frm5.Show();
        }

        private void exercício6ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmExercicio6 Frm6 = new frmExercicio6();
            Frm6.MdiParent = this;
            Frm6.WindowState = FormWindowState.Maximized;
            Frm6.Show();
        }
    }
}
