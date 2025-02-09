using System;

public class ParImpar
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Ingrese un número:");
        int numero = int.Parse(Console.ReadLine());

        if (numero % 2 == 0)
        {
            Console.WriteLine(numero + " es par.");
        }
        else
        {
            Console.WriteLine(numero + " es impar.");
        }
    }
}