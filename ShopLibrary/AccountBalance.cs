namespace ShopClassLibrary
{
    public class AccountBalance
    {
        public static decimal Balance { get; private set; }

        public AccountBalance()
        {
            Balance = 0;
        }

        public void AddFunds(decimal amount)
        {
            Balance += amount;
            Console.WriteLine($"Your new money balance: {Balance}");
        }
        public static void DiscountMoney()
        {
            decimal totalPrice = ShoppingCart.TotalPrice();
            Balance -= totalPrice;
        }
    }
}
