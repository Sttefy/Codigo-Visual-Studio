using System;
using System.Collections.Generic;

namespace Biblioteca
{
    public class Libro
    {
        public string Titulo { get; set; }
        public string Autor { get; set; }

        public Libro(string titulo, string autor)
        {
            Titulo = titulo;
            Autor = autor;
        }
    }

    public class Biblioteca
    {
        private List<Libro> libros = new List<Libro>();

        public void AgregarLibro(Libro libro) => libros.Add(libro);

        public void MostrarLibros()
        {
            foreach (var libro in libros)
                Console.WriteLine($"Título; {libro.Titulo}, Autor: {libro.Autor}");
        }

        public void BuscarPortitulo(string titulo)
        {
            var libro = libros.Find(1 => 1.Titulo.Contains(titulo, StringComparison.OrdinalIgnoreCase));
            Console.WriteLine(libro != null
                ? $"Encontrado: {libro.Titulo}, Autor: {libro.Autor}"
                : "No se encontró un libro con ese título.");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Biblioteca biblioteca = new Biblioteca();
            biblioteca.AgregarLibro(new Libro("Cumanda", "Juan León Mera"));
            biblioteca.AgregarLibro(new Libro("Huasipungo", "Jorge Icaza Coronel"));

            biblioteca.MostrarLibros();
            biblioteca.BuscarPortitulo("Cumanda");
        }
    }
}