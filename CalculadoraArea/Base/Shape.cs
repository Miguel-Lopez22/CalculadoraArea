
namespace CalculadoraArea.Base
{
    public abstract class Shape
    {
        public double Ancho { get; set; }
        public double Alto { get; set; }

        protected Shape(double ancho, double alto)
        {
            Ancho = ancho;
            Alto = alto;
        }

        public abstract double CalculateSurface();
        public abstract string GetShapeName();
    }
}
    

