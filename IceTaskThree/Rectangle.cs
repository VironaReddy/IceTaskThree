using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static IceTaskThree.Program;

namespace IceTaskThree
{
    public class Rectangle : abstractShape, ICalculateArea
    {
        public double Length { get; set; }
        public double Width { get; set; }

        public Rectangle(string name, double length, double width) : base(name)
        {
            Length = length;
            Width = width;
        }

        public double CalculateArea()
        {
            return Length * Width;
        }

        public override void Display()
        {
            base.Display();
            Console.WriteLine($"Length: {Length}, Width: {Width}, Area: {CalculateArea()}");
        }
    }
}
