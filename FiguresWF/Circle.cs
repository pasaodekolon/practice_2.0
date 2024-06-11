using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiguresWF
{
    internal class Circle : Figure
    {
        public double Radius { get; set; }

        public Circle(double radius)
        {
            Radius = radius;
        }

        public override double Square()
        {
            return Math.PI * Radius * Radius;
        }

        public override double Perimetr
        {
            get { return 2 * Math.PI * Radius; }
        }

        public override string ToString()
        {
            return $"Круг (Радиус = {Radius})";
        }
    }

}
