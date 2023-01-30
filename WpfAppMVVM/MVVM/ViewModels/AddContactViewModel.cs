using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using WpfAppMVVM.Services;

namespace WpfAppMVVM.MVVM.ViewModels;

public partial class AddContactViewModel : ObservableObject
{


    [ObservableProperty]
    private string pageTitle = "Add Contact";

    [ObservableProperty]
    private string firstName = string.Empty;

    [ObservableProperty]
    private string lastName = string.Empty;
    
    [ObservableProperty]
    private string email = string.Empty;
    
    [ObservableProperty]
    private string phone = string.Empty;
    
    [ObservableProperty]
    private string adress = string.Empty;
    
    [ObservableProperty]
    private string zipCode = string.Empty;
    
    [ObservableProperty]
    private string city = string.Empty;

    [RelayCommand]
    private void AddContact()
    {
        ContactService.Add(new Models.Contact {
            FirstName= FirstName,
            LastName = LastName,
            Email= Email,
            Phone = Phone,
            Address = Adress,
            ZipCode = ZipCode,
            City = City
        });

        FirstName = string.Empty;
        LastName = string.Empty;
        Email = string.Empty;
        Phone = string.Empty;
        Adress = string.Empty;
        ZipCode = string.Empty;
        City = string.Empty;
    }
}
