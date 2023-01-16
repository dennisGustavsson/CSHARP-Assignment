using CSHARP_Assignment.Services;

var menu = new MenuService();
menu.FilePath = $@"{Environment.GetFolderPath(Environment.SpecialFolder.Desktop)}\content.json";

while (true)
{
    Console.Clear();
    
    menu.MainMenu();
}