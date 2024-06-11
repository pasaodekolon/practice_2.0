using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiguresWF
{
    internal class Trapezoid : Figure
    {
        public double Base1 { get; set; }
        public double Base2 { get; set; }
        public double Height { get; set; }
        public double Side1 { get; set; }
        public double Side2 { get; set; }

        public Trapezoid(double base1, double base2, double height, double side1, double side2)
        {
            Base1 = base1;
            Base2 = base2;
            Height = height;
            Side1 = side1;
            Side2 = side2;
        }

        public override double Square()
        {
            return (Base1 + Base2) * Height / 2;
        }

        public override double Perimetr
        {
            get { return Base1 + Base2 + Side1 + Side2; }
        }

        public override string ToString()
        {
            return $"Трапеция (Основания = {Base1} и {Base2}, Высота = {Height}, Стороны = {Side1} и {Side2})";
        }
    }
}
