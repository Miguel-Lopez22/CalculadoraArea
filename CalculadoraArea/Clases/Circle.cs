
using CalculadoraArea.Base;
using System;

namespace CalculadoraArea.Clases
{
    internal class Circle : Shape
    {
        public Circle(double radius) : base(radius, radius)
        {
        }

        public override double CalculateSurface()
        {
            double radius = Ancho / 2;
            return Math.PI * (Math.Pow(radius,2));
        }

        public override string GetShapeName()
        {
            return "Circulo";
        }
    }
}
