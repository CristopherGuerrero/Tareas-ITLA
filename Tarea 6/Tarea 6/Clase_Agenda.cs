﻿using System;
using System.Collections.Generic;

public class Agenda
{
    private List<Contacto> contactos = new List<Contacto>();

    // Método para agregar un contacto
    public void AgregarContacto(Contacto contacto)
    {
        contactos.Add(contacto);
        Console.WriteLine($"Contacto {contacto.Nombre} agregado exitosamente.");
    }

    // Método para ver todos los contactos
    public void VerContactos()
    {
        Console.WriteLine("Lista de Contactos:");
        foreach (var contacto in contactos)
        {
            Console.WriteLine(contacto.ToString());
        }
    }

    // Método para buscar un contacto por Id
    public Contacto BuscarContacto(int id)
    {
        return contactos.Find(c => c.Id == id);
    }

    // Método para modificar un contacto
    public void ModificarContacto(int id, string nombre, string telefono, string email, string direccion)
    {
        Contacto contacto = BuscarContacto(id);
        if (contacto != null)
        {
            contacto.Nombre = nombre;
            contacto.Telefono = telefono;
            contacto.Email = email;
            contacto.Direccion = direccion;
            Console.WriteLine($"Contacto {id} modificado exitosamente.");
        }
        else
        {
            Console.WriteLine($"Contacto con Id {id} no encontrado.");
        }
    }

    // Método para eliminar un contacto
    public void EliminarContacto(int id)
    {
        Contacto contacto = BuscarContacto(id);
        if (contacto != null)
        {
            contactos.Remove(contacto);
            Console.WriteLine($"Contacto {id} eliminado exitosamente.");
        }
        else
        {
            Console.WriteLine($"Contacto con Id {id} no encontrado.");
        }
    }
    public List<Contacto> ObtenerContactos()
    {
        return contactos; // Retorna la lista completa de contactos
    }
}

