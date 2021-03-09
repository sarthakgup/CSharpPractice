using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circle
{
    class Circle
    {
        private double radius;
        private double diameter;
        private double area;

        public double Area
        {
            get
            {
                return area;
            }
                     
        }
        public double Diameter
        {
            get
            {
                return diameter;
            }
        }
        public double Radius
        {
            get
            {
                return radius;
            }
            set
            {
                radius = value;
                diameter = value * 2; //d=2r
                area = Math.Pow(radius, 2) * Math.PI; //Pi*r^2
            }
        }

        public Circle()
        {
            this.Radius = 1;
        }

        public Circle(int radius)
        {
            this.Radius = radius;
            
        }
    }  
}
