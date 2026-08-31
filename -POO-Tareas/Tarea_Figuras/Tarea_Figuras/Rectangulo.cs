using System;
using System.Collections.Generic;
using System.Text;

namespace Tarea_Figuras
{
    public class Rectangulo : Shape
    {
        public double Base { get; set; }
        public double Altura { get; set; }

        public override double Area()
        {
            return Base * Altura;
        }
    }
}
