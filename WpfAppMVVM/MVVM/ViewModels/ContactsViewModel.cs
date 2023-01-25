using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfAppMVVM.MVVM.Models;
using WpfAppMVVM.Services;

namespace WpfAppMVVM.MVVM.ViewModels;

public partial class ContactsViewModel : ObservableObject
{
    private readonly FileService fileService;

    [ObservableProperty]
    private ObservableCollection<Contact> contacts;

/*    public Contact SelectedContact { get; set; } = null!;*/

    public ContactsViewModel()
    {
        fileService = new FileService();
        contacts = fileService.Contacts();
    }

    [ObservableProperty]
    private string pageTitle = "Contacts";

    [RelayCommand]
    private void RemoveContact()
    {
        /*Contacts.Remove();*/
    }
}
