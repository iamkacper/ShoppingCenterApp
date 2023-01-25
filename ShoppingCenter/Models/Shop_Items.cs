namespace ShoppingCenter.Models
{
    public class Shop_Items
    {
        public int Id { get; set; }
        public int ShopId { get; set; }
        public Shop Shop { get; set; }
        public int ItemId { get; set; }
        public Item Item { get; set; }

    }
}
