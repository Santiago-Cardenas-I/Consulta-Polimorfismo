using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculoFiguras
{
    public abstract class FiguraGeometrica
    {
        public abstract double CalcularArea();
        public abstract double CalcularDiametro();
    }
    public class Circulo : FiguraGeometrica
    {
        private double radio;

        public Circulo(double radio)
        {
            this.radio = radio;
        }

        public override double CalcularArea()
        {
            return Math.PI * radio * radio;
        }

        public override double CalcularDiametro()
        {
            return 2 * radio;
        }
    }

    public class Cuadrado : FiguraGeometrica
    {
        private double lado;
        
        public Cuadrado(double lado)
        {
            this.lado = lado;
        }

        public override double CalcularArea()
        {
            return lado * lado;
        }

        public override double CalcularDiametro()
        {
            return lado;
        }
    }

    public class Triangulo : FiguraGeometrica
    {
        private double baseTriangulo;
        private double altura;

        public Triangulo(double baseTriangulo, double altura)
        {
            this.baseTriangulo = baseTriangulo;
            this.altura = altura;
        }

        public override double CalcularArea()
        {
            return 0.5 * baseTriangulo * altura;
        }

        public override double CalcularDiametro()
        {
            throw new InvalidOperationException("Un triángulo no tiene un diámetro definido.");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            FiguraGeometrica circulo = new Circulo(5);
            FiguraGeometrica Cuadrado = new Cuadrado(6);
            FiguraGeometrica triangulo = new Triangulo(3, 4);

            Console.WriteLine("Área del círculo: " + circulo.CalcularArea());
            Console.WriteLine("Diámetro del círculo: " + circulo.CalcularDiametro());

            Console.WriteLine("Área del cuadrado: " + Cuadrado.CalcularArea());
            Console.WriteLine("Diámetro del cuadrado: " + Cuadrado.CalcularDiametro());
           

            Console.WriteLine("Área del triángulo: " + triangulo.CalcularArea());
            try
            {
                Console.WriteLine("Diámetro del triángulo: " + triangulo.CalcularDiametro());
            }
            catch (InvalidOperationException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}