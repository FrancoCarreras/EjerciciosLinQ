using System;
using System.Windows.Forms;

namespace EjemplosWin
{
    public partial class frmExtensiones : Form
    {
        public frmExtensiones()
        {
            InitializeComponent();
        }

        private void btnLeft_Click(object sender, EventArgs e1)
        {
            txtResultado.Text = txtValor.Text.Left(1);
        }

        private void btnRight_Click(object sender, EventArgs e)
        {
            txtResultado.Text = txtValor.Text.Right(1);
        }

        private void frmExtensiones_Load(object sender, EventArgs e)
        {

        }
    }
}
