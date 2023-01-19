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
    private ObservableObject currentViewModel;

    [RelayCommand]
    private void AddContact()
    {
        CurrentViewModel = new AddContactViewModel();
    }

    [RelayCommand]
    private void Contacts() 
    {
        CurrentViewModel = new ContactsViewModel();
    }


    public MainViewModel()
    {
        CurrentViewModel = new ContactsViewModel();
    }
}
