
using CalculadoraArea.Base;

namespace CalculadoraArea.Clases
{
    internal class Rectangle : Shape
    {
        public Rectangle(double ancho, double alto) : base(ancho, alto)
        {
        }

        public override double CalculateSurface()
        {
            return Ancho * Alto;
        }

        public override string GetShapeName()
        {
            return "Rectangulo";
        }
    }
}
    

