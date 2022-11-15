using ShopClassLibrary.Entities;
using ShopClassLibrary.Services;

namespace ShopClassLibrary.Repositories
{
    public class DrinkRepository
    {
        private FileReaderService Service = new FileReaderService();
        private static List<Drink> Drinks;
        public DrinkRepository()
        {
            Drinks = Service.GetDrinksList();
        }
        public static List<Drink> GetDrinks()
        {
            return Drinks;
        }
    }
}
