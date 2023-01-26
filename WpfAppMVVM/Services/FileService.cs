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

    private string _filePath;

    public FileService(string filePath)
    {
        _filePath = filePath;
    }

    public string ReadFile()
    {
        if (File.Exists(_filePath))
        {
            using var sr = new StreamReader(_filePath);
            return sr.ReadToEnd();
        }
        return string.Empty;
    }

    public void SaveFile(string data)
    {
            using var sw = new StreamWriter(_filePath);
             sw.WriteLine(data);
        
    }
/*    public static void ReadFile()
    {
        try
        {
            using var sr = new StreamReader(filePath);
            contacts = JsonConvert.DeserializeObject<ObservableCollection<Contact>>(sr.ReadToEnd())!;
        }
        catch
        {
            contacts = new ObservableCollection<Contact>();
        }
    }*/

    /*    public static void SaveFile()
        {
            using var sw = new StreamWriter(filePath);
            sw.WriteLine(JsonConvert.SerializeObject(contacts, formatting:Formatting.Indented));
        }*/

    /*    public static void AddToList(Contact contact)
        {
            contacts.Add(contact);
            SaveFile();
        }*/

    /*    public static void Remove(Contact contact)
        {
            contacts.Remove(contact);
            SaveFile();
        }*/



    /*    public static ObservableCollection<Contact> Contacts()
        {
            var items = new ObservableCollection<Contact>();
            foreach (var contact in contacts)
            {
                items.Add(contact);
            }
            return items;
        */

};


