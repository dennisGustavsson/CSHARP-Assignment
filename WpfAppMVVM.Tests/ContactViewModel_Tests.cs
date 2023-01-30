using System.Collections.ObjectModel;
using WpfAppMVVM.MVVM.Models;
using WpfAppMVVM.MVVM.ViewModels;

namespace WpfAppMVVM.Tests
{
    public class ContactViewModel_Tests
    {

        //Arrange
        public ContactsViewModel vm;
        public ContactViewModel_Tests()
        {
            vm = new ContactsViewModel();
        }

        [Fact]
        public void Check_if_Contact_adds_to_List()
        {
            //Act

            //contact
            Contact contact = new Contact();
            //contactlist
            vm.Contacts.Add(contact);

            //Assert

            vm.Contacts.Contains(contact);
            Assert.IsType<ObservableCollection<Contact>>(vm.Contacts);
        }


    }
}