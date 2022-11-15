
namespace ShopClassLibrary.Entities
{
    public class Candy : Product
    {
        public int SugarAmount { get; set; }

        public Candy(int sugarAmount)
        {
            SugarAmount = sugarAmount;
        }
        public Candy()
        {
        }

        public override string? ToString()
        {
            return $"{Name} costs: {Price}EUR Sugar: {SugarAmount} g/100g";
        }
    }
}
