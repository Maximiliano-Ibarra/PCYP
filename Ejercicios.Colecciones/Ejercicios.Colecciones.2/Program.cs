using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios.Colecciones._2
{
    class Program
    {
        public static void Main(string[] args)
        {
            string[] colors = new string[] { "MAGENTA", "RED", "WHITE", "BLUE", "CYAN" };
            string[] removeColors = new string[] { "RED", "WHITE", "BLUE" };

            List<string> colores = new List<string>(colors);
            List<string> coloresBorrados = new List<string>(removeColors);

            Console.WriteLine("Lista original:");
            foreach (string color in colores)
            {
                Console.Write(color + " ");
            }

            for (int i = 0; i < colores.Count; i++)
            {
                for(int j = 0; j < coloresBorrados.Count; j++)
                {
                    if (colores[i].Equals(coloresBorrados[j]))
                    {
                        colores.RemoveAt(i);
                    }
                }
            }

            Console.WriteLine("\nLista con colores borrados:");
            foreach (string color in colores)
            {
                Console.Write(color + " ");
            }

            Console.ReadKey();
        }
    }
}
