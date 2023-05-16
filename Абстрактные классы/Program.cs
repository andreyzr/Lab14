using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Абстрактные_классы
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
        }
    }
    abstract class Figure
    {
        public abstract double GetArea();
        public abstract double GetPerimeter();
        public abstract string Name { get; set; }
    }
    class Rectangular:Figure
    {
        public double Width { get; set; }
        public double Hight { get; set; }
        public override double GetPerimeter()
        {
            return Width*2+Hight*2;
        }
        public override double GetArea()
        {
            return Width* Hight;
        }
        public override string Name
        {
            get
            {
                return Name;
            }
            set 
            { 
                Name = value;
            }
        }
    }
}
