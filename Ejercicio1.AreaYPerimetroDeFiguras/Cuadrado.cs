using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaYPerimetroFiguras
{
    class Cuadrado : Figura
    {
        private double lado;
        
        public Cuadrado()
        {
            lado = 0;
        }

        public double getLado()
        {
            return lado;
        }

        public void setLado(double longitud)
        {
            lado = longitud;
        }

        public double calcularArea()
        {
            return lado * lado;
        }

        public double calcularPerimetro()
        {
            return lado * 4;
        }
    }
}
