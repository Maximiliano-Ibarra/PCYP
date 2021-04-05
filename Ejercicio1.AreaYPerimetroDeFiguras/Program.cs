using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaYPerimetroFiguras
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Cálculo de área y perímetro de un cuadrado");
            Cuadrado square = new Cuadrado();
            Console.Write("Ingrese la longitud de los lados del cuadrado (en cm): ");
            square.setLado(double.Parse(Console.ReadLine()));
            Console.WriteLine("Cálculo de área: {0}", square.calcularArea());
            Console.WriteLine("Cálculo de perímetro: {0}", square.calcularPerimetro());
            Console.ReadLine();

            Console.WriteLine("Cálculo de área y perímetro de un rectángulo");
            Rectángulo rect = new Rectángulo();
            Console.Write("Ingrese la longitud de la base (en cm): ");
            rect.setBase(double.Parse(Console.ReadLine()));
            rect.setAltura(rect.getBase() / 2);
            Console.WriteLine("La altura del rectángulo es la mitad de la longitud de la base ({0})", rect.getAltura());
            Console.WriteLine("Cálculo de área: {0}", rect.calcularArea());
            Console.WriteLine("Cálculo de perímetro: {0}", rect.calcularPerimetro());
            Console.ReadLine();

            Console.WriteLine("Cálculo de área y perímetro de un triángulo");
            Triángulo tr = new Triángulo();
            Console.Write("Ingrese la longitud de los lados del triángulo (en cm): ");
            tr.setBase(double.Parse(Console.ReadLine()));
            Console.Write("Ingrese la altura del triángulo: ");
            tr.setAltura(double.Parse(Console.ReadLine()));
            Console.WriteLine("Cálculo de área: {0}", tr.calcularArea());
            Console.WriteLine("Cálculo de perímetro: {0}", tr.calcularPerimetro());
            Console.ReadLine();
        }
    }
}
