using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfAppMVVM.MVVM.Models;
using WpfAppMVVM.MVVM.Views;

namespace WpfAppMVVM.Services;

public class FileService
{
    private string filePath = $@"{Environment.GetFolderPath(Environment.SpecialFolder.Desktop)}\wpfContacts.json";
    private List<Contact> contacts;

    public FileService() => ReadFile();

    private void ReadFile()
    {
        try
        {
            using var sr = new StreamReader(filePath);
            contacts = JsonConvert.DeserializeObject<List<Contact>>(sr.ReadToEnd())!;
        }
        catch
        {
            contacts = new List<Contact>();
        }
    }

    private void SaveFile()
    {
        using var sw = new StreamWriter(filePath);
        sw.WriteLine(JsonConvert.SerializeObject(contacts, formatting:Formatting.Indented));
    }

    public void AddToList(Contact contact)
    {
        contacts.Add(contact);
        SaveFile();
    }

   public ObservableCollection<Contact> Contacts()
    {
        var items = new ObservableCollection<Contact>();
        foreach (var contact in contacts)
        {
            items.Add(contact);
        }
        return items;
    }
}


