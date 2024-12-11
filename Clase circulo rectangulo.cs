// Clase que representa un Círculo
public class Circulo
{
    // Atributo privado para encapsular el radio del círculo
    private double radio;

    // Constructor que inicializa el radio del círculo
    public Circulo(double radio)
    {
        this.radio = radio;
    }

    // Método para calcular el área del círculo
    // Devuelve un valor double
    public double CalcularArea()
    {
        return Math.PI * radio * radio; // Fórmula: Área = π * r^2
    }

    // Método para calcular el perímetro del círculo
    // Devuelve un valor double
    public double CalcularPerimetro()
    {
        return 2 * Math.PI * radio; // Fórmula: Perímetro = 2 * π * r
    }
}

// Clase que representa un Rectángulo
public class Rectangulo
{
    // Atributos privados para encapsular las dimensiones del rectángulo
    private double largo;
    private double ancho;

    // Constructor que inicializa el largo y el ancho del rectángulo
    public Rectangulo(double largo, double ancho)
    {
        this.largo = largo;
        this.ancho = ancho;
    }

    // Método para calcular el área del rectángulo
    // Devuelve un valor double
    public double CalcularArea()
    {
        return largo * ancho; // Fórmula: Área = largo * ancho
    }

    // Método para calcular el perímetro del rectángulo
    // Devuelve un valor double
    public double CalcularPerimetro()
    {
        return 2 * (largo + ancho); // Fórmula: Perímetro = 2 * (largo + ancho)
    }
}

// Ejemplo de uso de las clases
public class Program
{
    public static void Main(string[] args)
    {
        // Crear un objeto de la clase Circulo con un radio de 5 unidades
        Circulo circulo = new Circulo(5);
        Console.WriteLine("Área del círculo: " + circulo.CalcularArea());
        Console.WriteLine("Perímetro del círculo: " + circulo.CalcularPerimetro());

        // Crear un objeto de la clase Rectangulo con largo 10 y ancho 4
        Rectangulo rectangulo = new Rectangulo(10, 4);
        Console.WriteLine("Área del rectángulo: " + rectangulo.CalcularArea());
        Console.WriteLine("Perímetro del rectángulo: " + rectangulo.CalcularPerimetro());
    }
}
