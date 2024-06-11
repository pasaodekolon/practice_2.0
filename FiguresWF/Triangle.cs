using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiguresWF
{
    internal class Triangle : Figure
    {
        public double Base { get; set; }
        public double Height { get; set; }
        public double Side1 { get; set; }
        public double Side2 { get; set; }
        public double Side3 { get; set; }

        public Triangle(double @base, double height, double side1, double side2, double side3)
        {
            Base = @base;
            Height = height;
            Side1 = side1;
            Side2 = side2;
            Side3 = side3;
        }

        public override double Square()
        {
            return Base * Height / 2;
        }

        public override double Perimetr
        {
            get { return Side1 + Side2 + Side3; }
        }

        public override string ToString()
        {
            return $"Треугольник (Основание = {Base}, Высота = {Height}, Стороны = {Side1}, {Side2} и {Side3})";
        }
    }
}
