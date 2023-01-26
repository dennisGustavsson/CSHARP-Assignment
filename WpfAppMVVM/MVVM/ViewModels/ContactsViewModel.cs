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
    /*private readonly FileService fileService;*/

    [ObservableProperty]
    private ObservableCollection<Contact> contacts = ContactService.Contacts();
/*    {
        new Contact() {FirstName="dennis", Email="dennis@mail.com",LastName="Gsson", Phone="945459", Address="gatan 1", ZipCode="39343", City="örebro"}
    };*/



    public ContactsViewModel()
    {
       

    }

    [ObservableProperty]
    private string pageTitle = "Contacts";


}
