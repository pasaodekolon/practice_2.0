using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiguresWF
{
    internal class square : Figure
    {
        public double Side { get; set; }

        public square(double side)
        {
            Side = side;
        }

        public override double square()
        {
            return Side * Side;
        }

        public override double Perimetr
        {
            get { return 4 * Side; }
        }

        public override string ToString()
        {
            return $"Квадрат (Сторона = {Side})";
        }
    }

}
