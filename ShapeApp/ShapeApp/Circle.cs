using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeApp
{
    internal class Circle:Shape
    {
        public double Radius { get; set; }

        public Circle(double r, Location location)
        {
            Radius = r;
            Location = location;
        }

        public override void Scale(double scale)
        {
            Radius *= scale;
        }
    }
}
