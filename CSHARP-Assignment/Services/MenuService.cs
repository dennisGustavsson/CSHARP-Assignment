using CSHARP_Assignment.Interfaces;
using CSHARP_Assignment.Models;
using Newtonsoft.Json;

namespace CSHARP_Assignment.Services;

public class MenuService
{
    public string FilePath { get; set; } = null!;
    public List<Contact> contacts = new List<Contact>();
    private FileService fileService = new FileService();
    public bool runningApp { get; set; } = true;


    public void MainMenu()
    {
        contacts = JsonConvert.DeserializeObject<List<Contact>>(fileService.Read(FilePath)) ?? null!;

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

        Contact contact = new Contact();
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
        Console.Write("Ange ett postnummer: ");
        contact.ZipCode = Console.ReadLine() ?? null!;
        Console.Write("Ange en stad: ");
        contact.City = Console.ReadLine() ?? null!;

        //Adding created contact to list
        contacts.Add(contact);
        fileService.Save(FilePath, JsonConvert.SerializeObject(contacts));
        Console.WriteLine("\tKontaken är skapad!");
        Console.ReadKey();


    }

    private void GetAllContacts()
    {
        Console.Clear();
        Console.WriteLine("VISA ALLA KONTAKTER: \n ");
        
        foreach(var contact in contacts)
        {
            Console.WriteLine($"{contact.FirstName} {contact.LastName} " +
                $"\n {contact.Email}" +
                $"\n {contact.Address} {contact.ZipCode}, {contact.City}" +
                $"\n {contact.Phone}\n ");
        }
        Console.ReadLine();
    }
    private void GetContact()
    {
        Console.WriteLine("\n SÖK PÅ FÖRNAMN: ");

        var name = Console.ReadLine();

        if (name != null)
        {
            bool contactExist = false;

            foreach (var contact in contacts)
            {
                if (name == contact.FirstName)
                {
                    contactExist = true;
                    Console.WriteLine($"{contact.FirstName} {contact.LastName} " +
                         $"\n {contact.Email}" +
                         $"\n {contact.Address} {contact.ZipCode}, {contact.City}" +
                         $"\n {contact.Phone}\n ");
                }
            }
            if(!contactExist )
            {
                Console.WriteLine("Hittade ingen matchande kontakt");
            }
        }
        Console.ReadLine();

    }
    private void RemoveContact()
    {
        Console.WriteLine("\n ANGE EPOSTADRESSEN TILL KONTAKTEN DU VILL TA BORT: ");

        var _email = Console.ReadLine();

        if(_email != null ) {

            bool contactExist = false;

            foreach (var contact in contacts)
            {
                if (_email == contact.Email)
                {
                    contactExist = true;
                    Console.WriteLine("Är det säkert att du vill ta bort kontakten? [ y / n ]");
                    string? answer = Console.ReadLine();
                    if (answer?.ToLower() == "y")
                    {
                        
                        contacts.Remove(contact);
                        fileService.Save(FilePath, JsonConvert.SerializeObject(contacts));
                        Console.WriteLine("Kontakten är borttagen");
                        break;
                    }
                    else
                    {

                        Console.WriteLine("Borttagningen avbröts..");
                    }
                    
                } 

            }
            if(!contactExist)
            {
                Console.WriteLine("Hittade ingen matchande kontakt");
            }
        }

        




        Console.ReadLine();
    }
    private void CloseApp   ()
    {
        Console.WriteLine("\n VILL DU AVSLUTA PROGRAMMET? [ y / n ]");
        string? answer = Console.ReadLine();
        if(answer == "y")
        {
            runningApp = false;
        }

    }
}
