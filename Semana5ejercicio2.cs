using System;
using System.Collections.Generic;

namespace GestionEstudiantes
{
    public class Estudiante
    {
        public string Nombre { get; set; }
        public List<double> Notas { get; set; }

        public Estudiante(string nombre, List<double> notas)
        {
            Nombre = nombre;
            Notas = notas;
        }

        public double CalcularPromedio() => Notas.Count > 0 ? Notas.Average() : 0.0;
    }

    class Program
    {
        static void Main(string[] args)
        {
            Estudiante estudiante = new Estudiante("Maria", new List<double> { 69, 83, 92 });
            Console.WriteLine($"Pomedio de {estudiante.Nombre}: {estudiante.CalcularPromedio()}");
        }
    }
}