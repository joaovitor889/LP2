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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmExercicio2 FRM2 = new frmExercicio2();
            FRM2.MdiParent = this; 
            FRM2.WindowState = FormWindowState.Maximized;
            FRM2.Show();
        }

        private void btnExe1_Click(object sender, EventArgs e)
        {
            frmExercicio1 FRM1 = new frmExercicio1();
            FRM1.MdiParent = this;
            FRM1.WindowState = FormWindowState.Maximized;
            FRM1.Show();
        }

        private void btnExe3_Click(object sender, EventArgs e)
        {
            frmExercicio3 FRM3 = new frmExercicio3();
            FRM3.MdiParent = this;
            FRM3.WindowState = FormWindowState.Maximized;
            FRM3.Show();
        }

        private void btnExe4_Click(object sender, EventArgs e)
        {
            frmExercicio4 FRM4 = new frmExercicio4();
            FRM4.MdiParent = this;
            FRM4.WindowState = FormWindowState.Maximized;
            FRM4.Show();
        }
    }
}
