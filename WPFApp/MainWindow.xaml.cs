using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using WPFApp.Models;
using WPFApp.Services;

namespace WPFApp
{

    public partial class MainWindow : Window
    {
        private ObservableCollection<Contact> contacts;
        private readonly FileService fileService = new FileService();
        public MainWindow()
        {
            InitializeComponent();
            fileService.FilePath = @$"{Environment.GetFolderPath(Environment.SpecialFolder.Desktop)}\contentwpf.json";
            contacts = new ObservableCollection<Contact>();
            LoadContactsList();
        }

        private void LoadContactsList()
        {
            try
            {
                var items = JsonConvert.DeserializeObject<ObservableCollection<Contact>>(fileService.Read());
                if (items != null)
                {
                    contacts = items;
                }
                
            } catch { }

            lv_Contacts.ItemsSource = contacts;
        }

        private void Btn_Add_Click(object sender, RoutedEventArgs e)
        {
            contacts.Add(new Contact
            {
                FirstName = tb_FirstName.Text,
                LastName = tb_LastName.Text,
                Email = tb_Email.Text,
                Phone = tb_Phone.Text,
                Adress = tb_Adress.Text
            });
            //saves contact to json-file
            fileService.Save(JsonConvert.SerializeObject(contacts));
            ClearForms();
        }
        private void ClearForms()
        {
            tb_FirstName.Text = "";
            tb_LastName.Text = "";
            tb_Email.Text = "";
            tb_Phone.Text = "";
            tb_Adress.Text = "";
        }
    }
}
