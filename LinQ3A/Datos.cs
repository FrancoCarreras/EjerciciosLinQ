using System.Collections;
using System.Collections.Generic;

namespace EjemplosWin
{
    public static class Datos
    {
        public static IList<Empleado> Empleados = new List<Empleado>
       {
        new Empleado { Id  =  1,  Nombre  =  "Facundo",  Cargo  =  "Junior",  EmpresaId  =  1,  Salario  =  5000  },
        new Empleado { Id = 2, Nombre = "Franco", Cargo = "Desarrollador", EmpresaId = 1, Salario = 6000 },
        new Empleado { Id = 3, Nombre = "Gonzalo", Cargo = "Verificador", EmpresaId = 1, Salario = 1500 },
        new Empleado { Id = 4, Nombre = "Agustin", Cargo = "Probador", EmpresaId = 1, Salario = 9800 },
        new Empleado { Id = 5, Nombre = "Maximo", Cargo = "Junior", EmpresaId = 2, Salario = 3000 },
        new Empleado { Id = 6, Nombre = "Francisco", Cargo = "Desarrollador", EmpresaId = 1, Salario = 5000 },
        new Empleado { Id = 1, Nombre = "Julieta", Cargo = "Junior", EmpresaId = 3, Salario = 6000 },
        new Empleado { Id = 6, Nombre = "Leo", Cargo = "Junior", EmpresaId = 3, Salario = 2000 },
        };
    }
}
