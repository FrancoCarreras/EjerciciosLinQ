using System;
using System.Collections.Generic;
using System.Linq;

namespace Practica2Ej5
{
    class Program
    {
        static void Main(string[] args)
        {
            /*List<int> valores = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };

            int sumaTotalValoresParesMayoresAOcho = 0;
            int sumaTotalValoresParesMenoresAOcho = 0;

            foreach (var valor in valores)
            {
                if (valor % 2 == 0)
                {
                    if (valor > 8)
                    {
                        sumaTotalValoresParesMayoresAOcho += valor;
                    }
                    else
                    {
                        sumaTotalValoresParesMenoresAOcho += valor;
                    }
                }
            }

            Console.WriteLine($"La suma total de los valores pares mayores a ocho es: {sumaTotalValoresParesMayoresAOcho}");
            Console.WriteLine($"La suma total de los valores pares menores a ocho es: {sumaTotalValoresParesMenoresAOcho}");*/

            //Parte A)

            /*List<int> valores = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };

            int sumaTotalValoresParesMayoresAOcho = 0;
            int sumaTotalValoresParesMenoresAOcho = 0;

            foreach (var valor in valores)
            {
                    if (valor % 2 == 0 && valor > 8)
                    {
                        sumaTotalValoresParesMayoresAOcho += valor;
                    }
                    else if (valor % 2 == 0 && valor < 8)
                    {
                        sumaTotalValoresParesMenoresAOcho += valor;
                    }
            }

            Console.WriteLine($"La suma total de los valores pares mayores a ocho es: {sumaTotalValoresParesMayoresAOcho}");
            Console.WriteLine($"La suma total de los valores pares menores a ocho es: {sumaTotalValoresParesMenoresAOcho}");*/

            //Parte B)

            List<int> valores = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };

            List<int> paresMayoresAOcho = valores.Where(x => x % 2 == 0 && x > 8).ToList();
            int paresSumaMayoresOcho = paresMayoresAOcho.Sum();
            List<int> paresMenoresAOcho = valores.Where(x => x % 2 == 0 && x < 8).ToList();
            int paresSumaMenoresOcho = paresMenoresAOcho.Sum();

            Console.WriteLine($"La suma total de los valores pares mayores a ocho es: {paresSumaMayoresOcho}");
            Console.WriteLine($"La suma total de los valores pares menores a ocho es: {paresSumaMenoresOcho}");
        }
    }
}
