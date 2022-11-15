using ShopClassLibrary.Entities;
using ShopClassLibrary.Services;

namespace ShopClassLibrary.Repositories
{
    public class CandyRepository
    {
        private FileReaderService Service = new FileReaderService();
        private static List<Candy> Candies; 
        public CandyRepository()
        {
            Candies = Service.GetCandiesList();
        }
        public static List<Candy> GetCandies()
        {
            return Candies;
        }
    }
}
