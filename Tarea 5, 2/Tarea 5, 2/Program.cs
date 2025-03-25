using System;

class Persona
{
    // Atributos de la clase
    public string Nombre { get; set; }
    public string Apellidos { get; set; }
    public int Edad { get; set; }
    public bool Casado { get; set; }
    public string NumeroDocumentoIdentidad { get; set; }

    // Constructor
    public Persona(string nombre, string apellidos, int edad, bool casado, string numeroDocumentoIdentidad)
    {
        Nombre = nombre;
        Apellidos = apellidos;
        Edad = edad;
        Casado = casado;
        NumeroDocumentoIdentidad = numeroDocumentoIdentidad;
    }

    // Métodos que representan acciones según la profesión
    public void Cocinar()
    {
        Console.WriteLine($"{Nombre} está cocinando deliciosos platillos.");
    }

    public void Construir()
    {
        Console.WriteLine($"{Nombre} está trabajando en un proyecto de construcción.");
    }

    public void AtenderPacientes()
    {
        Console.WriteLine($"{Nombre} está atendiendo a sus pacientes.");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Crear objetos de tipo Persona
        Persona persona1 = new Persona("Juan", "López", 30, false, "123-4567890-1");
        Persona persona2 = new Persona("María", "Gómez", 45, true, "987-6543210-2");
        Persona persona3 = new Persona("Carlos", "Rodríguez", 35, true, "456-7890123-3");
        Persona persona4 = new Persona("Ana", "Martínez", 28, false, "789-1234567-4");
        Persona persona5 = new Persona("Pedro", "Santos", 40, true, "321-6549870-5");
        Persona persona6 = new Persona("Sofía", "Castro", 32, false, "654-9873210-6");
        Persona persona7 = new Persona("Luis", "Fernández", 50, true, "159-7538642-7");

        // Acciones específicas de cada persona
        persona1.Cocinar();  // Ejemplo de chef
        persona2.AtenderPacientes(); // Ejemplo de doctora
        persona3.Construir(); // Ejemplo de ingeniero
        persona4.Cocinar();  // Otra chef
        persona5.Construir(); // Ejemplo de albañil
        persona6.AtenderPacientes(); // Ejemplo de enfermera
        persona7.Cocinar();  // Ejemplo de panadero
    }
}