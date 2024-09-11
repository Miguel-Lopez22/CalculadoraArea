
using CalculadoraArea.Base;
using CalculadoraArea.Clases;
using System;

namespace CalculadoraArea
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Shape[] formas = new Shape[]
            {
                new Rectangle(10, 5),
                new Triangle(10, 5),
                new Circle(10)
            };

            double[] areas = new double[formas.Length];

            for (int i = 0; i < formas.Length; i++)
            {
                areas[i] = formas[i].CalculateSurface();
                Console.WriteLine($"Área del {formas[i].GetShapeName()}: {areas[i]:F2}");
            }

            Console.WriteLine("Presiona cualquier tecla para cerrar la consola...");
            Console.ReadKey();
        }
    }
}
        
    

