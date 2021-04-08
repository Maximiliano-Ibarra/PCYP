using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Ejercicios.Colecciones._4
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] lineas = File.ReadAllLines("C:/Users/maxij/Documents/APU/APU/Ejercicios de Programación/C#/ratings.txt");
            List<Linea> lines = new List<Linea>();

            foreach (var linea in lineas)
            {
                var valores = linea.Split(',');
                lines.Add(new Linea(int.Parse(valores[0]), long.Parse(valores[1]), int.Parse(valores[2]), DateTime.Parse(valores[3])));
            }

            Console.WriteLine("Top 10 Users Reviewing Movies");
            foreach (var line in lines.GroupBy(el => el.id_usuario).OrderByDescending(el => el.Count()).Take(10))
            {
                Console.WriteLine($"{line.Key} : {line.Count()}");
            }
            Console.ReadKey();
        }
    }
}