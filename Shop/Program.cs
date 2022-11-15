using ShopClassLibrary;
using ShopClassLibrary.Services;

public class Program
{
    public static void Main()
    {
        var productMenu = new ProductsMenu();
        var balance = new AccountBalance();
        var cart = new ShoppingCart();
        bool isShopping = true;

        Console.WriteLine(String.Format("{0," + Console.WindowWidth / 2.5 + "}", "--- Welcome to Food Shop ---\n"));
        while (isShopping)
        {
            Console.WriteLine("Menu: [1] Products, [2] Shopping Cart, [3] Money Balance, [4] Exit");
            bool isNumber = int.TryParse(Console.ReadLine(), out int menuChoise);
            
            switch (menuChoise)
            {
                case 1:
                    productMenu.ChooseProducts();
                    continue;
                case 2:
                    ShoppingCart.ShowShoppingCart();
                    decimal totalPrice = ShoppingCart.TotalPrice();
                    if(AccountBalance.Balance >= totalPrice)
                    {
                        ShoppingCart.BuyProducts();
                    }
                    else
                    {
                        Console.WriteLine("Insufficient funds. Please top up your balance!");
                    }
                    continue;
                case 3:
                    Console.WriteLine($"\nYour money balance: {AccountBalance.Balance}");
                    Console.WriteLine("Do you want add funds to your balance? y/n");
                    string answer = Console.ReadLine();
                    switch (answer)
                    {
                        case "y":
                            Console.WriteLine("Enter money amount:");
                            bool isDecimal = decimal.TryParse(Console.ReadLine(), out decimal amount);
                            balance.AddFunds(amount);
                            continue;
                        case "n":
                            break;
                        default:
                            Console.WriteLine("Wrong choice. Please try again!");
                            break;
                    }
                    continue;
                case 4:
                    isShopping = false;
                    break;
                default:
                    Console.WriteLine("Wrong choice. Please enter again!");
                    continue;
            }
        }

    }
}