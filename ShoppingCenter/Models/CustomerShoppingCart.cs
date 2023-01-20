using ShoppingCenter.Areas.Identity.Data;
using System.ComponentModel.DataAnnotations;

namespace ShoppingCenter.Models
{
    public class CustomerShoppingCart
    {
        [Key]
        public Guid CustomerId { get; set; }
        public ShoppingCenterUser? Customer { get; set; }
        public List<CustomerShoppingCartItem>? CustomerShoppingCartItems { get; set; }
    }
}
