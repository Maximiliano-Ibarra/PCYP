using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace RecorrerArchivoCSV
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] lineas = File.ReadAllLines("C:/Users/maxij/Documents/APU/APU/Ejercicios de Programación/C#/RecorrerArchivoCSV/RecorrerArchivoCSV/File/vial.csv");

            Objeto ob;
            int cont = 0;

            foreach(var linea in lineas)
            {
                var valores = linea.Split(',');

                ob = new Objeto(int.Parse(valores[0]), valores[1], long.Parse(valores[2]), valores[3], int.Parse(valores[4]));
                ob.imprimir();
                cont++;
            }

            Console.WriteLine("Total de líneas leídas: " + cont);
            Console.ReadLine();
        }
    }
}
