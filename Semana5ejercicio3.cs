using System;

namespace CalculadoraBasica
{
    public class Calculadora
    {
        public double Sumar(double a, double b) => a + b;
        public double Restar(double a, double b) => a - b;
        public double Multiplicar(double a, double b) => a * b;
        public double Dividir(double a, double b)
        {
            if (b == 0)
                throw new DivideByZeroException("No se puede dividir entre cero.");
            return a / b;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Calculadora calc = new Calculadora();
            Console.WriteLine("Suma: " + calc.Sumar(8, 4));
            Console.WriteLine("Resta: " + calc.Restar(24, 10));
            Console.WriteLine("Multiplicación; " + calc.Multiplicar(6, 9));
            Console.WriteLine("División: " + calc.Dividir(58, 2));
        }
    }
}