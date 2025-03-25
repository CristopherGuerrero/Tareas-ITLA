using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<decimal> numerosIngresados = new List<decimal>();
        decimal resultado = 0;
        int opcionSeleccionada = 1;
        bool ejecutando = true;

        Console.WriteLine("Esta es la mejor calculadora");

        while (ejecutando)
        {
            MostrarEncabezado();

            try
            {
                opcionSeleccionada = Convert.ToInt32(Console.ReadLine());

                if (opcionSeleccionada == 5)
                {
                    ejecutando = false;
                }
                else
                {
                    numerosIngresados.Clear(); // Limpiar la lista antes de agregar nuevos números

                    Console.WriteLine("Por favor, ingrese el primer número:");
                    numerosIngresados.Add(Convert.ToDecimal(Console.ReadLine()));

                    Console.WriteLine("Por favor, ingrese el segundo número:");
                    numerosIngresados.Add(Convert.ToDecimal(Console.ReadLine()));

                    // Realizar la operación según la opción elegida
                    switch (opcionSeleccionada)
                    {
                        case 1:
                            resultado = Sumar(numerosIngresados);
                            break;
                        case 2:
                            resultado = Restar(numerosIngresados);
                            break;
                        case 3:
                            resultado = Multiplicar(numerosIngresados);
                            break;
                        case 4:
                            resultado = Dividir(numerosIngresados);
                            break;
                        default:
                            Console.WriteLine("Opción no válida. Inténtelo de nuevo.");
                            continue;
                    }

                    Console.WriteLine($"El resultado de la operación es: {resultado}");
                }
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine($"Error: No se puede dividir por cero. {ex.Message}");
            }
            catch (FormatException ex)
            {
                Console.WriteLine($"Error: Entrada no válida. {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ha ocurrido un error inesperado: {ex.Message}");
            }
        }
    }

    // Método para sumar
    static decimal Sumar(List<decimal> numeros)
    {
        decimal resultado = 0;
        foreach (decimal numero in numeros)
        {
            resultado += numero;
        }
        return resultado;
    }

    // Método para restar
    static decimal Restar(List<decimal> numeros)
    {
        decimal resultado = numeros[0]; // Inicializar con el primer número
        for (int i = 1; i < numeros.Count; i++)
        {
            resultado -= numeros[i];
        }
        return resultado;
    }

    // Método para multiplicar
    static decimal Multiplicar(List<decimal> numeros)
    {
        decimal resultado = 1; // Inicializar con 1 para multiplicar correctamente
        foreach (decimal numero in numeros)
        {
            resultado *= numero;
        }
        return resultado;
    }

    // Método para dividir
    static decimal Dividir(List<decimal> numeros)
    {
        decimal resultado = numeros[0]; // Inicializar con el primer número
        for (int i = 1; i < numeros.Count; i++)
        {
            if (numeros[i] == 0)
            {
                throw new DivideByZeroException("No se puede dividir entre cero.");
            }
            resultado /= numeros[i];
        }
        return resultado;
    }

    // Método para mostrar el encabezado
    static void MostrarEncabezado()
    {
        Console.WriteLine("Por favor, seleccione la opción que desea:");
        Console.WriteLine("---------------------------------------");
        Console.WriteLine("1. Sumar\n2. Restar\n3. Multiplicar\n4. Dividir\n5. Salir");
    }
}