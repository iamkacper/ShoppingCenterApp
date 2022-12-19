using System.ComponentModel.DataAnnotations;

namespace ShoppingCenter.Models
{
    public class ShopCategory
    {
        [Key]
        public Guid Id { get; set; }
        public string CategoryName { get; set; }
    }
}
