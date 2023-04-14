using System;
using System.Collections.Generic;
using System.Linq;

namespace Practica2Ej4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Parte A)
            /*List<int> valores = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int sumaTotal = 0;

            foreach (var valor in valores)
            {
                sumaTotal += valor;
            }

            Console.WriteLine($"La suma total es: {sumaTotal}");

            //Funcion Linq

            IEnumerable<int> numeros = from numero in valores select numero;
            int suma = 0;

            //int suma = valores.Sum();

            foreach (var num in numeros)
            {
                suma += num;
            }
            Console.WriteLine($"La suma total es: {suma}");*/

            //Parte B)
            List<int> valores = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int sumaTotalValoresPares = 0;

            foreach (var valor in valores)
            {
                if (valor % 2 == 0)
                {
                    sumaTotalValoresPares += valor;
                }
            }

            Console.WriteLine($"La suma total de los valores pares es: {sumaTotalValoresPares}");

            //Funcion LinQ
            //Otra forma:
            /*IEnumerable<int> numeros = from numero in valores where numero % 2 == 0 select numero;
            int suma = 0;

            foreach (var num in numeros)
            {
                suma += num;
            }

            Console.WriteLine($"La suma total de los valores pares es: {suma}");*/

            List<int> valoresPares = valores.Where(x => x % 2 == 0).ToList();
            int suma = valoresPares.Sum();
            Console.WriteLine($"La suma total de los valores pares es: {suma}");
        }
    }
}
