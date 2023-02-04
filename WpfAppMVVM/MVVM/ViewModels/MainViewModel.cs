using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;


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

    [RelayCommand]
    private void NavEdit()
    {
        CurrentViewModel = new EditContactViewModel();
    }

}
