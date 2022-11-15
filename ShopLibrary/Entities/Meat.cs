
namespace ShopClassLibrary.Entities
{
    public class Meat : Product
    {
        public int ProteinAmount { get; set; }

        public Meat(int proteinAmount)
        {
            ProteinAmount = proteinAmount;
        }

        public Meat()
        {
        }

        public override string? ToString()
        {
            return $"{Name} costs: {Price}EUR Protein: {ProteinAmount} g/100g";
        }
    }
}
