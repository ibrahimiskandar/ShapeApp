using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeApp
{
    public abstract class Shape:IMove
    {
        protected Location Location;

        public void Move(double x, double y)
        {
            Location.X += x;
            Location.Y += y;
        }

        public abstract void Scale(double scale);
    }

    interface IMove
    {
        void Move(double x,double y);
    }
}
