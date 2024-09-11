
using CalculadoraArea.Base;

namespace CalculadoraArea.Clases
{
    internal class Triangle : Shape
    {
        public Triangle(double ancho, double alto) : base(ancho, alto)
        {
        }

        public override double CalculateSurface()
        {
            return (Ancho * Alto) / 2;
        }

        public override string GetShapeName()
        {
            return "Triangulo";
        }
    }
}
