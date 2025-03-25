using System;
class Contador
{
    // Atributo de la clase
    private int valor;

    // Constructor por defecto
    public Contador()
    {
        valor = 0; // Inicializamos el contador en 0
    }

    // Constructor con parámetros
    public Contador(int valorInicial)
    {
        valor = valorInicial;
    }

    // Método para incrementar el contador
    public void Incrementar()
    {
        valor++;
    }

    // Método para decrementar el contador
    public void Decrementar()
    {
        if (valor > 0) // Evitar valores negativos
        {
            valor--;
        }
        else
        {
            Console.WriteLine("El valor no puede ser menor que cero.");
        }
    }

    // Getter para obtener el valor del contador
    public int ObtenerValor()
    {
        return valor;
    }

    // Setter para establecer un valor en el contador
    public void EstablecerValor(int nuevoValor)
    {
        if (nuevoValor >= 0) // Validación básica
        {
            valor = nuevoValor;
        }
        else
        {
            Console.WriteLine("El valor debe ser mayor o igual a cero.");
        }
    }
}
class Program
{
    static void Main(string[] args)
    {
        // Uso del constructor por defecto
        Contador contador1 = new Contador();
        contador1.Incrementar();
        Console.WriteLine("Valor del contador1: " + contador1.ObtenerValor());

        // Uso del constructor con parámetros
        Contador contador2 = new Contador(10);
        contador2.Decrementar();
        Console.WriteLine("Valor del contador2: " + contador2.ObtenerValor());

        // Usando el setter para establecer un valor inicial
        contador1.EstablecerValor(5);
        Console.WriteLine("Nuevo valor del contador1: " + contador1.ObtenerValor());
    }
}