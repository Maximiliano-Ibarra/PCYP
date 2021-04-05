using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaYPerimetroFiguras
{
    class Rectángulo : Figura
    {
        private double longitudBase, altura;

        public Rectángulo()
        {
            longitudBase = 0;
            altura = 0;
        }

        public double getBase()
        {
            return longitudBase;
        }

        public void setBase(double lado)
        {
            longitudBase = lado;
        }

        public double getAltura()
        {
            return altura;
        }

        public void setAltura(double lado)
        {
            altura = lado;
        }

        public double calcularArea()
        {
            return longitudBase * altura;
        }

        public double calcularPerimetro()
        {
            return (longitudBase * 2) + (altura * 2);
        }
    }
}
