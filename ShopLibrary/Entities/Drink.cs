
namespace ShopClassLibrary.Entities
{
    public class Drink : Product
    {
        public double QuantityInLiters { get; set; }

        public Drink(double quantityInLiters)
        {
            QuantityInLiters = quantityInLiters;
        }

        public Drink()
        {
        }

        public override string? ToString()
        {
            return $"{Name} costs: {Price}EUR Quantity: {QuantityInLiters} L";
        }
    }
}
