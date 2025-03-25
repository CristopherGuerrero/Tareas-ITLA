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

    // Ejemplo de métodos diferentes por profesión
    public void Trabajar()
    {
        Console.WriteLine($"{Nombre} está trabajando en su profesión.");
    }

    public void Estudiar()
    {
        Console.WriteLine($"{Nombre} está estudiando para obtener más conocimientos.");
    }

    public void Enseñar()
    {
        Console.WriteLine($"{Nombre} está enseñando a otros.");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Ejemplos de personas
        Persona persona1 = new Persona("Carlos", "García", 30, false, "001-1234567-1");
        Persona persona2 = new Persona("Ana", "Pérez", 45, true, "002-7654321-2");
        Persona persona3 = new Persona("Luis", "Santos", 27, false, "003-2345678-3");
        Persona persona4 = new Persona("María", "Lopez", 50, true, "004-8765432-4");
        Persona persona5 = new Persona("José", "Mendoza", 35, true, "005-3456789-5");
        Persona persona6 = new Persona("Sandra", "Martínez", 29, false, "006-6543210-6");
        Persona persona7 = new Persona("Diego", "Rodríguez", 33, false, "007-9876543-7");

        // Acciones por profesión
        persona1.Trabajar();  // Ejemplo de ingeniero
        persona2.Enseñar();   // Ejemplo de profesora
        persona3.Estudiar();  // Ejemplo de estudiante
        persona4.Trabajar();  // Ejemplo de doctora
        persona5.Enseñar();   // Ejemplo de entrenador
        persona6.Estudiar();  // Ejemplo de investigadora
        persona7.Trabajar();  // Ejemplo de arquitecto
    }
}