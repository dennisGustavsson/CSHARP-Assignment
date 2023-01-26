﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
        } catch {
        contacts = new ObservableCollection<Contact>();
        }
    }
    public static void Add(Contact contact)
    {
        contacts.Add(contact);
        fileService.SaveFile(JsonConvert.SerializeObject(contacts));
    }
    public static void Remove(Contact contact) 
    { 
        contacts.Remove(contact);
        fileService.SaveFile(JsonConvert.SerializeObject(contacts));
    }

    public static ObservableCollection<Contact> Contacts()
    {
        return contacts;
    }
  
}