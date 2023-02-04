using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;
using WpfAppMVVM.MVVM.Models;
using WpfAppMVVM.Services;

namespace WpfAppMVVM.MVVM.ViewModels;

public partial class ContactsViewModel : ObservableObject
{
    [ObservableProperty]
    private ObservableObject? currentViewModel;

    [ObservableProperty]
    private ObservableCollection<Contact> contacts = ContactService.Contacts();


    [ObservableProperty]
    private Contact selectedContact = null!;


    [ObservableProperty]
    private string pageTitle = "Contacts";




}
