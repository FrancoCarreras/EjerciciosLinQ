using System;
using System.Collections.Generic;
using System.Linq;

namespace Practica2Ej3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> valores = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            for (var indice = 0; indice < valores.Count - 1; indice++)
            {
                if (valores[indice] > valores[indice + 1])
                {
                    var valorTemporal = valores[indice];
                    valores[indice] = valores[indice + 1];
                    valores[indice + 1] = valorTemporal;

                    indice = -1;
                }
            }

            foreach (var valorOrdenado in valores)
            {
                Console.WriteLine(valorOrdenado);
            }

            //Complejidad Cognitiva: 5
            //1 punto por el for, 1 punto por el .Count, 1 punto por el if, 1 punto porque el if esta anidado y 1 punto por el foreach.

            //Consulta LinQ
            /*Console.WriteLine("Parte B:");
            IEnumerable<int> numerosOrdenados = from numeros in valores orderby valores ascending select numeros;*/

            Console.WriteLine("Parte B)");
            List<int> numerosOrdenados = valores.OrderBy(x => x).ToList();
            foreach (var numeros in numerosOrdenados)
            {
                Console.WriteLine($"{numeros}");
            }
        }
    }
}
