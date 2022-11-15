using ShopClassLibrary.Entities;
using ShopClassLibrary.Repositories;

namespace ShopClassLibrary
{
    public class ProductsMenu
    {
        public void ChooseProducts()
        {
            var productsList = new List<Product>();
            var cart = new ShoppingCart();
            bool isShopping = true;

            while (isShopping)
            {
                Console.WriteLine("[1] Candies\n[2] Drinks\n[3] Meat\n[4] Vegetables\n[5] Your shopping cart\n[6] Main menu");
                bool isNumber = int.TryParse(Console.ReadLine(), out int productChoise);
                switch (productChoise)
                {
                    case 1:
                        var tempCandiesList = new List<Product>();
                        var candyRepository = new CandyRepository();
                        var candiesList = CandyRepository.GetCandies();
                        for (int i = 0; i < candiesList.Count; i++)
                        {
                            Console.WriteLine($"[{i + 1}] {candiesList[i].ToString()}");
                            tempCandiesList.Add(candiesList[i]);
                        }
                        SelectProductsToCart(tempCandiesList);
                        break;
                    case 2:
                        var tempDrinksList = new List<Product>();
                        var drinkRepository = new DrinkRepository();
                        var drinkslist = DrinkRepository.GetDrinks();
                        for (int i = 0; i < drinkslist.Count; i++)
                        {
                            Console.WriteLine($"[{i + 1}] {drinkslist[i].ToString()}");
                            tempDrinksList.Add(drinkslist[i]);
                        }
                        SelectProductsToCart(tempDrinksList);
                        break;
                    case 3:
                        var tempMeatsList = new List<Product>();
                        var meatRepository = new MeatRepository();
                        var meatsList = MeatRepository.GetMeats();
                        for (int i = 0; i < meatsList.Count; i++)
                        {
                            Console.WriteLine($"[{i + 1}] {meatsList[i].ToString()}");
                            tempMeatsList.Add(meatsList[i]);
                        }
                        SelectProductsToCart(tempMeatsList);
                        break;
                    case 4:
                        var tempVegetablesList = new List<Product>();
                        var vegetableRepository = new VegetableRepository();
                        var vegetablesList = VegetableRepository.GetVegetables();
                        for (int i = 0; i < vegetablesList.Count; i++)
                        {
                            Console.WriteLine($"[{i + 1}] {vegetablesList[i].ToString()}");
                            tempVegetablesList.Add(vegetablesList[i]);
                        }
                        SelectProductsToCart(tempVegetablesList);
                        break;
                    case 5:
                        isShopping = false;
                        ShoppingCart.AddProductsToCart(productsList);
                        ShoppingCart.ShowShoppingCart();
                        decimal totalPrice = ShoppingCart.TotalPrice();
                        if (AccountBalance.Balance >= totalPrice)
                        {
                            ShoppingCart.BuyProducts();
                        }
                        else
                        {
                            Console.WriteLine("Insufficient funds. Please top up your balance!\n");
                        }
                        break;
                    case 6:
                        isShopping = false;
                        ShoppingCart.AddProductsToCart(productsList);
                        break;
                    default:
                        Console.WriteLine("Wrong choice. Please try again!\n");
                        break;
                }
            }
            void SelectProductsToCart(List<Product> list)
            {
                bool isSelectedItemNumber = int.TryParse(Console.ReadLine(), out int selectedItem);
                if(selectedItem <= list.Count)
                {
                    Console.WriteLine("Enter the quantity:");
                    bool isQuantityNumber = int.TryParse(Console.ReadLine(), out int quantity);
                    if (isSelectedItemNumber == true && isQuantityNumber == true)
                    {
                        Console.WriteLine($"{list[selectedItem - 1].Name} (quantity: {quantity}, total price: {list[selectedItem - 1].Price * quantity}EUR) added to your shopping cart.\n");
                        for (int i = 0; i < quantity; i++)
                        {
                            productsList.Add(list[selectedItem - 1]);
                        }
                    }
                    else
                    {
                        Console.WriteLine("Wrong choice. Please try again!");
                    } 
                }
                else
                {
                    Console.WriteLine("Product not found. Tray again!");
                }
            }
        }
    } 
}
