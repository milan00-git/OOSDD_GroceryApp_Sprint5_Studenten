using CommunityToolkit.Mvvm.ComponentModel;

namespace Grocery.Core.Models
{
    public partial class Product : Model
    {
        [ObservableProperty]
        public int stock;
        public DateOnly ShelfLife { get; set; }
        public decimal Prijs { get; set;}

        public Product(int id, string name, int stock) : this(id, name, stock, default, 0m) { }

        public Product(int id, string name, int stock, DateOnly shelfLife, decimal prijs) : base(id, name) 
        {
            Stock = stock;
            ShelfLife = shelfLife;
            Prijs = prijs;
        }
        public override string? ToString()
        {
            return $"{Name} - {Stock} op voorraad - €{Prijs:F2}";
        }
    }
}
