﻿using CSHARP_Assignment.Interfaces;
using CSHARP_Assignment.Models;

namespace CSHARP_Assignment.Services;

internal class MenuService
{
    private List<IContact> contacts = new List<IContact>();
    public void MainMenu()
    {
        Console.WriteLine("Kontaktboken");
        Console.WriteLine("\t[1] Lägg till ny kontakt");
        Console.WriteLine("\t[2] Visa alla kontakter");
        Console.WriteLine("\t[3] Visa en specifik kontakt");
        Console.WriteLine("\t[4] Ta bort en specifik kontakt");
        Console.WriteLine("\t[5] Avsluta programmet");
        Console.Write("Ange ett av alternativen ovan: ");
        
        var userChoice = Console.ReadLine();

        switch(userChoice)
        {
            case "1": AddNewContact(); break;
            case "2": GetAllContacts(); break;
            case "3": GetContact(); break;
            case "4": RemoveContact(); break;
            case "5": CloseApp(); break;
        }
    }

    private void AddNewContact()
    {
        Console.WriteLine("\n LÄGG TILL EN KONTAKT:");

        IContact contact = new Contact();
        Console.Write("Ange ett förnamn: ");
        contact.FirstName = Console.ReadLine() ?? null!;
        Console.Write("Ange ett efternamn: ");
        contact.LastName= Console.ReadLine() ?? null!;
        Console.Write("Ange en epostadress: ");
        contact.Email = Console.ReadLine() ?? null!;
        Console.Write("Ange ett telefonnummer: ");
        contact.Phone = Console.ReadLine() ?? null!;
        Console.Write("Ange en gatuadress: ");
        contact.Address = Console.ReadLine() ?? null!;
        Console.Write("Ange en postkod: ");
        contact.ZipCode = Console.ReadLine() ?? null!;
        Console.Write("Ange en stad");
        contact.City = Console.ReadLine() ?? null!;

        contacts.Add(contact);

    }

    private void GetAllContacts()
    {
        Console.WriteLine("\n VISA ALLA KONTAKTER:");

        Console.ReadLine();
    }
    private void GetContact()
    {
        Console.WriteLine("\n ANGE ETT NAMN:");

        Console.ReadLine();
    }
    private void RemoveContact()
    {
        Console.WriteLine("\n ANGE EN KONTAKT ATT TA BORT");

        Console.ReadLine();
    }
    private void CloseApp   ()
    {
        Console.WriteLine("\n VILL DU AVSLUTA PROGRAMMET? [ y / n ]");

        Console.ReadLine();
    }
}
