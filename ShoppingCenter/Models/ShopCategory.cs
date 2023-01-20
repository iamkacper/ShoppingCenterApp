using System.ComponentModel.DataAnnotations;

namespace ShoppingCenter.Models
{
    public class ShopCategory
    {
        public Guid ShopCategoryId { get; set; }
        public string? ShopCategoryName { get; set; }
    }
}
