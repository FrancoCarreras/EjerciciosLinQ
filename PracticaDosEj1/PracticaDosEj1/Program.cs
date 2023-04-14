using System;
using System.Collections.Generic;
using System.Linq;

namespace PracticaDosEj1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Persona> personas = new List<Persona>
            {
                new Persona {Nombre = "Juan", Edad = 25, Ciudad = "Lima"},
                new Persona {Nombre = "Maria", Edad = 30, Ciudad = "Bogota"},
                new Persona {Nombre = "Pedro", Edad = 35, Ciudad = "Madrid"},
                new Persona {Nombre = "Ana", Edad = 20, Ciudad = "Lima"},
                new Persona {Nombre = "Jose", Edad = 40, Ciudad = "Buenos Aires"}
            };

            var consulta = from p in personas where p.Edad < 25 && p.Ciudad == "Lima"
                           orderby p.Nombre descending select new { p.Nombre, p.Edad };

            foreach (var persona in consulta)
            {
                Console.WriteLine($"{persona.Nombre} ({persona.Edad} años)");
            }

            //Ejercicio A)
            var consultaUno = from pUno in personas where pUno.Edad > 30 && pUno.Ciudad == "Bogota"
                              orderby pUno.Nombre descending select new {pUno.Nombre};

            Console.WriteLine("Personas que tengan una edad mayor a 30 y vivan en Bogota:");
            foreach (var persona in consultaUno)
            {
                Console.WriteLine($"{persona.Nombre}");
            }

            //Ejercicio B)
            var consultaDos = from pDos in personas
                              where pDos.Edad >= 25 && pDos.Edad <= 35
                              orderby pDos.Edad ascending
                              select new { pDos.Nombre };

            Console.WriteLine("Personas que tengan una edad entre 25 y 35 ordenadas de forma ascendente:");
            foreach (var persona in consultaDos)
            {
                Console.WriteLine($"{persona.Nombre}");
            }
        }
    }
}
