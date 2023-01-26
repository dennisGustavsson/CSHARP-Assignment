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


    [ObservableProperty]
    private ObservableCollection<Contact> contacts = ContactService.Contacts();


    [ObservableProperty]
    private Contact selectedContact = null!;

    public ContactsViewModel()
    {
    }

    [ObservableProperty]
    private string pageTitle = "Contacts";


}
