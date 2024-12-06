using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Circle
    {
        private double _radius;
        public double Radius
        {
            get
            {
                return _radius;
            }
            set
            {
                if (value <= 0) throw new Exception("Радіус менше або 0 це НЕ правильно!!!"); else _radius = value;
            }
        }
        public Circle()
        {

        }
        public Circle(double radius)
        {
            Radius = radius;
        }
        public Circle(Circle circle)
        {
            this.Radius = circle.Radius;
        }
        public bool Equals(Circle circle)
        {
            return Radius == circle.Radius;
        }
        public virtual double GetSquare()
        {
            return Math.PI * (Radius * Radius);
        }
        public double GetLength()
        {
            return 2 * Math.PI * Radius;
        }
        public override string ToString()
        {
            return $"Cricle {this.GetHashCode()}\tRadius:{Math.Round(this.Radius,2)} " +
                $"Square of circle:{this.GetSquare()} " +
                $"Length of circle:{Math.Round(this.GetLength(),2)}";
        }
    }
}
