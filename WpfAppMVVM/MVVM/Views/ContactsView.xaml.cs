using CommunityToolkit.Mvvm.Input;

using System.Windows;
using System.Windows.Controls;

using WpfAppMVVM.MVVM.Models;
using WpfAppMVVM.Services;

namespace WpfAppMVVM.MVVM.Views
{
    /// <summary>
    /// Interaction logic for ContactsView.xaml
    /// </summary>
    public partial class ContactsView : UserControl
    {

        public ContactsView()
        {
            InitializeComponent();

        }

        private void btn_EditContact_Click(object sender, RoutedEventArgs e)
        {
            var button = (Button)sender;
            var contact = (Contact)button.DataContext;

        }

        private void btn_RemoveContact_Click(object sender, RoutedEventArgs e)
        {
            var button = (Button)sender;
            var contact = (Contact)button.DataContext;

            if(MessageBox.Show("Delete Contact?", "Question", MessageBoxButton.YesNo, MessageBoxImage.Warning) == MessageBoxResult.Yes)
            {
                ContactService.Remove(contact);
            }
            
            
        }
    }
}
