using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjemplosWin
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {

        }

        private void llbExtensiones_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmExtensiones forma = new frmExtensiones();
            forma.ShowDialog();
        }

        private void llbQueries1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmQueries1 forma = new frmQueries1();
            forma.ShowDialog();
        }

        private void llbQueries2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmQueries2 forma = new frmQueries2();
            forma.ShowDialog();
        }
    }
}
