using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Circle
    {
        private int _Radius;    // property
        public int Radius  // property
        {
            get { return _Radius;}
            set {
                if (value >= 0)
                    _Radius = value;
                else Console.WriteLine("unzulässiger negativer Wert.");}
        }
        private double _Xcoordinate;    // property
        public double Xcoordinate
        {
            get { return _Xcoordinate; }
            set { _Xcoordinate = value; }
        }
        private double _Ycoordinate;    // property
        public double Ycoordinate 
        { 
            get { return _Ycoordinate; }
            set { _Ycoordinate = value; }
        }
        public double GetArea()
        {
            return Math.Pow(Radius, 2) * Math.PI;
        }
        public double GetCircumference()
        {
            return 2 * Radius * Math.PI;
        }

        public void Move(double dx, double dy)
        {
            Xcoordinate += dx;
            Ycoordinate += dy;
        }
        public void Move(double dx, double dy, int dRadius)
        {
            Move(dx, dy);
            Radius += dRadius;
        }
        public int Bigger(Circle kreis)
        {
            if (kreis == null || Radius > kreis.Radius) return 1;
            if (Radius < kreis.Radius) return -1;
            return 0;
        }
    }
}
