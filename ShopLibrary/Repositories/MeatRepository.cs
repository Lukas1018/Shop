using ShopClassLibrary.Entities;
using ShopClassLibrary.Services;

namespace ShopClassLibrary.Repositories
{
    public class MeatRepository
    {
        private FileReaderService Service = new FileReaderService();
        private static List<Meat> Meats;
        public MeatRepository()
        {
            Meats = Service.GetMeatsList();
        }
        public static List<Meat> GetMeats()
        {
            return Meats;
        }
    }
}
