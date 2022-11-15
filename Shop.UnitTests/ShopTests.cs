using ShopClassLibrary;
using ShopClassLibrary.Entities;
using ShopClassLibrary.Services;
namespace Shop.UnitTests
{
    public class ShopTests
    {
        [Fact]
        public void TestCandyCsvConvertToCandyList()
        {
            var fileReader = new FileReaderService();
            var result = fileReader.GetCandiesList();
            Assert.IsType<List<Candy>>(result);
        }
        [Fact]
        public void TestTotalShoppingCartPrice()
        {
            var result = ShoppingCart.TotalPrice();
            Assert.Equal(0m, result);
        } [Fact]
        public void TestAddFundsToBalance()
        {
            decimal amount = 10m;
            var balance = new AccountBalance();
            balance.AddFunds(amount);
            Assert.Equal(AccountBalance.Balance, amount);
            
        }
    }
}