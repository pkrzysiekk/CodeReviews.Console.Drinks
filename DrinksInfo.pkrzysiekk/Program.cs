using DrinksInfo.Views;


namespace DrinksInfo
{
    internal class Program
    {
        static async Task Main()
        {
          MainMenu mainMenu = new();
          await mainMenu.ShowAsync();
            

        }
    }
}
