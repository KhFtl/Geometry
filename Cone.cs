using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Cone:Circle
    {
        private double _height;
        public double Height
        { 
            get 
            { 
                return _height; 
            } 
            set 
            {
                if (value <= 0) throw new Exception("Висота конуса не може бути <= 0 це НЕ правильно!!!");
                _height = value; 
            } 
        }
        public Cone()
        {
            
        }
        public Cone(double radius, double height):base(radius)
        {
            Height = height;
        }
        public Cone(Cone cone):base(cone.Radius)
        {
            this.Height = cone.Height;
        }
        public override double GetSquare()
        {
            double result = Math.PI * Radius * Math.Sqrt(Radius * Radius + Height * Height) + base.GetSquare();
            return result;
        }
        public double GetVolume()
        {
            return (1/3)*base.GetSquare() * Height;
        }
        public override string ToString()
        {
            return $"Cone\tRadius:{Math.Round(this.Radius, 2)} Height:{Height} " +
                                $"Square of cone:{Math.Round(this.GetSquare(), 2)} " +
                                $"Volume of cone:{Math.Round(this.GetLength(), 2)}";
        }
    }
}
