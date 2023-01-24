namespace ShoppingCenter.Models
{
    public class ItemCategory
    {
        public Guid ItemCategoryId { get; set; }
        public string? ItemCategoryName { get; set; }
        public ISet<Item>? items { get; set; }
    }
}
