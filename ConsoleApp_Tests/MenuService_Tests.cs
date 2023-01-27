using CSHARP_Assignment.Services;

namespace ConsoleApp_Tests
{
    public class MenuService_Tests
    {

        private MenuService menuService;
        CSHARP_Assignment.Models.Contact contact;

        public MenuService_Tests() {
            // ARRANGE
        menuService = new MenuService();
        contact = new CSHARP_Assignment.Models.Contact();
        }
        


        [Fact]
        public void Contact_Is_Added_To_List()
        {
            // ACT/ARRANGE
            menuService.contacts.Add(contact);

            // ASSERT
            Assert.Single(menuService.contacts);
        }

        [Fact]
        public void Contact_Is_Removed_From_List()
        {
            // ARRANGE
            menuService.contacts.Add(contact);
            menuService.contacts.Add(contact);
            menuService.contacts.Add(contact);

            // ACT 
            menuService.contacts.Remove(contact);

            // ASSERT
            Assert.Equal(2, menuService.contacts.Count);
        }
    }
}