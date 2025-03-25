using System;
class Libro
{
    // Atributos de la clase
    public string Titulo { get; set; }
    public string Autor { get; set; }
    public bool Prestado { get; private set; } // Indica si el libro está prestado

    // Constructor por defecto
    public Libro()
    {
        Titulo = "Sin título";
        Autor = "Desconocido";
        Prestado = false;
    }
    // Constructor con parámetros
    public Libro(string titulo, string autor)
    {
        Titulo = titulo;
        Autor = autor;
        Prestado = false; // Por defecto, el libro no está prestado
    }
    // Método para realizar el préstamo
    public void Prestar()
    {
        if (!Prestado)
        {
            Prestado = true;
            Console.WriteLine($"El libro '{Titulo}' ha sido prestado.");
        }
        else
        {
            Console.WriteLine($"El libro '{Titulo}' ya está prestado.");
        }
    }
    // Método para realizar la devolución
    public void Devolver()
    {
        if (Prestado)
        {
            Prestado = false;
            Console.WriteLine($"El libro '{Titulo}' ha sido devuelto.");
        }
        else
        {
            Console.WriteLine($"El libro '{Titulo}' no estaba prestado.");
        }
    }
    // Método ToString para mostrar la información del libro
    public override string ToString()
    {
        string estado = Prestado ? "Prestado" : "Disponible";
        return $"Título: {Titulo}, Autor: {Autor}, Estado: {estado}";
    }
}
class Program
{
    static void Main(string[] args)
    {
        // Uso del constructor por defecto
        Libro libro1 = new Libro();
        Console.WriteLine(libro1.ToString());

        // Uso del constructor con parámetros
        Libro libro2 = new Libro("Cien años de soledad", "Gabriel García Márquez");
        Console.WriteLine(libro2.ToString());

        // Préstamo y devolución
        libro2.Prestar();
        Console.WriteLine(libro2.ToString());
        libro2.Devolver();
        Console.WriteLine(libro2.ToString());
    }
}