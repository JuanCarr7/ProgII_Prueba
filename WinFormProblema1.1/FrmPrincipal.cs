using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormProblema1._1
{
    public partial class FrmPrincipal : Form
    {
        frmDetalleCarrera frDC = new frmDetalleCarrera();
        FrmCarrera frC = new FrmCarrera();
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void nuevoDetalleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frDC.ShowDialog();
            frDC.Dispose();
        }

        private void nuevaCarreraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frC.ShowDialog();
            frC.Dispose();
            
        }
    }
}
