using System;
class Fraccion
{
    // Atributos de la clase
    public int Numerador { get; set; }
    public int Denominador { get; set; }

    // Constructor por defecto
    public Fraccion()
    {
        Numerador = 0;
        Denominador = 1; // Evitamos divisiones entre 0
    }

    // Constructor con parámetros
    public Fraccion(int numerador, int denominador)
    {
        if (denominador == 0)
        {
            throw new ArgumentException("El denominador no puede ser cero.");
        }

        Numerador = numerador;
        Denominador = denominador;
    }

    // Método para sumar dos fracciones
    public Fraccion Sumar(Fraccion otra)
    {
        int nuevoNumerador = (Numerador * otra.Denominador) + (otra.Numerador * Denominador);
        int nuevoDenominador = Denominador * otra.Denominador;
        return new Fraccion(nuevoNumerador, nuevoDenominador);
    }

    // Método para restar dos fracciones
    public Fraccion Restar(Fraccion otra)
    {
        int nuevoNumerador = (Numerador * otra.Denominador) - (otra.Numerador * Denominador);
        int nuevoDenominador = Denominador * otra.Denominador;
        return new Fraccion(nuevoNumerador, nuevoDenominador);
    }

    // Método para multiplicar dos fracciones
    public Fraccion Multiplicar(Fraccion otra)
    {
        int nuevoNumerador = Numerador * otra.Numerador;
        int nuevoDenominador = Denominador * otra.Denominador;
        return new Fraccion(nuevoNumerador, nuevoDenominador);
    }

    // Método para dividir dos fracciones
    public Fraccion Dividir(Fraccion otra)
    {
        if (otra.Numerador == 0)
        {
            throw new ArgumentException("No se puede dividir entre una fracción con numerador 0.");
        }

        int nuevoNumerador = Numerador * otra.Denominador;
        int nuevoDenominador = Denominador * otra.Numerador;
        return new Fraccion(nuevoNumerador, nuevoDenominador);
    }

    // Método ToString para representar la fracción como texto
    public override string ToString()
    {
        return $"{Numerador}/{Denominador}";
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Crear dos fracciones
        Fraccion fraccion1 = new Fraccion(1, 2); // 1/2
        Fraccion fraccion2 = new Fraccion(3, 4); // 3/4

        // Operaciones entre fracciones
        Fraccion suma = fraccion1.Sumar(fraccion2);
        Console.WriteLine($"Suma: {suma}");

        Fraccion resta = fraccion1.Restar(fraccion2);
        Console.WriteLine($"Resta: {resta}");

        Fraccion multiplicacion = fraccion1.Multiplicar(fraccion2);
        Console.WriteLine($"Multiplicación: {multiplicacion}");

        Fraccion division = fraccion1.Dividir(fraccion2);
        Console.WriteLine($"División: {division}");
    }
}