
namespace ShopClassLibrary.Entities
{
    public class Vegetable : Product
    {
        public int FibreAmount { get; set; }

        public Vegetable(int fibreAmount)
        {
            FibreAmount = fibreAmount;
        }

        public Vegetable()
        {
        }

        public override string? ToString()
        {
            return $"{Name} costs: {Price}EUR Fibres: {FibreAmount} g/100g";
        }
    }
}
