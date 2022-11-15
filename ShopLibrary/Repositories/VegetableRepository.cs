using ShopClassLibrary.Entities;
using ShopClassLibrary.Services;

namespace ShopClassLibrary.Repositories
{
    public class VegetableRepository
    {
        private FileReaderService Service = new FileReaderService();
        private static List<Vegetable> Vegetables;
        public VegetableRepository()
        {
            Vegetables = Service.GetVegetablesList();
        }
        public static List<Vegetable> GetVegetables()
        {
            return Vegetables;
        }
    }
}
