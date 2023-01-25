using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfAppMVVM.MVVM.ViewModels;

public partial class MainViewModel : ObservableObject

{
    [ObservableProperty]
    private ObservableObject currentViewModel = new ContactsViewModel();

    [RelayCommand]
    private void NavAddContact()
    {
        CurrentViewModel = new AddContactViewModel();
    }

    [RelayCommand]
    private void NavContacts() 
    {
        CurrentViewModel = new ContactsViewModel();
    }


}
