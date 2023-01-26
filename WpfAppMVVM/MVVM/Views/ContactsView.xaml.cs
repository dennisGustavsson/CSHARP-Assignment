using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
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

            ContactService.Remove(contact);
            
        }
    }
}
