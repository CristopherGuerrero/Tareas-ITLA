using System;
using System.Diagnostics.Contracts;

class Program
{
    static void Main(string[] args)
    {
        Agenda miAgenda = new Agenda();
        bool ejecutando = true;

        Console.WriteLine("Mi Agenda Perrón");
        Console.WriteLine("Bienvenido a tu lista de contactos");

        while (ejecutando)
        {
            Console.WriteLine("\nOpciones:");
            Console.WriteLine("1. Agregar Contacto");
            Console.WriteLine("2. Ver Contactos");
            Console.WriteLine("3. Buscar Contacto");
            Console.WriteLine("4. Modificar Contacto");
            Console.WriteLine("5. Eliminar Contacto");
            Console.WriteLine("6. Salir");
            Console.Write("Elige una opción: ");

            int opcion = Convert.ToInt32(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    Console.Write("Digite el Nombre: ");
                    string nombre = Console.ReadLine();
                    Console.Write("Digite el Teléfono: ");
                    string telefono = Console.ReadLine();
                    Console.Write("Digite el Email: ");
                    string email = Console.ReadLine();
                    Console.Write("Digite la Dirección: ");
                    string direccion = Console.ReadLine();
                    int id = miAgenda.ObtenerContactos().Count + 1; // Generar Id automáticamente
                    miAgenda.AgregarContacto(new Contacto(id, nombre, telefono, email, direccion));
                    break;

                case 2:
                    miAgenda.VerContactos();
                    break;

                case 3:
                    Console.Write("Digite el Id del Contacto: ");
                    int idBuscar = Convert.ToInt32(Console.ReadLine());
                    Contacto contacto = miAgenda.BuscarContacto(idBuscar);
                    if (contacto != null)
                    {
                        Console.WriteLine(contacto.ToString());
                    }
                    else
                    {
                        Console.WriteLine($"Contacto con Id {idBuscar} no encontrado.");
                    }
                    break;

                case 4:
                    Console.Write("Digite el Id del Contacto: ");
                    int idModificar = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Digite el Nuevo Nombre: ");
                    string nuevoNombre = Console.ReadLine();
                    Console.Write("Digite el Nuevo Teléfono: ");
                    string nuevoTelefono = Console.ReadLine();
                    Console.Write("Digite el Nuevo Email: ");
                    string nuevoEmail = Console.ReadLine();
                    Console.Write("Digite la Nueva Dirección: ");
                    string nuevaDireccion = Console.ReadLine();
                    miAgenda.ModificarContacto(idModificar, nuevoNombre, nuevoTelefono, nuevoEmail, nuevaDireccion);
                    break;

                case 5:
                    Console.Write("Digite el Id del Contacto: ");
                    int idEliminar = Convert.ToInt32(Console.ReadLine());
                    miAgenda.EliminarContacto(idEliminar);
                    break;

                case 6:
                    ejecutando = false;
                    Console.WriteLine("¡Gracias por usar Mi Agenda Perrón!");
                    break;

                default:
                    Console.WriteLine("Opción no válida.");
                    break;
            }
        }
    }
}