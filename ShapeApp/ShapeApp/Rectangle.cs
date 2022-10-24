using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeApp
{
    public class Rectangle:Shape
    {
        public double Height { get; set; }
        public double Width { get; set; }

        public Rectangle(double height, double width,Location location)
        {
            Height = height;
            Width = width;
            Location = location;
        }
        public void Rotate()
        {

        }

        public override void Scale( double scale)
        {
            Height *= scale;
            Width *= scale;
        }
    }
}
