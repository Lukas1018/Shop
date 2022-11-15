using ShopClassLibrary.Entities;

namespace ShopClassLibrary.Services
{
    public class FileReaderService
    {
        string candiesFilePath = AppDomain.CurrentDomain.BaseDirectory + "\\Data\\Candies.csv";
        string drinksFilePath = AppDomain.CurrentDomain.BaseDirectory + "\\Data\\Drinks.csv";
        string meatsFilePath = AppDomain.CurrentDomain.BaseDirectory + "\\Data\\Meat.csv";
        string vegetablesFilePath = AppDomain.CurrentDomain.BaseDirectory + "\\Data\\Vegetables.csv";
        
        private List<string[]> ConvertCsvToList(string filePath)
        {
            var productList = new List<string[]>();

            using (StreamReader sr = new StreamReader(filePath))
            {
                string header = sr.ReadLine();
                while (!sr.EndOfStream)
                {
                    var line = sr.ReadLine();
                    string[] product = line.Split(",");
                    productList.Add(product);
                }
            }
            return productList;
        }
        public List<Candy> GetCandiesList()
        {
            var candies = new List<Candy>();
            var tempList = ConvertCsvToList(candiesFilePath);
            foreach (var product in tempList)
            {
                try
                {
                    var candy = new Candy();
                    candy.Name = product[0];
                    candy.SugarAmount = Convert.ToInt32(product[1]);
                    candy.Price = Convert.ToDecimal(product[2]);
                    candy.Barcode = Convert.ToInt32(product[3]);
                    candy.Weight = Convert.ToDouble(product[4]);
                    candies.Add(candy);
                }
                catch(Exception e)
                {
                    Console.WriteLine(e.Message);
                    Console.WriteLine(product[0]);
                }
            }
            return candies;
        }
        public List<Drink> GetDrinksList()
        {
            var drinks = new List<Drink>();
            var tempList = ConvertCsvToList(drinksFilePath);
            foreach (var product in tempList)
            {
                try
                {
                    var drink = new Drink();
                    drink.Name = product[0];
                    drink.QuantityInLiters = Convert.ToDouble(product[1]);
                    drink.Price = Convert.ToDecimal(product[2]);
                    drink.Barcode = Convert.ToInt32(product[3]);
                    drink.Weight = Convert.ToDouble(product[4]);
                    drinks.Add(drink);
                }
                catch(Exception e)
                {
                    Console.WriteLine(e.Message);
                    Console.WriteLine(product[0]);
                }
            }
            return drinks;
        }

        public List<Meat> GetMeatsList()
        {
            var meats = new List<Meat>();
            var tempList = ConvertCsvToList(meatsFilePath);
            foreach (var product in tempList)
            {
                try
                {
                    var meat = new Meat();
                    meat.Name = product[0];
                    meat.ProteinAmount = Convert.ToInt32(product[1]);
                    meat.Price = Convert.ToDecimal(product[2]);
                    meat.Barcode = Convert.ToInt32(product[3]);
                    meat.Weight = Convert.ToDouble(product[4]);
                    meats.Add(meat);
                }
                catch(Exception e)
                {
                    Console.WriteLine(e.Message);
                    Console.WriteLine(product[0]);
                }
            }
            return meats;
        }

        public List<Vegetable> GetVegetablesList()
        {
            var vegetables = new List<Vegetable>();
            var tempList = ConvertCsvToList(vegetablesFilePath);
            foreach (var product in tempList)
            {
                try
                {
                    var vegetable = new Vegetable();
                    vegetable.Name = product[0];
                    vegetable.FibreAmount = Convert.ToInt32(product[1]);
                    vegetable.Price = Convert.ToDecimal(product[2]);
                    vegetable.Barcode = Convert.ToInt32(product[3]);
                    vegetable.Weight = Convert.ToDouble(product[4]);
                    vegetables.Add(vegetable);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    Console.WriteLine(product[0]);
                }
            }
            return vegetables;
        }
    }
}
