using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica2Linq
{
    internal class ControlEmpresasEmpleados
    {
        public List<Empresa> listaEmpresas;
        public List<Empleado> listaEmpleados;


        public ControlEmpresasEmpleados()
        {
            listaEmpresas = new List<Empresa>();
            listaEmpleados = new List<Empleado>();

            listaEmpresas.Add(new Empresa { Id = 1, Nombre = "Cei" });
            listaEmpresas.Add(new Empresa { Id = 2, Nombre = "Cure" });
            listaEmpresas.Add(new Empresa { Id = 3, Nombre = "Antel" });

            listaEmpleados.Add(new Empleado { Id  =  1,  Nombre  =  "Facundo",  Cargo  =  "Junior",  EmpresaId  =  1,  Salario  =  5000  });
            listaEmpleados.Add(new Empleado { Id = 2, Nombre = "Franco", Cargo = "Desarrollador", EmpresaId = 1, Salario = 6000 });
            listaEmpleados.Add(new Empleado { Id = 3, Nombre = "Gonzalo", Cargo = "Verificador", EmpresaId = 1, Salario = 1500 });
            listaEmpleados.Add(new Empleado { Id = 4, Nombre = "Agustin", Cargo = "Probador", EmpresaId = 1, Salario = 9800 });
            listaEmpleados.Add(new Empleado { Id = 5, Nombre = "Maximo", Cargo = "Junior", EmpresaId = 2, Salario = 3000 });
            listaEmpleados.Add(new Empleado { Id = 6, Nombre = "Francisco", Cargo = "Desarrollador", EmpresaId = 1, Salario = 5000 });
            listaEmpleados.Add(new Empleado { Id  =  1,  Nombre  =  "Julieta",  Cargo  =  "Junior",  EmpresaId  =  3,  Salario  =  6000  });
            listaEmpleados.Add(new Empleado { Id = 6, Nombre = "Leo", Cargo = "Junior", EmpresaId = 3, Salario = 2000 });


        }






        //Getters
        public void GetSeo(string _Cargo)
        {
            IEnumerable<Empleado> empleados = from empleado in listaEmpleados
                                              where empleado.Cargo == _Cargo
                                              select empleado;
            foreach (Empleado elemento in empleados)
            {
                elemento.GetDatosEmpleado();
            }
        }

        public void getEmpleadosOrdenados()
        {
            IEnumerable<Empleado> empleados = from empleado in listaEmpleados
                                              orderby empleado.Nombre
                                              select empleado;
            foreach (Empleado elemento in empleados)
            {
                elemento.GetDatosEmpleado();
            }
        }

        public void GetEmpleadosOrdenadosSegun()
        {
            IEnumerable<Empleado> empleados = from empleado in listaEmpleados
                                              orderby empleado.Salario
                                              select empleado;
            foreach (Empleado elemento in empleados)
            {
                elemento.GetDatosEmpleado();
            }
        }

        public void getEmpleadosEmpresa(int _Empresa)
        {
            IEnumerable<Empleado> empleados = from empleado in listaEmpleados
                                              join empresa in listaEmpresas on empleado.EmpresaId
                                              equals empresa.Id
                                              where empresa.Id == _Empresa
                                              select empleado;
            foreach (Empleado elemento in empleados)
            {
                elemento.GetDatosEmpleado();
            }
        }

        //Metodos Particulares
        public void promedioSalario()
        {
            var consulta = from e in listaEmpleados
                           group e by e.EmpresaId into g
                           select new { Empresa = g.Key, promedioSalario = g.Average(e => e.Salario)};
            
            foreach (var resultado in consulta)
            {
                switch (resultado.Empresa)
                {
                    case 1: Console.WriteLine($"Empresa IAlpha - Promedio de salario: {resultado.promedioSalario}");
                    break;

                    case 2: Console.WriteLine($"Empresa Udelar - Promedio de salario: {resultado.promedioSalario}");
                    break;

                    case 3: Console.WriteLine($"Empresa SpaceZ - Promedio de salario: {resultado.promedioSalario}");
                    break;
                }
            }
        }
    }
}
