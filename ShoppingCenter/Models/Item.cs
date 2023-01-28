using System.ComponentModel.DataAnnotations;

namespace ShoppingCenter.Models
{
    public class Item
    {
        [Key]
        public int ItemId { get; set; }

        [Required(ErrorMessage = "Field is required. Please enter the product name.")]
        [MinLength(length: 4, ErrorMessage = "Your message must have at least 4 characters")]
        public string? NameItem { get; set; }
        public string? ColorItem { get; set; }
        public string? SizeItem { get; set; }

        [Required(ErrorMessage = "Field is required. Please enter the price.")]
        [RegularExpression(@"^[0-9]", ErrorMessage = "Field is required. Give the correct price for the item.")]
        public decimal PriceItem { get; set; }

        [Required]
        [Url]
        public string? Url { get; set; }

        [Required(ErrorMessage = "Please describe the item.")]
        public string? DescriptionItem { get; set; }
        public List<Shop_Items>? Shop_Items { get; set; }
    }
}
