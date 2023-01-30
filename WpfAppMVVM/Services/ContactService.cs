using Newtonsoft.Json;
using System;
using System.Collections.ObjectModel;
using WpfAppMVVM.MVVM.Models;

namespace WpfAppMVVM.Services;

public static class ContactService
{
    private static ObservableCollection<Contact> contacts;
    private static FileService fileService = new FileService($@"{Environment.GetFolderPath(Environment.SpecialFolder.Desktop)}\wpfContacts.json");

    static ContactService()
    {
        try {
            contacts = JsonConvert.DeserializeObject<ObservableCollection<Contact>>(fileService.ReadFile())!;
        } catch { contacts = new ObservableCollection<Contact>()!; }
    }
    public static void Add(Contact contact)
    {
        contacts ??= new ObservableCollection<Contact>()!;
        contacts.Add(contact);
        fileService.SaveFile(JsonConvert.SerializeObject(contacts, formatting: Formatting.Indented));
    }
    public static void Remove(Contact contact) 
    { 
        contacts.Remove(contact);
        fileService.SaveFile(JsonConvert.SerializeObject(contacts, formatting: Formatting.Indented));
    }

    public static void Edit(Contact contact)
    {

    }

    public static ObservableCollection<Contact> Contacts()
    {
        return contacts;
    }
  
}
