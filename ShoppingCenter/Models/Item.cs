using System.ComponentModel.DataAnnotations;

namespace ShoppingCenter.Models
{
    public class Item
    {
        [Key]
        public int ItemId { get; set; }
        public string? NameItem { get; set; }
        public string? ColorItem { get; set; }
        public string? SizeItem { get; set; }
        public int AvailabilityItem { get; set; }
        public decimal PriceItem { get; set; }
        public string? Url { get; set; }
        public string? DescriptionItem { get; set; }
        public List<Shop_Items>? Shop_Items { get; set; }
        public ISet<ItemCategory>? Categories { get; set; }
        public List<CustomerShoppingCartItem>? CustomerShoppingCartItem { get; set; }
        public List<ItemTransaction>? ItemTransactions { get; set; }
    }
}
