using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_Figuras
{
    public class Circle:Shape
    {
        public double Radius {  get; set; }

        public override double Area() => (this.Radius * this.Radius * Math.PI);
        /*
        { 
            double area = this.Radius * this.Radius * Math.PI;
            return area; 
        }
        */

    }
}
