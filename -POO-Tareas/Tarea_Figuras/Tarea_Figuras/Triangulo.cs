using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_Figuras
{
    public class Triangulo:Shape
    {
        public double Base{ get; set;}
        public double Altura{  get; set;}
        public override double Area() => (this.Base* this.Altura)/2;
    }
}
