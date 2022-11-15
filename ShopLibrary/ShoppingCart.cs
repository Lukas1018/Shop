using ShopClassLibrary.Entities;
using ShopClassLibrary.Services;

namespace ShopClassLibrary
{
    public class ShoppingCart
    {
        private static List<Product> Products = new List<Product>();

        public static void AddProductsToCart(List<Product> products)
        {
            foreach (var product in products)
            {
                Products.Add(product);
            }
        }
        public static void ShowShoppingCart()
        {
            if (Products.Count != 0)
            {
                Console.WriteLine("\nYour shopping cart:\n");
                foreach (var product in Products)
                {
                    Console.WriteLine($"{product.Name} (barcode: {product.Barcode}) price: {product.Price}EUR");
                }
                Console.WriteLine($"\t\tTotal: {TotalPrice()}EUR\n");
            }
            else
            {
                Console.WriteLine("Your shopping cart: empty\n");
            }
        }
        public static decimal TotalPrice()
        {
            decimal totalPrice = 0;
            foreach (var product in Products)
            {
                totalPrice += product.Price;
            }
            return totalPrice;
        }
        public static void BuyProducts()
        {
            if (Products.Count != 0)
            {
                Console.WriteLine("Proceed to checkout? y/n");
                var choise = Console.ReadLine();
                switch (choise)
                {
                    case "y":
                        List<string> tempReceipt = new List<string>();
                        foreach (Product product in Products)
                        {
                            tempReceipt.Add($"{product.Name} {product.Barcode} {product.Price}EUR");
                        }
                        tempReceipt.Add($"Total price: {TotalPrice()}EUR\nReceipt date: {DateTime.Now}\n");
                        string receipt = string.Join("\n", tempReceipt.ToArray());
                        Console.WriteLine($"\nThank you for shopping in our shop!\n\nYour receipt:\n{receipt}");
                        Console.WriteLine("Do you want get receipt to email? y/n");
                        string answer = Console.ReadLine();
                        switch (answer)
                        {
                            case "y":
                                Console.WriteLine("Enter your email:");
                                string receiver = Console.ReadLine();
                                var Email = new SendEmailService();
                                Email.SendEmail(receipt, receiver);
                                Console.WriteLine("Receipt sent to your email.\n");
                                break;
                            case "n":
                                break;
                            default:
                                Console.WriteLine("Wrong choice. Please try again!\n");
                                break;
                        }
                        AccountBalance.DiscountMoney();
                        Products.Clear();
                        break;
                    case "n":
                        break;
                }
            }
        }
    }
}
