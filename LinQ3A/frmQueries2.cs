using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace EjemplosWin
{
    public partial class frmQueries2 : Form
    {
        //public frmQueries2()
        //{
        //    InitializeComponent();
        //}

        //private void btnProcesar1_Click(object sender, EventArgs e)
        //{
        //    var resultado = from numero in Datos.Numeros
        //          where numero > Convert.ToInt32(txtMayores.Text)
        //          select numero;
             
        //    txtResultado.Clear();
        //    foreach (int n in resultado)
        //        txtResultado.Text += n.ToString() + " ";
        //}

        //private void btnProcesar2_Click(object sender, EventArgs e)
        //{
        //    if (rbtEnteros.Checked)
        //        lstResultados.DataSource =
        //            (from object valor in Datos.MiLista
        //             where valor is int select valor).ToList();
        //    else
        //        lstResultados.DataSource =
        //           (from object valor in Datos.MiLista
        //            where valor is string select valor).ToList();
        //}

        //private void btnProcesar3_Click(object sender, EventArgs e)
        //{
        //    var resultado = from letra in txtFrase.Text
        //                    where !"aeiou".Contains(letra)
        //                    select letra;
        //    txtConsonantes.Text = new string(resultado.ToArray());
        //}

        //private void frmQueries2_Load(object sender, EventArgs e)
        //{

        //}

        //private void txtMayores_TextChanged(object sender, EventArgs e)
        //{

        //}
    }
}
