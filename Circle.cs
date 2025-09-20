using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharptips
{
    public class Circle
    {
        private int _radius = 0;
        public Circle()
        {

        }
        public Circle(int raduis)
        {
            _radius = raduis;
        }

        public double Area()
        {
            return Math.PI * _radius * _radius;
        }
        public double Circumference()
        {
            return 2 * Math.PI * _radius;
        }
    }
}
