using System.ComponentModel.DataAnnotations;

namespace ShoppingCenter.Models
{
    public class CustomerShoppingCartItem
    {
        public Guid CustomerShoppingCartItemId { get; set; }
        public Guid CustomerShoppingCartId { get; set; }
        public CustomerShoppingCart? CustomerShoppingCart { get; set; }
        public Guid ItemId { get; set; }
        public Item? Item { get; set; }
    }
}
