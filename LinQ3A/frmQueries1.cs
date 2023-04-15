using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace EjemplosWin
{
    public partial class frmQueries1 : Form
    {
        public frmQueries1()
        {
            InitializeComponent();
        }

        private void btnQuery1_Click(object sender, EventArgs e)
        {
            grvResultados.DataSource = Datos.Empleados;
        }

        private void btnQuery2_Click(object sender, EventArgs e)
        {
            var colecion = from empleado in Datos.Empleados
                           orderby empleado.Nombre
                           select empleado;
            grvResultados.DataSource = colecion.ToList();
        }
        private void btnQuery3_Click(object sender, EventArgs e)
        {
            var colecion = from empleado in Datos.Empleados
                           orderby empleado.Nombre descending
                           select new
                           {
                               EmpresaId = empleado.EmpresaId,
                               NombreProducto = empleado.Nombre
                           };
            grvResultados.DataSource = colecion.ToList();
        }
        private void btnQuery4_Click(object sender, EventArgs e)
        {
            var colecion = from empleado in Datos.Empleados
                           orderby empleado.Salario descending
                           select new dtoEmpleado
                           {
                               Nombre=empleado.Nombre,
                               Salario=empleado.Salario 
                           };
            grvResultados.DataSource = colecion.ToList();
        }

        private void btnQuery5_Click(object sender, EventArgs e)
        {
            var coleccion = from empleado in Datos.Empleados
                            orderby empleado.Id
                           select new 
                           {
                               Cargo = empleado.Cargo,
                               Nombre = empleado.Nombre,
                               EmpresaId = empleado.Id
                           };
            grvResultados.DataSource = coleccion.ToList();
        }

        private void btnQuery6_Click(object sender, EventArgs e)
        {
            var colecion = from empleado in Datos.Empleados
                where empleado.Salario > 5000 && empleado.Salario < 9000
                select empleado;

            grvResultados.DataSource = colecion.ToList();
        }

        private void frmQueries1_Load(object sender, EventArgs e)
        {

        }
    }
}
