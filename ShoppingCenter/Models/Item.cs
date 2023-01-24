using System.ComponentModel.DataAnnotations;

namespace ShoppingCenter.Models
{
    public class Item
    {
        [Key]
        public Guid ItemId { get; set; }
        public Guid ShopId { get; set; }
        public string? NameItem { get; set; }
        public string? ColorItem { get; set; }
        public string? SizeItem { get; set; }
        public int AvailabilityItem { get; set; }
        public decimal PriceItem { get; set; }
        public string? Url { get; set; }
        public string? DescriptionItem { get; set; }
        public Shop? Shop { get; set; }
        public ISet<ItemCategory>? Categories { get; set; }
        public List<CustomerShoppingCartItem>? CustomerShoppingCartItem { get; set; }
        public List<ItemTransaction>? ItemTransactions { get; set; }
    }
}
