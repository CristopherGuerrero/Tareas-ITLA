﻿using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Console.WriteLine("Bienvenido a mi lista de Contactes");

        List<int> ids = new List<int>();
        Dictionary<int, string> names = new Dictionary<int, string>();
        Dictionary<int, string> lastnames = new Dictionary<int, string>();
        Dictionary<int, string> addresses = new Dictionary<int, string>();
        Dictionary<int, string> telephones = new Dictionary<int, string>();
        Dictionary<int, string> emails = new Dictionary<int, string>();
        Dictionary<int, int> ages = new Dictionary<int, int>();
        Dictionary<int, bool> bestFriends = new Dictionary<int, bool>();

        bool running = true;
        while (running)
        {
            Console.WriteLine("1. Agregar Contacto  2. Ver Contactos  3. Buscar Contacto  4. Modificar Contacto  5. Eliminar Contacto  6. Salir");
            Console.Write("Seleccione una opción: ");
            int option = Convert.ToInt32(Console.ReadLine());

            switch (option)
            {
                case 1:
                    AddContact(ids, names, lastnames, addresses, telephones, emails, ages, bestFriends);
                    break;
                case 2:
                    ViewContacts(ids, names, lastnames, addresses, telephones, emails, ages, bestFriends);
                    break;
                case 3:
                    SearchContact(ids, names, lastnames);
                    break;
                case 4:
                    ModifyContact(ids, names, lastnames, addresses, telephones, emails, ages, bestFriends);
                    break;
                case 5:
                    DeleteContact(ids, names, lastnames, addresses, telephones, emails, ages, bestFriends);
                    break;
                case 6:
                    running = false;
                    break;
                default:
                    Console.WriteLine("Opción no válida.");
                    break;
            }
        }
    }

    static void AddContact(List<int> ids, Dictionary<int, string> names, Dictionary<int, string> lastnames, Dictionary<int, string> addresses, Dictionary<int, string> telephones, Dictionary<int, string> emails, Dictionary<int, int> ages, Dictionary<int, bool> bestFriends)
    {
        Console.Write("Nombre: ");
        string name = Console.ReadLine();
        Console.Write("Apellido: ");
        string lastname = Console.ReadLine();
        Console.Write("Dirección: ");
        string address = Console.ReadLine();
        Console.Write("Teléfono: ");
        string phone = Console.ReadLine();
        Console.Write("Email: ");
        string email = Console.ReadLine();
        Console.Write("Edad: ");
        int age = Convert.ToInt32(Console.ReadLine());
        Console.Write("¿Es mejor amigo? (1. Sí / 2. No): ");
        bool isBestFriend = Convert.ToInt32(Console.ReadLine()) == 1;

        int id = ids.Count + 1;
        ids.Add(id);
        names[id] = name;
        lastnames[id] = lastname;
        addresses[id] = address;
        telephones[id] = phone;
        emails[id] = email;
        ages[id] = age;
        bestFriends[id] = isBestFriend;
    }

    static void ViewContacts(List<int> ids, Dictionary<int, string> names, Dictionary<int, string> lastnames, Dictionary<int, string> addresses, Dictionary<int, string> telephones, Dictionary<int, string> emails, Dictionary<int, int> ages, Dictionary<int, bool> bestFriends)
    {
        Console.WriteLine("ID | Nombre | Apellido | Dirección | Teléfono | Email | Edad | Mejor Amigo?");
        Console.WriteLine("----------------------------------------------------------------------------");
        foreach (var id in ids)
        {
            Console.WriteLine($"{id} | {names[id]} | {lastnames[id]} | {addresses[id]} | {telephones[id]} | {emails[id]} | {ages[id]} | {(bestFriends[id] ? "Sí" : "No")}");
        }
    }

    static void SearchContact(List<int> ids, Dictionary<int, string> names, Dictionary<int, string> lastnames)
    {
        Console.Write("Ingrese el nombre o apellido a buscar: ");
        string query = Console.ReadLine().ToLower();
        foreach (var id in ids)
        {
            if (names[id].ToLower().Contains(query) || lastnames[id].ToLower().Contains(query))
            {
                Console.WriteLine($"Encontrado: ID {id} - {names[id]} {lastnames[id]}");
            }
        }
    }

    static void ModifyContact(List<int> ids, Dictionary<int, string> names, Dictionary<int, string> lastnames, Dictionary<int, string> addresses, Dictionary<int, string> telephones, Dictionary<int, string> emails, Dictionary<int, int> ages, Dictionary<int, bool> bestFriends)
    {
        Console.Write("Ingrese el ID del contacto a modificar: ");
        int id = Convert.ToInt32(Console.ReadLine());
        if (ids.Contains(id))
        {
            Console.Write("Nuevo Nombre: ");
            names[id] = Console.ReadLine();
            Console.Write("Nuevo Apellido: ");
            lastnames[id] = Console.ReadLine();
            Console.Write("Nueva Dirección: ");
            addresses[id] = Console.ReadLine();
            Console.Write("Nuevo Teléfono: ");
            telephones[id] = Console.ReadLine();
            Console.Write("Nuevo Email: ");
            emails[id] = Console.ReadLine();
            Console.Write("Nueva Edad: ");
            ages[id] = Convert.ToInt32(Console.ReadLine());
            Console.Write("¿Es mejor amigo? (1. Sí / 2. No): ");
            bestFriends[id] = Convert.ToInt32(Console.ReadLine()) == 1;
        }
        else
        {
            Console.WriteLine("ID no encontrado.");
        }
    }

    static void DeleteContact(List<int> ids, Dictionary<int, string> names, Dictionary<int, string> lastnames, Dictionary<int, string> addresses, Dictionary<int, string> telephones, Dictionary<int, string> emails, Dictionary<int, int> ages, Dictionary<int, bool> bestFriends)
    {
        Console.Write("Ingrese el ID del contacto a eliminar: ");
        int id = Convert.ToInt32(Console.ReadLine());
        if (ids.Contains(id))
        {
            ids.Remove(id);
            names.Remove(id);
            lastnames.Remove(id);
            addresses.Remove(id);
            telephones.Remove(id);
            emails.Remove(id);
            ages.Remove(id);
            bestFriends.Remove(id);
            Console.WriteLine("Contacto eliminado correctamente.");
        }
        else
        {
            Console.WriteLine("ID no encontrado.");
        }
    }
}
