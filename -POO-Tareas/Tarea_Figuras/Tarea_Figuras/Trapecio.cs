using System;
using System.Collections.Generic;
using System.Text;

namespace Tarea_Figuras
{
    public class Trapecio : Shape
    {
        public double BaseMayor { get; set; }
        public double BaseMenor { get; set; }
        public double Altura { get; set; }

        public override double Area()
        {
            return ((BaseMayor + BaseMenor) * Altura) / 2;
        }
    }
}
